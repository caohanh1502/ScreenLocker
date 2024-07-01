
namespace ScreenLocker;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public TextBox txtLog;
    public Button btnGenerateCode;
    public Button btnSendCode;
    public Button btnLockScreen;
    public Label lblCountdown;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.txtLog = new TextBox();
        this.btnGenerateCode = new Button();
        this.btnSendCode = new Button();
        this.btnLockScreen = new Button();
        this.lblCountdown = new Label();



        this.txtLog.Location = new Point(200, 300);
        this.txtLog.Size = new Size(200,300);
        this.txtLog.Multiline = true;
        this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;


        this.lblCountdown.Location = new Point(150, 100);
        this.lblCountdown.Text = "HI";
        this.lblCountdown.AutoSize = true;


        this.btnLockScreen.Location = new Point(50,50);
        this.btnLockScreen.Text = "LOCK!";
        this.btnLockScreen.Click += new System.EventHandler(this.btnLockScreen_Click);


        this.btnGenerateCode.Location = new Point(150,50);
        this.btnGenerateCode.Text = "Generate codes";
        this.btnGenerateCode.Click += new System.EventHandler(this.btnGenerateCode_Click);


        this.components = new System.ComponentModel.Container();
        // this.Font = new Font("Arial", 24, FontStyle.Bold);
        this.Load += new System.EventHandler(this.MainForm_Load);
        this.AutoScaleMode = AutoScaleMode.Dpi;
        this.ClientSize = new Size(800, 450);
        this.Text = "Form1"; 
        this.Controls.Add(this.txtLog);
        this.Controls.Add(this.btnLockScreen);
        this.Controls.Add(this.btnGenerateCode);
        this.Controls.Add(this.lblCountdown);
        this.SuspendLayout();
    }


    #endregion
}
