
// using System.Net.Http.Headers;
using Timer = System.Windows.Forms.Timer;

namespace ScreenLocker
{
    public partial class FormLockScreen : Form
    {
        private const string unlockCode = "1234"; // Replace with your desired unlock code
        // private Timer timer;

        public class Codes
        {
            public DateTimeOffset DateCreated { get; set; }
            public int Duration { get; set; } // In minutes
            public string Code { get; set; }
        }

        public class UsedCodes
        {
            public string Code { get; set; }
        }

        public FormLockScreen()
        {
            InitializeComponent();
            Main();
        }

        private void Main()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.Black;

            Label lockLabel = new()
            {
                Text = "Screen is locked!",
                ForeColor = Color.White,
                Font = new Font("Arial", 24, FontStyle.Bold),
                AutoSize = true
            };
            lockLabel.Location = new Point((this.Width - lockLabel.Width) / 2, (this.Height - lockLabel.Height) / 2);
            this.Controls.Add(lockLabel);

            this.KeyPreview = true;
            this.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    // Check if entered code is correct
                    if (textBoxUnlockCode.Text == unlockCode)
                    {
                        textBoxUnlockCode.Text = "";
                        // Hide the window and start the timer to show it again after 5 seconds
                        this.Opacity = 0;
                        Timer showTimer = new()
                        {
                            Interval = 5000 // Show the window again after 5 seconds
                        };
                        showTimer.Tick += (s, args) =>
                        {
                            this.Opacity = 1;
                            showTimer.Stop();
                        };
                        showTimer.Start();
                    } else if (textBoxExitCode.Text == "exit")
                    {
                        Application.Exit();
                    }
                }
            };

            // this.ShowDialog();
        }

        private void textBoxUnlockCode_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUnlockCode.Text == unlockCode)
            {
                // If code is correct, clear the textbox
                textBoxUnlockCode.Text = "";
            }
        }
    }
}