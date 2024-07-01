namespace ScreenLocker;

partial class FormLockScreen
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public TextBox textBoxUnlockCode;
    public TextBox textBoxExitCode;

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
        this.textBoxUnlockCode = new TextBox();
        this.textBoxExitCode = new TextBox();

        // this.textBoxUnlockCode.AcceptsReturn = true;
        // this.textBoxUnlockCode.Dock = DockStyle.Fill;
        this.textBoxUnlockCode.Location = new Point(200, 100);

        this.textBoxExitCode.Location = new Point(200, 200);
        this.textBoxExitCode.PasswordChar = '*';


        this.components = new System.ComponentModel.Container();
        this.ShowInTaskbar = false;
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Text = "Form1"; 
        this.Controls.Add(this.textBoxUnlockCode);
        this.Controls.Add(this.textBoxExitCode);
        this.SuspendLayout();
        
    }

    

    #endregion
}
