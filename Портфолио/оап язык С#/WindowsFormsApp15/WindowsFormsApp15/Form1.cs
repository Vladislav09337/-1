using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TextProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Меню: Открыть
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDlg.FileName, Encoding.Default);
                richTextBox1.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            OpenDlg.Dispose();
        }

        // Меню: Сохранить
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    Writer.WriteLine((string)listBox2.Items[i]);
                }
                Writer.Close();
            }
            SaveDlg.Dispose();
        }

        // Меню: Выход
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Меню: О программе
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Информация о приложении и разработчике");
        }

        // Кнопка "Начать"
        private void buttonStart_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.BeginUpdate();

            string[] Strings = richTextBox1.Text.Split(new char[] { '\n', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in Strings)
            {
                string Str = s.Trim();
                if (Str == String.Empty) continue;

                if (radioButton1.Checked)
                    listBox1.Items.Add(Str);

                if (radioButton2.Checked)
                {
                    if (Regex.IsMatch(Str, @"\d"))
                        listBox1.Items.Add(Str);
                }

                if (radioButton3.Checked)
                {
                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w+"))
                        listBox1.Items.Add(Str);
                }
            }

            listBox1.EndUpdate();
        }

        // Кнопка "Сброс"
        private void buttonReset_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.Clear();
            radioButton1.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        // Кнопка "Поиск"
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            string Find = textBox1.Text;

            if (checkBox1.Checked)
            {
                foreach (string String in listBox1.Items)
                {
                    if (String.Contains(Find))
                        listBox3.Items.Add(String);
                }
            }

            if (checkBox2.Checked)
            {
                foreach (string String in listBox2.Items)
                {
                    if (String.Contains(Find))
                        listBox3.Items.Add(String);
                }
            }
        }

        // Кнопка "Добавить" (открывает Form2)
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 AddRec = new Form2();
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }

        // Кнопка "Удалить"
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedStrings(listBox1);
            DeleteSelectedStrings(listBox2);
        }

        private void DeleteSelectedStrings(ListBox ListBox)
        {
            for (int i = ListBox.Items.Count - 1; i >= 0; i--)
            {
                if (ListBox.GetSelected(i))
                    ListBox.Items.RemoveAt(i);
            }
        }

        // Кнопки переноса строк
        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            listBox2.BeginUpdate();
            foreach (object Item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(Item);
            }
            foreach (object Item in listBox1.SelectedItems)
            {
                listBox1.Items.Remove(Item);
            }
            listBox2.EndUpdate();
        }

        private void buttonMoveAllRight_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            foreach (object Item in listBox2.SelectedItems)
            {
                listBox1.Items.Add(Item);
            }
            foreach (object Item in listBox2.SelectedItems)
            {
                listBox2.Items.Remove(Item);
            }
            listBox1.EndUpdate();
        }

        private void buttonMoveAllLeft_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        // Сортировка
        private void comboBoxSort1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortListBox(listBox1, comboBoxSort1.SelectedIndex);
        }

        private void comboBoxSort2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortListBox(listBox2, comboBoxSort2.SelectedIndex);
        }

        private void SortListBox(ListBox lb, int sortType)
        {
            if (lb.Items.Count == 0) return;

            string[] items = new string[lb.Items.Count];
            lb.Items.CopyTo(items, 0);

            for (int i = 0; i < items.Length - 1; i++)
            {
                for (int j = i + 1; j < items.Length; j++)
                {
                    bool needSwap = false;
                    if (sortType == 0 && string.Compare(items[i], items[j]) > 0) needSwap = true;
                    else if (sortType == 1 && string.Compare(items[i], items[j]) < 0) needSwap = true;
                    else if (sortType == 2 && items[i].Length > items[j].Length) needSwap = true;
                    else if (sortType == 3 && items[i].Length < items[j].Length) needSwap = true;

                    if (needSwap)
                    {
                        string temp = items[i];
                        items[i] = items[j];
                        items[j] = temp;
                    }
                }
            }

            lb.Items.Clear();
            lb.Items.AddRange(items);
        }
    }
}