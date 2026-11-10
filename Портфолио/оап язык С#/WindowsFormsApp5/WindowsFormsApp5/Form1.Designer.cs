using System.Windows.Forms;

namespace Lab15_Variant1_WF
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Элементы управления
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.GroupBox grpControls;

        private System.Windows.Forms.DataGridView dgvInput;
        private System.Windows.Forms.DataGridView dgvResult;

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;

        private System.Windows.Forms.Label lblGroupNumber;
        private System.Windows.Forms.ComboBox cmbGroupNumber;

        private System.Windows.Forms.Label lblGrades;
        private System.Windows.Forms.TextBox txtGrade1;
        private System.Windows.Forms.TextBox txtGrade2;
        private System.Windows.Forms.TextBox txtGrade3;
        private System.Windows.Forms.TextBox txtGrade4;
        private System.Windows.Forms.TextBox txtGrade5;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Label lblStudentCounter;
        private System.Windows.Forms.Label lblMinAverage;
        private System.Windows.Forms.TextBox txtMinAverage;

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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.dgvInput = new System.Windows.Forms.DataGridView();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblGroupNumber = new System.Windows.Forms.Label();
            this.cmbGroupNumber = new System.Windows.Forms.ComboBox();
            this.lblGrades = new System.Windows.Forms.Label();
            this.txtGrade1 = new System.Windows.Forms.TextBox();
            this.txtGrade2 = new System.Windows.Forms.TextBox();
            this.txtGrade3 = new System.Windows.Forms.TextBox();
            this.txtGrade4 = new System.Windows.Forms.TextBox();
            this.txtGrade5 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStudentCounter = new System.Windows.Forms.Label();
            this.lblMinAverage = new System.Windows.Forms.Label();
            this.txtMinAverage = new System.Windows.Forms.TextBox();

            // grpInput
            this.grpInput.Text = "Исходные данные";
            this.grpInput.Location = new System.Drawing.Point(10, 10);
            this.grpInput.Size = new System.Drawing.Size(760, 200);

            // dgvInput
            this.dgvInput.Location = new System.Drawing.Point(15, 25);
            this.dgvInput.Size = new System.Drawing.Size(730, 160);
            this.dgvInput.ReadOnly = true;
            this.dgvInput.AllowUserToAddRows = false;
            this.dgvInput.RowHeadersVisible = false;
            this.grpInput.Controls.Add(this.dgvInput);

            // grpResult
            this.grpResult.Text = "Результаты";
            this.grpResult.Location = new System.Drawing.Point(10, 320);
            this.grpResult.Size = new System.Drawing.Size(760, 200);

            // dgvResult
            this.dgvResult.Location = new System.Drawing.Point(15, 25);
            this.dgvResult.Size = new System.Drawing.Size(730, 160);
            this.dgvResult.ReadOnly = true;
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.RowHeadersVisible = false;
            this.grpResult.Controls.Add(this.dgvResult);

            // grpControls
            this.grpControls.Text = "Управление";
            this.grpControls.Location = new System.Drawing.Point(10, 220);
            this.grpControls.Size = new System.Drawing.Size(760, 90);

            // lblFullName
            this.lblFullName.Text = "ФИО:";
            this.lblFullName.Location = new System.Drawing.Point(15, 25);
            this.lblFullName.Size = new System.Drawing.Size(40, 20);
            this.grpControls.Controls.Add(this.lblFullName);

            // txtFullName
            this.txtFullName.Location = new System.Drawing.Point(60, 22);
            this.txtFullName.Size = new System.Drawing.Size(150, 20);
            this.grpControls.Controls.Add(this.txtFullName);

            // lblGroupNumber
            this.lblGroupNumber.Text = "Группа:";
            this.lblGroupNumber.Location = new System.Drawing.Point(220, 25);
            this.lblGroupNumber.Size = new System.Drawing.Size(50, 20);
            this.grpControls.Controls.Add(this.lblGroupNumber);

            // cmbGroupNumber
            this.cmbGroupNumber.Location = new System.Drawing.Point(275, 22);
            this.cmbGroupNumber.Size = new System.Drawing.Size(60, 20);
            this.cmbGroupNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            this.grpControls.Controls.Add(this.cmbGroupNumber);

            // lblGrades
            this.lblGrades.Text = "Оценки:";
            this.lblGrades.Location = new System.Drawing.Point(345, 25);
            this.lblGrades.Size = new System.Drawing.Size(50, 20);
            this.grpControls.Controls.Add(this.lblGrades);

            // Оценки
            this.txtGrade1.Location = new System.Drawing.Point(400, 22);
            this.txtGrade1.Size = new System.Drawing.Size(35, 20);
            this.grpControls.Controls.Add(this.txtGrade1);

            this.txtGrade2.Location = new System.Drawing.Point(440, 22);
            this.txtGrade2.Size = new System.Drawing.Size(35, 20);
            this.grpControls.Controls.Add(this.txtGrade2);

            this.txtGrade3.Location = new System.Drawing.Point(480, 22);
            this.txtGrade3.Size = new System.Drawing.Size(35, 20);
            this.grpControls.Controls.Add(this.txtGrade3);

            this.txtGrade4.Location = new System.Drawing.Point(520, 22);
            this.txtGrade4.Size = new System.Drawing.Size(35, 20);
            this.grpControls.Controls.Add(this.txtGrade4);

            this.txtGrade5.Location = new System.Drawing.Point(560, 22);
            this.txtGrade5.Size = new System.Drawing.Size(35, 20);
            this.grpControls.Controls.Add(this.txtGrade5);

            // Кнопки
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Location = new System.Drawing.Point(610, 20);
            this.btnAdd.Size = new System.Drawing.Size(70, 23);
            this.grpControls.Controls.Add(this.btnAdd);

            this.btnPrev.Text = "<<";
            this.btnPrev.Location = new System.Drawing.Point(15, 55);
            this.btnPrev.Size = new System.Drawing.Size(40, 23);
            this.grpControls.Controls.Add(this.btnPrev);

            this.lblStudentCounter.Text = "Студент 1/10";
            this.lblStudentCounter.Location = new System.Drawing.Point(60, 58);
            this.lblStudentCounter.Size = new System.Drawing.Size(80, 20);
            this.grpControls.Controls.Add(this.lblStudentCounter);

            this.btnNext.Text = ">>";
            this.btnNext.Location = new System.Drawing.Point(145, 55);
            this.btnNext.Size = new System.Drawing.Size(40, 23);
            this.grpControls.Controls.Add(this.btnNext);

            this.lblMinAverage.Text = "Мин. балл:";
            this.lblMinAverage.Location = new System.Drawing.Point(220, 58);
            this.lblMinAverage.Size = new System.Drawing.Size(60, 20);
            this.grpControls.Controls.Add(this.lblMinAverage);

            this.txtMinAverage.Location = new System.Drawing.Point(285, 55);
            this.txtMinAverage.Size = new System.Drawing.Size(50, 20);
            this.txtMinAverage.Text = "4.0";
            this.grpControls.Controls.Add(this.txtMinAverage);

            this.btnProcess.Text = "Поиск";
            this.btnProcess.Location = new System.Drawing.Point(350, 55);
            this.btnProcess.Size = new System.Drawing.Size(70, 23);
            this.grpControls.Controls.Add(this.btnProcess);

            this.btnClear.Text = "Очистить";
            this.btnClear.Location = new System.Drawing.Point(430, 55);
            this.btnClear.Size = new System.Drawing.Size(70, 23);
            this.grpControls.Controls.Add(this.btnClear);

            this.btnExit.Text = "Выход";
            this.btnExit.Location = new System.Drawing.Point(510, 55);
            this.btnExit.Size = new System.Drawing.Size(70, 23);
            this.grpControls.Controls.Add(this.btnExit);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 531);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.grpResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа 15 - Студенты";
        }
    }
}
