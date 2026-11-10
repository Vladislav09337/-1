// Forms/MainForm.Designer.cs
using System.Drawing;
using System.Windows.Forms;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private ComboBox cmbFigures;
    private Label lblFigureType;
    private Label lblX1, lblY1, lblX2, lblY2;
    private TextBox txtX1, txtY1, txtX2, txtY2;
    private Button btnDrawSolid, btnDrawDashed, btnErase;
    private Panel drawingPanel;
    private Label lblInfo;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.cmbFigures = new ComboBox();
        this.lblFigureType = new Label();
        this.lblX1 = new Label(); this.lblY1 = new Label();
        this.lblX2 = new Label(); this.lblY2 = new Label();
        this.txtX1 = new TextBox(); this.txtY1 = new TextBox();
        this.txtX2 = new TextBox(); this.txtY2 = new TextBox();
        this.btnDrawSolid = new Button(); this.btnDrawDashed = new Button();
        this.btnErase = new Button();
        this.drawingPanel = new Panel();
        this.lblInfo = new Label();
        this.SuspendLayout();

        // cmbFigures
        this.cmbFigures.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cmbFigures.Items.AddRange(new object[] { "Прямоугольник", "Эллипс", "Линия" });
        this.cmbFigures.SelectedIndex = 0;
        this.cmbFigures.Location = new Point(20, 30);
        this.cmbFigures.Size = new Size(150, 25);

        // Labels and TextBoxes с подписями
        // X1
        this.lblX1.Text = "X1:";
        this.lblX1.Location = new Point(20, 70);
        this.lblX1.Size = new Size(30, 23);

        this.txtX1.Location = new Point(50, 67);
        this.txtX1.Size = new Size(60, 23);
        this.txtX1.Text = "100";

        // Y1
        this.lblY1.Text = "Y1:";
        this.lblY1.Location = new Point(120, 70);
        this.lblY1.Size = new Size(30, 23);

        this.txtY1.Location = new Point(150, 67);
        this.txtY1.Size = new Size(60, 23);
        this.txtY1.Text = "100";

        // X2
        this.lblX2.Text = "X2:";
        this.lblX2.Location = new Point(220, 70);
        this.lblX2.Size = new Size(30, 23);

        this.txtX2.Location = new Point(250, 67);
        this.txtX2.Size = new Size(60, 23);
        this.txtX2.Text = "250";

        // Y2
        this.lblY2.Text = "Y2:";
        this.lblY2.Location = new Point(320, 70);
        this.lblY2.Size = new Size(30, 23);

        this.txtY2.Location = new Point(350, 67);
        this.txtY2.Size = new Size(60, 23);
        this.txtY2.Text = "200";

        // Buttons
        this.btnDrawSolid.Text = "Сплошная линия";
        this.btnDrawSolid.Location = new Point(20, 110);
        this.btnDrawSolid.Size = new Size(130, 35);
        this.btnDrawSolid.BackColor = Color.LightGreen;

        this.btnDrawDashed.Text = "Пунктирная линия";
        this.btnDrawDashed.Location = new Point(160, 110);
        this.btnDrawDashed.Size = new Size(130, 35);
        this.btnDrawDashed.BackColor = Color.LightYellow;

        this.btnErase.Text = "Стереть";
        this.btnErase.Location = new Point(300, 110);
        this.btnErase.Size = new Size(100, 35);
        this.btnErase.BackColor = Color.LightCoral;

        // Информационная метка
        this.lblInfo.Text = "Координаты относительно панели рисования (0,0 - левый верхний угол панели)";
        this.lblInfo.Location = new Point(20, 155);
        this.lblInfo.Size = new Size(500, 20);
        this.lblInfo.ForeColor = Color.Blue;
        this.lblInfo.Font = new Font("Arial", 8, FontStyle.Italic);

        // drawingPanel
        this.drawingPanel.Location = new Point(20, 180);
        this.drawingPanel.Size = new Size(650, 380);
        this.drawingPanel.BackColor = Color.White;
        this.drawingPanel.BorderStyle = BorderStyle.FixedSingle;

        // MainForm
        this.ClientSize = new Size(700, 600);
        this.Controls.AddRange(new Control[] {
            cmbFigures,
            lblX1, txtX1, lblY1, txtY1,
            lblX2, txtX2, lblY2, txtY2,
            btnDrawSolid, btnDrawDashed, btnErase,
            lblInfo,
            drawingPanel
        });
        this.Text = "Геометрические фигуры";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
