using System.Windows.Forms;

namespace WindowsFormsApp9
{
    partial class Form1
    {
        // Элементы
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.TextBox txtGrade1;
        private System.Windows.Forms.TextBox txtGrade2;
        private System.Windows.Forms.TextBox txtGrade3;
        private System.Windows.Forms.TextBox txtGrade4;
        private System.Windows.Forms.TextBox txtGrade5;
        private System.Windows.Forms.TextBox txtMinBall;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.DataGridView dgvAll;
        private System.Windows.Forms.DataGridView dgvFound;

        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblGrades;
        private System.Windows.Forms.Label lblMinBall;

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.txtGrade1 = new System.Windows.Forms.TextBox();
            this.txtGrade2 = new System.Windows.Forms.TextBox();
            this.txtGrade3 = new System.Windows.Forms.TextBox();
            this.txtGrade4 = new System.Windows.Forms.TextBox();
            this.txtGrade5 = new System.Windows.Forms.TextBox();
            this.txtMinBall = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvAll = new System.Windows.Forms.DataGridView();
            this.dgvFound = new System.Windows.Forms.DataGridView();
            this.lblCounter = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblGrades = new System.Windows.Forms.Label();
            this.lblMinBall = new System.Windows.Forms.Label();

            // Form1
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Text = "Студенты";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Поля ввода
            // ФИО
            this.lblName.Text = "ФИО:";
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Size = new System.Drawing.Size(40, 20);

            this.txtName.Location = new System.Drawing.Point(70, 17);
            this.txtName.Size = new System.Drawing.Size(200, 20);

            // Группа
            this.lblGroup.Text = "Группа:";
            this.lblGroup.Location = new System.Drawing.Point(290, 20);
            this.lblGroup.Size = new System.Drawing.Size(50, 20);

            this.cmbGroup.Location = new System.Drawing.Point(350, 17);
            this.cmbGroup.Size = new System.Drawing.Size(60, 20);
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Оценки
            this.lblGrades.Text = "Оценки:";
            this.lblGrades.Location = new System.Drawing.Point(20, 60);
            this.lblGrades.Size = new System.Drawing.Size(50, 20);

            this.txtGrade1.Location = new System.Drawing.Point(80, 57);
            this.txtGrade1.Size = new System.Drawing.Size(35, 20);

            this.txtGrade2.Location = new System.Drawing.Point(120, 57);
            this.txtGrade2.Size = new System.Drawing.Size(35, 20);

            this.txtGrade3.Location = new System.Drawing.Point(160, 57);
            this.txtGrade3.Size = new System.Drawing.Size(35, 20);

            this.txtGrade4.Location = new System.Drawing.Point(200, 57);
            this.txtGrade4.Size = new System.Drawing.Size(35, 20);

            this.txtGrade5.Location = new System.Drawing.Point(240, 57);
            this.txtGrade5.Size = new System.Drawing.Size(35, 20);

            // Кнопка Добавить
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Location = new System.Drawing.Point(300, 55);
            this.btnAdd.Size = new System.Drawing.Size(100, 25);

            // Счетчик
            this.lblCounter.Text = "0/10";
            this.lblCounter.Location = new System.Drawing.Point(420, 58);
            this.lblCounter.Size = new System.Drawing.Size(50, 20);

            // Таблица всех студентов
            this.dgvAll.Location = new System.Drawing.Point(20, 100);
            this.dgvAll.Size = new System.Drawing.Size(750, 200);
            this.dgvAll.ReadOnly = true;
            this.dgvAll.AllowUserToAddRows = false;
            this.dgvAll.RowHeadersVisible = false;

            // Поиск
            this.lblMinBall.Text = "Мин. балл:";
            this.lblMinBall.Location = new System.Drawing.Point(20, 320);
            this.lblMinBall.Size = new System.Drawing.Size(60, 20);

            this.txtMinBall.Location = new System.Drawing.Point(90, 317);
            this.txtMinBall.Size = new System.Drawing.Size(50, 20);
            this.txtMinBall.Text = "4.0";

            this.btnFind.Text = "Найти";
            this.btnFind.Location = new System.Drawing.Point(160, 315);
            this.btnFind.Size = new System.Drawing.Size(80, 25);

            this.btnClear.Text = "Очистить";
            this.btnClear.Location = new System.Drawing.Point(250, 315);
            this.btnClear.Size = new System.Drawing.Size(80, 25);

            // Таблица результатов
            this.dgvFound.Location = new System.Drawing.Point(20, 360);
            this.dgvFound.Size = new System.Drawing.Size(750, 180);
            this.dgvFound.ReadOnly = true;
            this.dgvFound.AllowUserToAddRows = false;
            this.dgvFound.RowHeadersVisible = false;

            // Кнопка Выход
            this.btnExit.Text = "Выход";
            this.btnExit.Location = new System.Drawing.Point(680, 550);
            this.btnExit.Size = new System.Drawing.Size(90, 25);

            // Добавляем всё на форму
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.lblGrades);
            this.Controls.Add(this.txtGrade1);
            this.Controls.Add(this.txtGrade2);
            this.Controls.Add(this.txtGrade3);
            this.Controls.Add(this.txtGrade4);
            this.Controls.Add(this.txtGrade5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.dgvAll);
            this.Controls.Add(this.lblMinBall);
            this.Controls.Add(this.txtMinBall);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvFound);
            this.Controls.Add(this.btnExit);
        }
    }
}

