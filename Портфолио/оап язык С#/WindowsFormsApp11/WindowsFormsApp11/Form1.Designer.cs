namespace SolarSystemGuide
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxSun;
        private System.Windows.Forms.Label lblSunName;
        private System.Windows.Forms.Label lblSunInfo;
        private System.Windows.Forms.GroupBox groupBoxPlanets;
        private System.Windows.Forms.DataGridView dgvPlanets;
        private System.Windows.Forms.Button btnPlanetInfo;
        private System.Windows.Forms.GroupBox groupBoxMoons;
        private System.Windows.Forms.DataGridView dgvMoons;
        private System.Windows.Forms.Button btnMoonInfo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;

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
            this.groupBoxSun = new System.Windows.Forms.GroupBox();
            this.lblSunName = new System.Windows.Forms.Label();
            this.lblSunInfo = new System.Windows.Forms.Label();
            this.groupBoxPlanets = new System.Windows.Forms.GroupBox();
            this.dgvPlanets = new System.Windows.Forms.DataGridView();
            this.btnPlanetInfo = new System.Windows.Forms.Button();
            this.groupBoxMoons = new System.Windows.Forms.GroupBox();
            this.dgvMoons = new System.Windows.Forms.DataGridView();
            this.btnMoonInfo = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxSun.SuspendLayout();
            this.groupBoxPlanets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanets)).BeginInit();
            this.groupBoxMoons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoons)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // Форма
            this.Text = "Справочник Солнечной системы";
            this.Size = new System.Drawing.Size(1100, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(10, 10, 28);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Заголовок
            this.lblTitle.Text = "СПРАВОЧНИК СОЛНЕЧНОЙ СИСТЕМЫ";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(0, 0, 40);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Height = 60;

            // Блок Солнца
            this.groupBoxSun.Text = "СОЛНЦЕ";
            this.groupBoxSun.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
            this.groupBoxSun.ForeColor = System.Drawing.Color.Orange;
            this.groupBoxSun.BackColor = System.Drawing.Color.FromArgb(20, 20, 45);
            this.groupBoxSun.Size = new System.Drawing.Size(1040, 100);
            this.groupBoxSun.Location = new System.Drawing.Point(30, 70);
            this.groupBoxSun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.lblSunName.Text = "СОЛНЦЕ";
            this.lblSunName.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.lblSunName.ForeColor = System.Drawing.Color.Gold;
            this.lblSunName.Location = new System.Drawing.Point(20, 20);
            this.lblSunName.Size = new System.Drawing.Size(150, 30);

            this.lblSunInfo.Font = new System.Drawing.Font("Segoe UI", 10);
            this.lblSunInfo.ForeColor = System.Drawing.Color.White;
            this.lblSunInfo.Location = new System.Drawing.Point(20, 50);
            this.lblSunInfo.Size = new System.Drawing.Size(1000, 40);

            this.groupBoxSun.Controls.Add(this.lblSunName);
            this.groupBoxSun.Controls.Add(this.lblSunInfo);

            // Блок Планет
            this.groupBoxPlanets.Text = "ПЛАНЕТЫ";
            this.groupBoxPlanets.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
            this.groupBoxPlanets.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBoxPlanets.BackColor = System.Drawing.Color.FromArgb(20, 20, 45);
            this.groupBoxPlanets.Size = new System.Drawing.Size(650, 380);
            this.groupBoxPlanets.Location = new System.Drawing.Point(30, 180);
            this.groupBoxPlanets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.dgvPlanets.Size = new System.Drawing.Size(630, 300);
            this.dgvPlanets.Location = new System.Drawing.Point(10, 25);
            this.dgvPlanets.BackgroundColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.dgvPlanets.ForeColor = System.Drawing.Color.White;
            this.dgvPlanets.GridColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.dgvPlanets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlanets.EnableHeadersVisualStyles = false;
            this.dgvPlanets.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.dgvPlanets.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPlanets.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 35, 55);
            this.dgvPlanets.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 65);
            this.dgvPlanets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanets.RowHeadersVisible = false;

            this.btnPlanetInfo.Text = "Показать информацию";
            this.btnPlanetInfo.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnPlanetInfo.BackColor = System.Drawing.Color.FromArgb(70, 130, 200);
            this.btnPlanetInfo.ForeColor = System.Drawing.Color.White;
            this.btnPlanetInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanetInfo.Size = new System.Drawing.Size(200, 35);
            this.btnPlanetInfo.Location = new System.Drawing.Point(225, 335);
            this.btnPlanetInfo.Click += new System.EventHandler(this.BtnPlanetInfo_Click);

            this.groupBoxPlanets.Controls.Add(this.dgvPlanets);
            this.groupBoxPlanets.Controls.Add(this.btnPlanetInfo);

            // Блок Спутников
            this.groupBoxMoons.Text = "СПУТНИКИ";
            this.groupBoxMoons.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
            this.groupBoxMoons.ForeColor = System.Drawing.Color.LightPink;
            this.groupBoxMoons.BackColor = System.Drawing.Color.FromArgb(20, 20, 45);
            this.groupBoxMoons.Size = new System.Drawing.Size(390, 380);
            this.groupBoxMoons.Location = new System.Drawing.Point(690, 180);
            this.groupBoxMoons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.dgvMoons.Size = new System.Drawing.Size(370, 300);
            this.dgvMoons.Location = new System.Drawing.Point(10, 25);
            this.dgvMoons.BackgroundColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.dgvMoons.ForeColor = System.Drawing.Color.White;
            this.dgvMoons.GridColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.dgvMoons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMoons.EnableHeadersVisualStyles = false;
            this.dgvMoons.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.dgvMoons.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMoons.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 35, 55);
            this.dgvMoons.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 65);
            this.dgvMoons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMoons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMoons.RowHeadersVisible = false;

            this.btnMoonInfo.Text = "Показать информацию";
            this.btnMoonInfo.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnMoonInfo.BackColor = System.Drawing.Color.FromArgb(150, 100, 200);
            this.btnMoonInfo.ForeColor = System.Drawing.Color.White;
            this.btnMoonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoonInfo.Size = new System.Drawing.Size(200, 35);
            this.btnMoonInfo.Location = new System.Drawing.Point(95, 335);
            this.btnMoonInfo.Click += new System.EventHandler(this.BtnMoonInfo_Click);

            this.groupBoxMoons.Controls.Add(this.dgvMoons);
            this.groupBoxMoons.Controls.Add(this.btnMoonInfo);

            // Статусная строка
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.lblStatus.Text = "Готов к работе";
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.statusStrip.Items.Add(this.lblStatus);

            // Добавляем на форму
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBoxSun);
            this.Controls.Add(this.groupBoxPlanets);
            this.Controls.Add(this.groupBoxMoons);
            this.Controls.Add(this.statusStrip);

            this.groupBoxSun.ResumeLayout(false);
            this.groupBoxPlanets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanets)).EndInit();
            this.groupBoxMoons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoons)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}