using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageTextOverlay
{
    public partial class Form1 : Form
    {
        private Image currentImage;
        private Image originalImage;
        private string currentImagePath;
        private Color textColor = Color.Black;
        private bool hasText = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void RbCustom_CheckedChanged(object sender, EventArgs e)
        {
            numX.Enabled = rbCustom.Checked;
            numY.Enabled = rbCustom.Checked;
        }

        private Point GetTextPosition(SizeF textSize, Size imageSize)
        {
            int x = 0, y = 0;

            if (rbCustom.Checked)
            {
                x = (int)numX.Value;
                y = (int)numY.Value;
                return new Point(x, y);
            }

            if (rbTopLeft.Checked)
            {
                x = 10;
                y = 10;
            }
            else if (rbTopRight.Checked)
            {
                x = imageSize.Width - (int)textSize.Width - 10;
                y = 10;
            }
            else if (rbBottomLeft.Checked)
            {
                x = 10;
                y = imageSize.Height - (int)textSize.Height - 10;
            }
            else if (rbBottomRight.Checked)
            {
                x = imageSize.Width - (int)textSize.Width - 10;
                y = imageSize.Height - (int)textSize.Height - 10;
            }
            else
            {
                x = (imageSize.Width - (int)textSize.Width) / 2;
                y = (imageSize.Height - (int)textSize.Height) / 2;
            }

            return new Point(x, y);
        }

        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    currentImagePath = openFileDialog1.FileName;
                    originalImage = Image.FromFile(currentImagePath);
                    currentImage = (Image)originalImage.Clone();
                    pictureBox1.Image = currentImage;

                    hasText = false;

                    btnAddText.Enabled = true;
                    btnSave.Enabled = false;
                    btnRemoveText.Enabled = false;

                    lblStatus.Text = $"Загружено: {Path.GetFileName(currentImagePath)}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textColor = colorDialog1.Color;
                btnColor.BackColor = textColor;

                if (textColor.GetBrightness() < 0.5)
                    btnColor.ForeColor = Color.White;
                else
                    btnColor.ForeColor = Color.Black;
            }
        }

        private Image AddTextToImage(Image img, string text, string fontName, float fontSize, Color color)
        {
            Bitmap result = new Bitmap(img.Width, img.Height);

            using (Graphics g = Graphics.FromImage(result))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                g.DrawImage(img, 0, 0, img.Width, img.Height);

                using (Font font = new Font(fontName, fontSize, FontStyle.Bold))
                {
                    SizeF textSize = g.MeasureString(text, font);
                    Point position = GetTextPosition(textSize, img.Size);

                    using (SolidBrush bgBrush = new SolidBrush(Color.FromArgb(150, 255, 255, 255)))
                    {
                        Rectangle bgRect = new Rectangle(position.X - 5, position.Y - 5,
                            (int)textSize.Width + 10, (int)textSize.Height + 10);
                        g.FillRectangle(bgBrush, bgRect);
                    }

                    using (SolidBrush textBrush = new SolidBrush(color))
                    {
                        g.DrawString(text, font, textBrush, position.X, position.Y);
                    }
                }
            }

            return result;
        }

        private void BtnAddText_Click(object sender, EventArgs e)
        {
            if (currentImage == null)
            {
                MessageBox.Show("Сначала выберите изображение!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtText.Text))
            {
                MessageBox.Show("Введите текст надписи!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (hasText && originalImage != null)
                {
                    Image oldImage = currentImage;
                    currentImage = (Image)originalImage.Clone();
                    oldImage.Dispose();
                }

                Image newImage = AddTextToImage(currentImage, txtText.Text, cmbFont.Text,
                                                (float)numFontSize.Value, textColor);

                Image oldImg = currentImage;
                currentImage = newImage;
                pictureBox1.Image = currentImage;
                oldImg.Dispose();

                hasText = true;

                btnSave.Enabled = true;
                btnRemoveText.Enabled = true;

                lblStatus.Text = "Надпись добавлена";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRemoveText_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Нет оригинального изображения!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Image oldImage = currentImage;
                currentImage = (Image)originalImage.Clone();
                pictureBox1.Image = currentImage;
                oldImage.Dispose();

                hasText = false;
                btnRemoveText.Enabled = false;
                btnSave.Enabled = false;

                lblStatus.Text = "Надпись удалена, изображение восстановлено";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (currentImage == null)
            {
                MessageBox.Show("Нет изображения для сохранения!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialog1.FileName = $"result_{DateTime.Now:yyyyMMdd_HHmmss}";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (saveFileDialog1.FilterIndex == 1)
                        currentImage.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    else
                        currentImage.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                    MessageBox.Show("Изображение сохранено!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblStatus.Text = $"Сохранено: {Path.GetFileName(saveFileDialog1.FileName)}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void BtnBatch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolder.Text) || !Directory.Exists(txtFolder.Text))
            {
                MessageBox.Show("Выберите папку с изображениями!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtText.Text))
            {
                MessageBox.Show("Введите текст надписи!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var images = GetImageFiles(txtFolder.Text, chkSubfolders.Checked);

            if (images.Count == 0)
            {
                MessageBox.Show("В выбранной папке нет изображений!", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Найдено {images.Count} изображений.\nПродолжить обработку?",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            int success = 0;
            int errors = 0;

            lblStatus.Text = "Обработка изображений...";
            this.Refresh();

            foreach (string file in images)
            {
                try
                {
                    using (Image img = Image.FromFile(file))
                    {
                        Image resultImg = AddTextToImage(img, txtText.Text, cmbFont.Text,
                                                         (float)numFontSize.Value, textColor);

                        string newName = Path.GetFileNameWithoutExtension(file) + "_text" + Path.GetExtension(file);
                        string newPath = Path.Combine(Path.GetDirectoryName(file), newName);

                        if (Path.GetExtension(file).ToLower() == ".png")
                            resultImg.Save(newPath, System.Drawing.Imaging.ImageFormat.Png);
                        else
                            resultImg.Save(newPath, System.Drawing.Imaging.ImageFormat.Jpeg);

                        resultImg.Dispose();
                        success++;
                    }
                }
                catch
                {
                    errors++;
                }

                lblStatus.Text = $"Обработано: {success + errors} из {images.Count} (успешно: {success})";
                Application.DoEvents();
            }

            MessageBox.Show($"Пакетная обработка завершена!\n\nУспешно: {success}\nОшибок: {errors}",
                "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblStatus.Text = $"Готово. Обработано {success} изображений.";
        }

        private System.Collections.Generic.List<string> GetImageFiles(string folder, bool includeSubfolders)
        {
            var images = new System.Collections.Generic.List<string>();

            var option = includeSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            string[] files = Directory.GetFiles(folder, "*.*", option);

            foreach (string file in files)
            {
                string ext = Path.GetExtension(file).ToLower();
                if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp")
                {
                    images.Add(file);
                }
            }

            return images;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            currentImage?.Dispose();
            originalImage?.Dispose();
            pictureBox1.Image?.Dispose();
        }
    }
}