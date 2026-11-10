namespace SolarSystemReference
{
    partial class Form1
    {
        // объявление компонентов формы
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lbObjects;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblFilter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // инициализация всех элементов управления
        private void InitializeComponent()
        {
            this.lbObjects = new System.Windows.Forms.ListBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbObjects
            // 
            this.lbObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbObjects.FormattingEnabled = true;
            this.lbObjects.ItemHeight = 16;
            this.lbObjects.Location = new System.Drawing.Point(12, 50);
            this.lbObjects.Name = "lbObjects";
            this.lbObjects.Size = new System.Drawing.Size(250, 404);
            this.lbObjects.TabIndex = 0;
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtInfo.Location = new System.Drawing.Point(270, 50);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(350, 250);
            this.txtInfo.TabIndex = 1;
            // 
            // pbPhoto
            // 
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPhoto.Location = new System.Drawing.Point(270, 310);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(150, 140);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 2;
            this.pbPhoto.TabStop = false;
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(426, 310);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(190, 35);
            this.btnShowInfo.TabIndex = 3;
            this.btnShowInfo.Text = "показать информацию";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.Items.AddRange(new object[] {
            "все объекты",
            "звезды",
            "планеты",
            "спутники"});
            this.cbFilter.Location = new System.Drawing.Point(96, 15);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(150, 21);
            this.cbFilter.TabIndex = 4;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(12, 18);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(78, 13);
            this.lblFilter.TabIndex = 5;
            this.lblFilter.Text = "тип объектов:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(632, 473);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.lbObjects);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "справочник солнечной системы";
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

