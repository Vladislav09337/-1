using System.Windows.Forms;

namespace TextProcessor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // RichTextBox
            this.richTextBox1 = new RichTextBox();
            this.richTextBox1.Location = new System.Drawing.Point(12, 30);
            this.richTextBox1.Size = new System.Drawing.Size(280, 120);
            this.richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // GroupBox с RadioButton
            this.groupBox1 = new GroupBox();
            this.groupBox1.Text = "Выбор слов";
            this.groupBox1.Location = new System.Drawing.Point(12, 160);
            this.groupBox1.Size = new System.Drawing.Size(280, 100);

            this.radioButton1 = new RadioButton();
            this.radioButton1.Text = "Все";
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 20);
            this.radioButton1.Size = new System.Drawing.Size(120, 20);

            this.radioButton2 = new RadioButton();
            this.radioButton2.Text = "Содержащие цифры";
            this.radioButton2.Location = new System.Drawing.Point(10, 45);
            this.radioButton2.Size = new System.Drawing.Size(150, 20);

            this.radioButton3 = new RadioButton();
            this.radioButton3.Text = "Содержащие 'e-mail'";
            this.radioButton3.Location = new System.Drawing.Point(10, 70);
            this.radioButton3.Size = new System.Drawing.Size(150, 20);

            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);

            // Кнопка Начать
            this.buttonStart = new Button();
            this.buttonStart.Text = "Начать";
            this.buttonStart.Location = new System.Drawing.Point(12, 270);
            this.buttonStart.Size = new System.Drawing.Size(90, 30);

            // Кнопка Сброс
            this.buttonReset = new Button();
            this.buttonReset.Text = "Сброс";
            this.buttonReset.Location = new System.Drawing.Point(110, 270);
            this.buttonReset.Size = new System.Drawing.Size(90, 30);

            // ListBox Раздел 1
            this.listBox1 = new ListBox();
            this.listBox1.Location = new System.Drawing.Point(310, 30);
            this.listBox1.Size = new System.Drawing.Size(180, 180);
            this.listBox1.SelectionMode = SelectionMode.MultiExtended;

            // ComboBox сортировки Раздел 1
            this.comboBoxSort1 = new ComboBox();
            this.comboBoxSort1.Location = new System.Drawing.Point(310, 220);
            this.comboBoxSort1.Size = new System.Drawing.Size(180, 25);
            this.comboBoxSort1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxSort1.Items.Add("Алфавиту (по возрастанию)");
            this.comboBoxSort1.Items.Add("Алфавиту (по убыванию)");
            this.comboBoxSort1.Items.Add("Длине слова (по возрастанию)");
            this.comboBoxSort1.Items.Add("Длине слова (по убыванию)");
            this.comboBoxSort1.SelectedIndex = 0;

            // Panel с кнопками
            this.panel1 = new Panel();
            this.panel1.BorderStyle = BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(500, 30);
            this.panel1.Size = new System.Drawing.Size(90, 220);

            this.buttonMoveRight = new Button();
            this.buttonMoveRight.Text = ">";
            this.buttonMoveRight.Location = new System.Drawing.Point(10, 20);
            this.buttonMoveRight.Size = new System.Drawing.Size(65, 30);

            this.buttonMoveAllRight = new Button();
            this.buttonMoveAllRight.Text = ">>";
            this.buttonMoveAllRight.Location = new System.Drawing.Point(10, 60);
            this.buttonMoveAllRight.Size = new System.Drawing.Size(65, 30);

            this.buttonMoveLeft = new Button();
            this.buttonMoveLeft.Text = "<";
            this.buttonMoveLeft.Location = new System.Drawing.Point(10, 100);
            this.buttonMoveLeft.Size = new System.Drawing.Size(65, 30);

            this.buttonMoveAllLeft = new Button();
            this.buttonMoveAllLeft.Text = "<<";
            this.buttonMoveAllLeft.Location = new System.Drawing.Point(10, 140);
            this.buttonMoveAllLeft.Size = new System.Drawing.Size(65, 30);

            this.buttonAdd = new Button();
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.Location = new System.Drawing.Point(10, 180);
            this.buttonAdd.Size = new System.Drawing.Size(65, 30);

            this.panel1.Controls.Add(this.buttonMoveRight);
            this.panel1.Controls.Add(this.buttonMoveAllRight);
            this.panel1.Controls.Add(this.buttonMoveLeft);
            this.panel1.Controls.Add(this.buttonMoveAllLeft);
            this.panel1.Controls.Add(this.buttonAdd);

            // ListBox Раздел 2
            this.listBox2 = new ListBox();
            this.listBox2.Location = new System.Drawing.Point(600, 30);
            this.listBox2.Size = new System.Drawing.Size(180, 180);
            this.listBox2.SelectionMode = SelectionMode.MultiExtended;

            // Кнопка Удалить (справа от Раздела 2)
            this.buttonDelete = new Button();
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.Location = new System.Drawing.Point(600, 220);
            this.buttonDelete.Size = new System.Drawing.Size(180, 25);

            // ComboBox сортировки Раздел 2
            this.comboBoxSort2 = new ComboBox();
            this.comboBoxSort2.Location = new System.Drawing.Point(600, 250);
            this.comboBoxSort2.Size = new System.Drawing.Size(180, 25);
            this.comboBoxSort2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxSort2.Items.Add("Алфавиту (по возрастанию)");
            this.comboBoxSort2.Items.Add("Алфавиту (по убыванию)");
            this.comboBoxSort2.Items.Add("Длине слова (по возрастанию)");
            this.comboBoxSort2.Items.Add("Длине слова (по убыванию)");
            this.comboBoxSort2.SelectedIndex = 0;

            // ========== БЛОК ПОИСКА (нижний правый угол) ==========
            // Label
            this.label1 = new Label();
            this.label1.Text = "Введите искомое слово";
            this.label1.Location = new System.Drawing.Point(310, 270);
            this.label1.Size = new System.Drawing.Size(150, 20);

            // TextBox поиска
            this.textBox1 = new TextBox();
            this.textBox1.Location = new System.Drawing.Point(310, 295);
            this.textBox1.Size = new System.Drawing.Size(200, 25);

            // CheckBox Раздел 1
            this.checkBox1 = new CheckBox();
            this.checkBox1.Text = "Раздел 1";
            this.checkBox1.Location = new System.Drawing.Point(310, 330);
            this.checkBox1.Size = new System.Drawing.Size(80, 20);

            // CheckBox Раздел 2
            this.checkBox2 = new CheckBox();
            this.checkBox2.Text = "Раздел 2";
            this.checkBox2.Location = new System.Drawing.Point(400, 330);
            this.checkBox2.Size = new System.Drawing.Size(80, 20);

            // Кнопка Поиск
            this.buttonSearch = new Button();
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.Location = new System.Drawing.Point(500, 325);
            this.buttonSearch.Size = new System.Drawing.Size(80, 30);

            // ListBox результатов поиска
            this.listBox3 = new ListBox();
            this.listBox3.Location = new System.Drawing.Point(310, 365);
            this.listBox3.Size = new System.Drawing.Size(470, 120);

            // ========== MENU ==========
            this.menuStrip1 = new MenuStrip();
            this.fileToolStripMenuItem = new ToolStripMenuItem();
            this.openToolStripMenuItem = new ToolStripMenuItem();
            this.saveToolStripMenuItem = new ToolStripMenuItem();
            this.exitToolStripMenuItem = new ToolStripMenuItem();
            this.helpToolStripMenuItem = new ToolStripMenuItem();
            this.aboutToolStripMenuItem = new ToolStripMenuItem();

            this.menuStrip1.Items.Add(this.fileToolStripMenuItem);
            this.menuStrip1.Items.Add(this.helpToolStripMenuItem);
            this.fileToolStripMenuItem.DropDownItems.Add(this.openToolStripMenuItem);
            this.fileToolStripMenuItem.DropDownItems.Add(this.saveToolStripMenuItem);
            this.fileToolStripMenuItem.DropDownItems.Add(this.exitToolStripMenuItem);
            this.helpToolStripMenuItem.DropDownItems.Add(this.aboutToolStripMenuItem);

            this.fileToolStripMenuItem.Text = "Файл";
            this.helpToolStripMenuItem.Text = "Справка";
            this.openToolStripMenuItem.Text = "Открыть";
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.exitToolStripMenuItem.Text = "Выход";
            this.aboutToolStripMenuItem.Text = "О программе";

            // Горячие клавиши
            this.openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            this.saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            this.exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.X;

            // Добавление всех контролов
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBoxSort1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.comboBoxSort2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.menuStrip1);

            // Настройки формы
            this.Text = "Текстовый процессор";
            this.Size = new System.Drawing.Size(810, 540);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Объявление компонентов
        private RichTextBox richTextBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button buttonStart;
        private Button buttonReset;
        public ListBox listBox1;
        public ListBox listBox2;
        private ListBox listBox3;
        private ComboBox comboBoxSort1;
        private ComboBox comboBoxSort2;
        private Panel panel1;
        private Button buttonMoveRight;
        private Button buttonMoveAllRight;
        private Button buttonMoveLeft;
        private Button buttonMoveAllLeft;
        private Button buttonAdd;
        private Button buttonDelete;
        private Label label1;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button buttonSearch;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}