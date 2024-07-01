
// using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using Timer = System.Windows.Forms.Timer;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ScreenLocker
{
    public partial class Form1 : Form
    {
        private TimeSpan remainingTime;
        private Timer timer;
        private const string unlockCode = "1234"; // Replace with your desired unlock code
        private const string exitCode = "mastercode";
        // private Timer timer;

        public class Codes
        {
            public long TimeCreated { get; set; }
            public string Code { get; set; }
            public int Duration { get; set; } // In minutes
        }

        public class UsedCodes
        {
            public string Code { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            // Main();
            // FormLockScreen formLockScreen = new();
            // formLockScreen.Show();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set initial remaining time to 5 minutes
            remainingTime = TimeSpan.FromSeconds(5);

            // Initialize and configure timer
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;

            // Start the timer
            timer.Start();
        }

        private void Main()
        {
            // timer = new Timer();
            // timer.Interval = 5000; // Lock the screen after 5 seconds of inactivity
            // timer.Tick += (sender, e) =>
            // {
            //     LockScreen();
            // };
            // timer.Start();

            // Send to server
            // var url = "https://caohanh.com/ch/uptest/server.php";
            // var filePath = @"E:\figma2.png";

            // HttpClient httpClient = new();
            // MultipartFormDataContent form = new();

            // FileStream fs = File.OpenRead(filePath);
            // var streamContent = new StreamContent(fs);

            // var fileContent = new ByteArrayContent(streamContent.ReadAsByteArrayAsync().Result);
            // // fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");

            // var fileNameUpload = Path.GetFileNameWithoutExtension(filePath) + "_" + DateTimeOffset.UtcNow.ToUnixTimeSeconds() + Path.GetExtension(filePath);

            // form.Add(fileContent, "fileToUpload", fileNameUpload);
            // var response = httpClient.PostAsync(url, form).Result;
            // textBoxLog.Text = response.StatusCode.ToString();
            // if (response.StatusCode.ToString().ToLower() == "ok")
            // {
            //     LockScreen();
            // }
            string randomCode = GenerateCode(6);
            // LockScreen();
        }

        // private void LockScreen()
        // {
        //     this.TopMost = true;
        //     this.FormBorderStyle = FormBorderStyle.None;
        //     this.WindowState = FormWindowState.Maximized;
        //     this.BackColor = Color.Black;
            

        //     Label lockLabel = new()
        //     {
        //         Text = "Screen is locked!",
        //         ForeColor = Color.White,
        //         Font = new Font("Arial", 24, FontStyle.Bold),
        //         AutoSize = true
        //     };
        //     lockLabel.Location = new Point((this.Width - lockLabel.Width) / 2, (this.Height - lockLabel.Height) / 2);
        //     this.Controls.Add(lockLabel);

        //     this.KeyPreview = true;
        //     this.KeyDown += (sender, e) =>
        //     {
        //         if (e.KeyCode == Keys.Enter)
        //         {
        //             // Check if entered code is correct
        //             if (txtEnterCode.Text == unlockCode)
        //             {
        //                 txtEnterCode.Text = "";
        //                 // Hide the window and start the timer to show it again after 5 seconds
        //                 this.Hide();
        //                 Timer showTimer = new()
        //                 {
        //                     Interval = 5000 // Show the window again after 5 seconds
        //                 };
        //                 showTimer.Tick += (s, args) =>
        //                 {
        //                     this.Show();
        //                     showTimer.Stop();
        //                 };
        //                 showTimer.Start();
        //             } else if (txtExitCode.Text == exitCode)
        //             {
        //                 txtExitCode.Text = "";
        //                 this.Close();
        //             }
        //         }
        //     };

        //     // this.ShowDialog();
        // }

        public static string GenerateCode(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var code = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                code.Append(chars[random.Next(chars.Length)]);
            }
            return code.ToString();
        }


        private void btnLockScreen_Click(object sender, EventArgs e)
        {
            FormLockScreen formLockScreen = new();
            formLockScreen.Show();
            this.Hide();
        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            string randomCode = GenerateCode(6);
            // MessageBox.Show(randomCode, "Code generated", MessageBoxButtons.OK);
            // Codes codes = new()
            // {
            //     DateCreated = DateTime.UtcNow,
            //     Code = randomCode,
            //     Duration = 5
            // };
            List<Codes> _data = new();
            for (int i = 1; i <= 5; i++) {
                _data.Add(new Codes() {
                    TimeCreated = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                    Code = GenerateCode(6),
                    Duration = 5
                });
            }
            string json = JsonSerializer.Serialize(_data);
            // MessageBox.Show(TimeSpan.FromMinutes(codes.Duration).ToString(), "", MessageBoxButtons.OK);
            try {
                File.WriteAllText(@"E:\path.json", json);
            } catch (Exception ex) {
                txtLog.Text += "\n" + ex.Message;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update remaining time
            remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));

            // Update the label displaying the remaining time
            lblCountdown.Text = $"Time Remaining: {remainingTime:mm\\:ss}";

            // Check if time is up
            if (remainingTime.TotalSeconds <= 0)
            {
                timer.Stop();
                MessageBox.Show("Time's up!"); // Replace this with the lock function
            }
        }
    }
}