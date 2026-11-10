namespace ImageTextOverlay
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Все элементы управления
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Button btnAddText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemoveText;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.NumericUpDown numFontSize;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.Button btnBatch;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.CheckBox chkSubfolders;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBoxPosition;
        private System.Windows.Forms.RadioButton rbCenter;
        private System.Windows.Forms.RadioButton rbTopLeft;
        private System.Windows.Forms.RadioButton rbBottomLeft;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.btnAddText = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemoveText = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.numFontSize = new System.Windows.Forms.NumericUpDown();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.btnBatch = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.chkSubfolders = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxPosition = new System.Windows.Forms.GroupBox();
            this.rbTopLeft = new System.Windows.Forms.RadioButton();
            this.rbCenter = new System.Windows.Forms.RadioButton();
            this.rbBottomLeft = new System.Windows.Forms.RadioButton();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.lblX = new System.Windows.Forms.Label();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.lblY = new System.Windows.Forms.Label();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.rbTopRight = new System.Windows.Forms.RadioButton();
            this.rbBottomRight = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(10, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(10, 340);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(120, 35);
            this.btnSelectImage.TabIndex = 1;
            this.btnSelectImage.Text = "Выбрать изображение";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.BtnSelectImage_Click);
            // 
            // btnAddText
            // 
            this.btnAddText.Enabled = false;
            this.btnAddText.Location = new System.Drawing.Point(140, 340);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(120, 35);
            this.btnAddText.TabIndex = 2;
            this.btnAddText.Text = "Добавить надпись";
            this.btnAddText.UseVisualStyleBackColor = true;
            this.btnAddText.Click += new System.EventHandler(this.BtnAddText_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(270, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnRemoveText
            // 
            this.btnRemoveText.Enabled = false;
            this.btnRemoveText.Location = new System.Drawing.Point(10, 380);
            this.btnRemoveText.Name = "btnRemoveText";
            this.btnRemoveText.Size = new System.Drawing.Size(380, 35);
            this.btnRemoveText.TabIndex = 4;
            this.btnRemoveText.Text = "Удалить надпись (вернуть оригинал)";
            this.btnRemoveText.UseVisualStyleBackColor = true;
            this.btnRemoveText.Click += new System.EventHandler(this.BtnRemoveText_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.Location = new System.Drawing.Point(10, 90);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(180, 30);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Цвет текста";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(10, 25);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(180, 20);
            this.txtText.TabIndex = 0;
            this.txtText.Text = "Моя надпись";
            // 
            // numFontSize
            // 
            this.numFontSize.Location = new System.Drawing.Point(120, 55);
            this.numFontSize.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numFontSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numFontSize.Name = "numFontSize";
            this.numFontSize.Size = new System.Drawing.Size(70, 20);
            this.numFontSize.TabIndex = 2;
            this.numFontSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // cmbFont
            // 
            this.cmbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFont.Items.AddRange(new object[] {
            "Arial",
            "Times New Roman",
            "Courier New",
            "Verdana",
            "Microsoft Sans Serif"});
            this.cmbFont.Location = new System.Drawing.Point(10, 55);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(100, 21);
            this.cmbFont.TabIndex = 1;
            // 
            // btnBatch
            // 
            this.btnBatch.Location = new System.Drawing.Point(10, 125);
            this.btnBatch.Name = "btnBatch";
            this.btnBatch.Size = new System.Drawing.Size(180, 35);
            this.btnBatch.TabIndex = 3;
            this.btnBatch.Text = "Обработать все";
            this.btnBatch.UseVisualStyleBackColor = true;
            this.btnBatch.Click += new System.EventHandler(this.BtnBatch_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(10, 25);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(180, 20);
            this.txtFolder.TabIndex = 0;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(10, 55);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(180, 30);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "Выбрать папку";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.BtnSelectFolder_Click);
            // 
            // chkSubfolders
            // 
            this.chkSubfolders.Location = new System.Drawing.Point(10, 95);
            this.chkSubfolders.Name = "chkSubfolders";
            this.chkSubfolders.Size = new System.Drawing.Size(150, 20);
            this.chkSubfolders.TabIndex = 2;
            this.chkSubfolders.Text = "Включая вложенные папки";
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Location = new System.Drawing.Point(-426, 163);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(628, 35);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Готов";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnSelectImage);
            this.groupBox1.Controls.Add(this.btnAddText);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnRemoveText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 430);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работа с изображением";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtText);
            this.groupBox2.Controls.Add(this.cmbFont);
            this.groupBox2.Controls.Add(this.numFontSize);
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Location = new System.Drawing.Point(440, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки надписи";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblStatus);
            this.groupBox3.Controls.Add(this.txtFolder);
            this.groupBox3.Controls.Add(this.btnSelectFolder);
            this.groupBox3.Controls.Add(this.chkSubfolders);
            this.groupBox3.Controls.Add(this.btnBatch);
            this.groupBox3.Location = new System.Drawing.Point(440, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 188);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пакетная обработка";
            // 
            // groupBoxPosition
            // 
            this.groupBoxPosition.Controls.Add(this.rbTopLeft);
            this.groupBoxPosition.Controls.Add(this.rbTopRight);
            this.groupBoxPosition.Controls.Add(this.rbCenter);
            this.groupBoxPosition.Controls.Add(this.rbBottomLeft);
            this.groupBoxPosition.Controls.Add(this.rbBottomRight);
            this.groupBoxPosition.Controls.Add(this.rbCustom);
            this.groupBoxPosition.Controls.Add(this.lblX);
            this.groupBoxPosition.Controls.Add(this.numX);
            this.groupBoxPosition.Controls.Add(this.lblY);
            this.groupBoxPosition.Controls.Add(this.numY);
            this.groupBoxPosition.Location = new System.Drawing.Point(440, 160);
            this.groupBoxPosition.Name = "groupBoxPosition";
            this.groupBoxPosition.Size = new System.Drawing.Size(224, 135);
            this.groupBoxPosition.TabIndex = 3;
            this.groupBoxPosition.TabStop = false;
            this.groupBoxPosition.Text = "Позиция текста";
            // 
            // rbTopLeft
            // 
            this.rbTopLeft.Location = new System.Drawing.Point(10, 25);
            this.rbTopLeft.Name = "rbTopLeft";
            this.rbTopLeft.Size = new System.Drawing.Size(90, 20);
            this.rbTopLeft.TabIndex = 0;
            this.rbTopLeft.Text = "Верхний левый";
            // 
            // rbCenter
            // 
            this.rbCenter.Checked = true;
            this.rbCenter.Location = new System.Drawing.Point(10, 50);
            this.rbCenter.Name = "rbCenter";
            this.rbCenter.Size = new System.Drawing.Size(90, 20);
            this.rbCenter.TabIndex = 2;
            this.rbCenter.TabStop = true;
            this.rbCenter.Text = "Центр";
            // 
            // rbBottomLeft
            // 
            this.rbBottomLeft.Location = new System.Drawing.Point(10, 75);
            this.rbBottomLeft.Name = "rbBottomLeft";
            this.rbBottomLeft.Size = new System.Drawing.Size(90, 20);
            this.rbBottomLeft.TabIndex = 3;
            this.rbBottomLeft.Text = "Нижний левый";
            // 
            // rbCustom
            // 
            this.rbCustom.Location = new System.Drawing.Point(10, 100);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(80, 20);
            this.rbCustom.TabIndex = 5;
            this.rbCustom.Text = "Произвольно:";
            this.rbCustom.CheckedChanged += new System.EventHandler(this.RbCustom_CheckedChanged);
            // 
            // lblX
            // 
            this.lblX.Location = new System.Drawing.Point(90, 103);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 20);
            this.lblX.TabIndex = 6;
            this.lblX.Text = "X:";
            // 
            // numX
            // 
            this.numX.Enabled = false;
            this.numX.Location = new System.Drawing.Point(110, 100);
            this.numX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(40, 20);
            this.numX.TabIndex = 7;
            this.numX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblY
            // 
            this.lblY.Location = new System.Drawing.Point(155, 103);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(20, 20);
            this.lblY.TabIndex = 8;
            this.lblY.Text = "Y:";
            // 
            // numY
            // 
            this.numY.Enabled = false;
            this.numY.Location = new System.Drawing.Point(175, 100);
            this.numY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(40, 20);
            this.numY.TabIndex = 9;
            this.numY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp|Все файлы|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PNG файл|*.png|JPEG файл|*.jpg";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Выберите папку с изображениями";
            // 
            // rbTopRight
            // 
            this.rbTopRight.Location = new System.Drawing.Point(100, 25);
            this.rbTopRight.Name = "rbTopRight";
            this.rbTopRight.Size = new System.Drawing.Size(90, 20);
            this.rbTopRight.TabIndex = 1;
            this.rbTopRight.Text = "Верхний правый";
            // 
            // rbBottomRight
            // 
            this.rbBottomRight.Location = new System.Drawing.Point(100, 75);
            this.rbBottomRight.Name = "rbBottomRight";
            this.rbBottomRight.Size = new System.Drawing.Size(90, 20);
            this.rbBottomRight.TabIndex = 4;
            this.rbBottomRight.Text = "Нижний правый";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 505);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxPosition);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление надписи на изображение";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxPosition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.RadioButton rbTopRight;
        private System.Windows.Forms.RadioButton rbBottomRight;
    }
}

