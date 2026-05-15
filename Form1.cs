using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn1
{
    public partial class Form1 : Form
    {
        private List<string> imageUrls = new List<string>();
        private int currentIndex = 0;
        private Timer autoScrollTimer;
        private PictureBox pictureBoxNext; // For smooth transitions
        private bool isLoading = false;



        public static List<Account> accounts = new List<Account>()
        {
            new Account { Username = "User123", Password = "123", Role = "Customer" }
        };

        public static string CurrentUsername { get; private set; }

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            this.Resize += Form1_Resize;
           //CenterLoginPanel();  // initial centering
            this.MinimumSize = new Size(800, 600);  // prevent extreme shrinking

            LoadPartnerLogos();

            // Display first logo
            DisplayCurrentLogo();
        }

        private void LoadPartnerLogos()
        {
            // Add your logo image paths here
            imageUrls.Add("https://images.openai.com/static-rsc-4/MjhY6xaWAAT25bTNWhka8T-dOBtsvmEfUsDqHA85ZQHmcWSrsML9ZP6FLGDGsdTGi-WnxlGnq8j4Rj_dfmldo4XKHcKeJR2jWIUr30ZN21EjOmoPyTeIRtew3GmqooubMiKI7yzq04JCXGdsEbSfwgDKJ36e3kQHFSx_hMx0m_g?purpose=inline");
            imageUrls.Add("https://images.openai.com/static-rsc-4/U97WIAUWTsUQIvtoRxdYzL_BE22Ie5Hx3pm6JmiwbfkngYtwaiU9LlIb-X0Cwy61dnk2iWocymoDF0SE8N8MfPOscwNjlBNIXqZna3A0cNZrmYZa6Qwtq4j7l62BmNn_VPNpe63idbzNlsibrFYHyj_Blf9LptDvmNpsw1A0o3Y?purpose=inline");
            imageUrls.Add("https://images.openai.com/static-rsc-4/HTM2y27eX9rrRinQk1ZCOz8vlS9iE_7kv-wNRlM3QLZBmWOCAugXnakgQ_7svCh600B258S1j4hAu_CMP_XDoKQqTbFXc57Xq55BMbphaYXBUcGyBBGB2ODEbox-7XMGoaMPIuEUymV1d4Y4DhGnMb-d56t5U0v9ocJU8cvBijk?purpose=inline");
            imageUrls.Add("https://images.openai.com/static-rsc-4/FAEdzr1_rxoF4v3FoB0LB-xl0lCmXxdXaT7Mr0Uxjxaue4EGRy6C2ifWnjWUNLdEmLOBqvNZFBva7DLCcMjPQ0gciYnHyNQoBD_ueno8PX_HeRqdxuc3v8-o3ycHC3KK4Cb3iwzsLqFXzG8ZRnJewf7XmA3LNGTgsp72bG5A8-w?purpose=inline");
            imageUrls.Add("https://images.openai.com/static-rsc-4/Z-kEXURVaZpE4GWCH6TXGaHqkWGKJO_Qzy8JaSKLjvFL7nY2xaV5oXrBwfEbsSk2qaV9_Pl9SO4ARLAnlA0jBSge5po29jpPzUsMEqmg1q9rxvP8qSPrl3S9DBh0xkGqm4kfRK4ch1PQhfDYyOz6F5YdxwvTKv0oIzngU_TOOUw?purpose=inline");

            SetupPictureBoxForSmoothTransition();

            // Start with first image
            PreloadImages();
            DisplayCurrentLogo();
            StartAutoScroll();
        }

        private void SetupPictureBoxForSmoothTransition()
        {
            // Enable double buffering for smooth rendering
            pictureBoxScroll.DoubleBuffered(true);

            // Set high quality image rendering
            pictureBoxScroll.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxScroll.BackColor = Color.FromArgb(240, 242, 245);
        }

        private async Task FadeTransition(Image newImage)
        {
            // Smooth fade animation
            for (int opacity = 0; opacity <= 100; opacity += 10)
            {
                pictureBoxScroll.Image = newImage;
                pictureBoxScroll.Refresh();
                await Task.Delay(5);
            }
        }

        private async void PreloadImages()
        {
            // Preload next image for instant display
            _ = Task.Run(async () =>
            {
                foreach (string url in imageUrls)
                {
                    try
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            await client.GetByteArrayAsync(url);
                        }
                    }
                    catch { }
                }
            });
        }

        private void StartAutoScroll()
        {
            autoScrollTimer = new Timer();
            autoScrollTimer.Interval = 4000; // 4 seconds for smoother experience
            autoScrollTimer.Tick += async (s, e) =>
            {
                autoScrollTimer.Stop();
                await GoToNextImage();
                autoScrollTimer.Start();
            };
            autoScrollTimer.Start();
        }

        private async Task GoToNextImage()
        {
            if (imageUrls.Count == 0) return;

            currentIndex++;
            if (currentIndex >= imageUrls.Count) currentIndex = 0;

            await DisplayCurrentLogoSmooth();
        }

        private async Task GoToPreviousImage()
        {
            if (imageUrls.Count == 0) return;

            currentIndex--;
            if (currentIndex < 0) currentIndex = imageUrls.Count - 1;

            await DisplayCurrentLogoSmooth();
        }

        private async Task DisplayCurrentLogoSmooth()
        {
            if (isLoading || imageUrls.Count == 0) return;

            isLoading = true;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] imageBytes = await client.GetByteArrayAsync(imageUrls[currentIndex]);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image newImage = Image.FromStream(ms);

                        // Smooth cross-fade
                        await CrossFadeImage(newImage);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                isLoading = false;
            }
        }

        private async Task CrossFadeImage(Image newImage)
        {
            // Create temporary PictureBox for fade effect
            PictureBox tempBox = new PictureBox
            {
                Image = newImage,
                Size = pictureBoxScroll.Size,
                Location = pictureBoxScroll.Location,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Visible = true
            };

            this.Controls.Add(tempBox);
            tempBox.BringToFront();

            // Fade in new image
            for (int opacity = 0; opacity <= 100; opacity += 5)
            {
                tempBox.BackColor = Color.FromArgb(opacity * 255 / 100, 0, 0, 0);
                await Task.Delay(3);
            }

            // Set the actual PictureBox image
            pictureBoxScroll.Image = newImage;

            // Fade out temp box
            for (int opacity = 100; opacity >= 0; opacity -= 10)
            {
                tempBox.BackColor = Color.FromArgb(opacity * 255 / 100, 0, 0, 0);
                await Task.Delay(2);
            }

            tempBox.Dispose();
        }

        private async void DisplayCurrentLogo()
        {
            if (imageUrls.Count > 0 && currentIndex >= 0 && currentIndex < imageUrls.Count)
            {
                // Show loading indicator
                pictureBoxScroll.Image = null;
                pictureBoxScroll.BackColor = Color.LightGray;

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        byte[] imageBytes = await client.GetByteArrayAsync(imageUrls[currentIndex]);
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pictureBoxScroll.Image = Image.FromStream(ms);
                            pictureBoxScroll.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
                catch (Exception ex)
                {
                    pictureBoxScroll.BackColor = Color.Red;
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }
            }
        }

        // Button Click Events - Connect these to your btnLeft and btnRight
        private void btnLeft_Click(object sender, EventArgs e)
        {
            // Go to previous logo
            currentIndex--;
            if (currentIndex < 0)
            {
                //currentIndex = partnerLogos.Count - 1; // Loop to last
            }
            DisplayCurrentLogo();
        }



        // Center the white panel inside the form on resize
        private void Form1_Resize(object sender, EventArgs e)
        {
            //CenterLoginPanel();
        }

       /*
        private void CenterLoginPanel()
        {
            if (panel1 == null) return;
            int x = (this.ClientSize.Width - panel1.Width) / 2;
            int y = (this.ClientSize.Height - panel1.Height) / 2;
            panel1.Location = new Point(Math.Max(0, x), Math.Max(0, y));
        }
       */
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "admin123")
            {
                MessageBox.Show("Admin login successful");
                CurrentUsername = username;
                AdminDashboard admin = new AdminDashboard();
                admin.Show();
                this.Hide();
                return;
            }

            foreach (var acc in accounts)
            {
                if (acc.Username == username && acc.Password == password)
                {
                    MessageBox.Show("Login successful");
                    CurrentUsername = username;
                    if (acc.Role == "Merchant")
                    {
                        MerchantDashBoard merchantDashBoard = new MerchantDashBoard();
                        merchantDashBoard.Show();
                    }
                    else if (acc.Role == "Rider")
                    {
                        RiderDashboard riderDashboard = new RiderDashboard();
                        riderDashboard.Show();
                    }
                    else
                    {
                        CustomerDashboard customerDashboard = new CustomerDashboard();
                        customerDashboard.Show();
                    }
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show("Invalid username or password");
        }

        public class Account
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signupForm = new SignUp();
            signupForm.Show();
            this.Hide();
        }

        public static List<string> riders = new List<string>()
        {
            "Rider001", "Rider002", "Rider003"
        };

        public static List<string> pendingOrders = new List<string>()
        {
            "Order #1001", "Order #1002", "Order #1003"
        };

        private void Form1_Load(object sender, EventArgs e) { }

        private async void btnLeft_Click_1(object sender, EventArgs e)
        {
            autoScrollTimer?.Stop();
            await GoToPreviousImage();
            autoScrollTimer?.Start();
        }

        private async void btnRight_Click(object sender, EventArgs e)
        {
            autoScrollTimer?.Stop();
            await GoToNextImage();
            autoScrollTimer?.Start();
        }
    }
    public static class ControlExtensions
    {
        public static void DoubleBuffered(this Control control, bool enable)
        {
            var prop = typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            prop?.SetValue(control, enable, null);
        }
    }
}