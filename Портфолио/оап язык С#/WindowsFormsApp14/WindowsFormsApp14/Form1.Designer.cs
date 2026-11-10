namespace GeometryFiguresWinForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Основные элементы управления
        private System.Windows.Forms.Panel panelDrawing;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblFigureCount;
        private System.Windows.Forms.ComboBox cmbFigureType;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbDrawMode;
        private System.Windows.Forms.TextBox txtX1, txtY1, txtX2, txtY2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnShowNames;
        private System.Windows.Forms.Button btnCreateTest;
        private System.Windows.Forms.ListBox lstFigures;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.GroupBox groupBoxList;

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
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFigureCount = new System.Windows.Forms.Label();
            this.cmbFigureType = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbDrawMode = new System.Windows.Forms.ComboBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnShowNames = new System.Windows.Forms.Button();
            this.btnCreateTest = new System.Windows.Forms.Button();
            this.lstFigures = new System.Windows.Forms.ListBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblY1 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblY2 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.lblDrawMode = new System.Windows.Forms.Label();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDrawing
            // 
            this.panelDrawing.BackColor = System.Drawing.Color.White;
            this.panelDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDrawing.Location = new System.Drawing.Point(20, 20);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(560, 440);
            this.panelDrawing.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblStatus.Location = new System.Drawing.Point(20, 470);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(560, 30);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Готов к работе";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFigureCount
            // 
            this.lblFigureCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFigureCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblFigureCount.Location = new System.Drawing.Point(350, 0);
            this.lblFigureCount.Name = "lblFigureCount";
            this.lblFigureCount.Size = new System.Drawing.Size(80, 25);
            this.lblFigureCount.TabIndex = 0;
            this.lblFigureCount.Text = "0 / 7";
            this.lblFigureCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbFigureType
            // 
            this.cmbFigureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFigureType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFigureType.Items.AddRange(new object[] {
            "Прямоугольник",
            "Эллипс",
            "Линия"});
            this.cmbFigureType.Location = new System.Drawing.Point(110, 112);
            this.cmbFigureType.Name = "cmbFigureType";
            this.cmbFigureType.Size = new System.Drawing.Size(140, 23);
            this.cmbFigureType.TabIndex = 3;
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbColor.Items.AddRange(new object[] {
            "Красный",
            "Синий",
            "Зеленый",
            "Черный",
            "Фиолетовый",
            "Оранжевый",
            "Коричневый"});
            this.cmbColor.Location = new System.Drawing.Point(350, 112);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(80, 23);
            this.cmbColor.TabIndex = 4;
            // 
            // cmbDrawMode
            // 
            this.cmbDrawMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrawMode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDrawMode.Items.AddRange(new object[] {
            "Сплошная линия",
            "Пунктирная линия"});
            this.cmbDrawMode.Location = new System.Drawing.Point(120, 27);
            this.cmbDrawMode.Name = "cmbDrawMode";
            this.cmbDrawMode.Size = new System.Drawing.Size(140, 23);
            this.cmbDrawMode.TabIndex = 0;
            // 
            // txtX1
            // 
            this.txtX1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtX1.Location = new System.Drawing.Point(70, 32);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(70, 23);
            this.txtX1.TabIndex = 1;
            this.txtX1.Text = "50";
            this.txtX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtY1
            // 
            this.txtY1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtY1.Location = new System.Drawing.Point(210, 32);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(70, 23);
            this.txtY1.TabIndex = 3;
            this.txtY1.Text = "50";
            this.txtY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtX2
            // 
            this.txtX2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtX2.Location = new System.Drawing.Point(350, 32);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(70, 23);
            this.txtX2.TabIndex = 5;
            this.txtX2.Text = "150";
            this.txtX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtY2
            // 
            this.txtY2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtY2.Location = new System.Drawing.Point(70, 72);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(70, 23);
            this.txtY2.TabIndex = 7;
            this.txtY2.Text = "100";
            this.txtY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(400, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ДОБАВИТЬ ФИГУРУ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDraw.FlatAppearance.BorderSize = 0;
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDraw.ForeColor = System.Drawing.Color.White;
            this.btnDraw.Location = new System.Drawing.Point(20, 65);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(120, 35);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "НАРИСОВАТЬ";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // btnErase
            // 
            this.btnErase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnErase.FlatAppearance.BorderSize = 0;
            this.btnErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErase.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnErase.ForeColor = System.Drawing.Color.White;
            this.btnErase.Location = new System.Drawing.Point(150, 65);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(120, 35);
            this.btnErase.TabIndex = 2;
            this.btnErase.Text = "СТЕРЕТЬ";
            this.btnErase.UseVisualStyleBackColor = false;
            this.btnErase.Click += new System.EventHandler(this.BtnErase_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(280, 65);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(140, 35);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "ОЧИСТИТЬ ВСЁ";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // btnShowNames
            // 
            this.btnShowNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.btnShowNames.FlatAppearance.BorderSize = 0;
            this.btnShowNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowNames.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowNames.ForeColor = System.Drawing.Color.White;
            this.btnShowNames.Location = new System.Drawing.Point(20, 150);
            this.btnShowNames.Name = "btnShowNames";
            this.btnShowNames.Size = new System.Drawing.Size(190, 30);
            this.btnShowNames.TabIndex = 2;
            this.btnShowNames.Text = "ПОКАЗАТЬ ИМЕНА ФИГУР";
            this.btnShowNames.UseVisualStyleBackColor = false;
            this.btnShowNames.Click += new System.EventHandler(this.BtnShowNames_Click);
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnCreateTest.FlatAppearance.BorderSize = 0;
            this.btnCreateTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCreateTest.ForeColor = System.Drawing.Color.White;
            this.btnCreateTest.Location = new System.Drawing.Point(230, 150);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(210, 30);
            this.btnCreateTest.TabIndex = 3;
            this.btnCreateTest.Text = "ТЕСТОВЫЕ ДАННЫЕ (7 ФИГУР)";
            this.btnCreateTest.UseVisualStyleBackColor = false;
            this.btnCreateTest.Click += new System.EventHandler(this.BtnCreateTest_Click);
            // 
            // lstFigures
            // 
            this.lstFigures.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstFigures.FormattingEnabled = true;
            this.lstFigures.ItemHeight = 15;
            this.lstFigures.Location = new System.Drawing.Point(30, 28);
            this.lstFigures.Name = "lstFigures";
            this.lstFigures.Size = new System.Drawing.Size(400, 109);
            this.lstFigures.TabIndex = 1;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.lblX1);
            this.groupBoxInput.Controls.Add(this.txtX1);
            this.groupBoxInput.Controls.Add(this.lblY1);
            this.groupBoxInput.Controls.Add(this.txtY1);
            this.groupBoxInput.Controls.Add(this.lblX2);
            this.groupBoxInput.Controls.Add(this.txtX2);
            this.groupBoxInput.Controls.Add(this.lblY2);
            this.groupBoxInput.Controls.Add(this.txtY2);
            this.groupBoxInput.Controls.Add(this.lblType);
            this.groupBoxInput.Controls.Add(this.cmbFigureType);
            this.groupBoxInput.Controls.Add(this.lblColor);
            this.groupBoxInput.Controls.Add(this.cmbColor);
            this.groupBoxInput.Controls.Add(this.btnAdd);
            this.groupBoxInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.groupBoxInput.Location = new System.Drawing.Point(600, 20);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(440, 220);
            this.groupBoxInput.TabIndex = 2;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "ДОБАВЛЕНИЕ ФИГУРЫ";
            // 
            // lblX1
            // 
            this.lblX1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblX1.Location = new System.Drawing.Point(20, 35);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(40, 25);
            this.lblX1.TabIndex = 0;
            this.lblX1.Text = "X1:";
            // 
            // lblY1
            // 
            this.lblY1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblY1.Location = new System.Drawing.Point(160, 35);
            this.lblY1.Name = "lblY1";
            this.lblY1.Size = new System.Drawing.Size(40, 25);
            this.lblY1.TabIndex = 2;
            this.lblY1.Text = "Y1:";
            // 
            // lblX2
            // 
            this.lblX2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblX2.Location = new System.Drawing.Point(300, 35);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(40, 25);
            this.lblX2.TabIndex = 4;
            this.lblX2.Text = "X2:";
            // 
            // lblY2
            // 
            this.lblY2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblY2.Location = new System.Drawing.Point(20, 75);
            this.lblY2.Name = "lblY2";
            this.lblY2.Size = new System.Drawing.Size(40, 25);
            this.lblY2.TabIndex = 6;
            this.lblY2.Text = "Y2:";
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblType.Location = new System.Drawing.Point(20, 115);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(80, 25);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Тип фигуры:";
            // 
            // lblColor
            // 
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblColor.Location = new System.Drawing.Point(270, 115);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(80, 25);
            this.lblColor.TabIndex = 9;
            this.lblColor.Text = "Цвет:";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.lblDrawMode);
            this.groupBoxActions.Controls.Add(this.cmbDrawMode);
            this.groupBoxActions.Controls.Add(this.btnDraw);
            this.groupBoxActions.Controls.Add(this.btnErase);
            this.groupBoxActions.Controls.Add(this.btnClearAll);
            this.groupBoxActions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.groupBoxActions.Location = new System.Drawing.Point(600, 260);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(440, 120);
            this.groupBoxActions.TabIndex = 3;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "УПРАВЛЕНИЕ ФИГУРАМИ";
            // 
            // lblDrawMode
            // 
            this.lblDrawMode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDrawMode.Location = new System.Drawing.Point(20, 30);
            this.lblDrawMode.Name = "lblDrawMode";
            this.lblDrawMode.Size = new System.Drawing.Size(100, 25);
            this.lblDrawMode.TabIndex = 0;
            this.lblDrawMode.Text = "Режим:";
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.lblFigureCount);
            this.groupBoxList.Controls.Add(this.lstFigures);
            this.groupBoxList.Controls.Add(this.btnShowNames);
            this.groupBoxList.Controls.Add(this.btnCreateTest);
            this.groupBoxList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.groupBoxList.Location = new System.Drawing.Point(600, 400);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(464, 212);
            this.groupBoxList.TabIndex = 4;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "СПИСОК ФИГУР";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1179, 672);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panelDrawing);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Геометрические фигуры - Практическое занятие 18";
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label lblY1;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblY2;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblDrawMode;
    }
}