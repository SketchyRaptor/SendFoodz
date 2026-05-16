using System;
using System.Drawing;
using System.Windows.Forms;

namespace LogIn1
{
    public partial class MerchantDashBoard : Form
    {
        public MerchantDashBoard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            //this.Resize += MerchantDashBoard_Resize;
           // AdjustLayout();          // initial layout
            
            LoadCurrentBackground();
        }

        private void MerchantDashBoard_Resize(object sender, EventArgs e)
        {
            AdjustLayout();
        }

        private void AdjustLayout()
        {
            if (panelEditMenu == null) return;

            // Make panelEditMenu fill most of panelContent with margins
            int margin = 30;
            int newWidth = panelContent.Width - 2 * margin;
            int newHeight = panelContent.Height - 2 * margin;
            panelEditMenu.Width = Math.Max(400, newWidth);
            panelEditMenu.Height = Math.Max(300, newHeight);
            panelEditMenu.Left = (panelContent.Width - panelEditMenu.Width) / 2;
            panelEditMenu.Top = (panelContent.Height - panelEditMenu.Height) / 2;

            // Reposition and resize inner controls
            int btnWidth = 220;
            int btnHeight = 64;
            int spacing = 40;

            // Buttons (Sales History, Edit Menu)
            btnSalesHistory.Width = btnWidth;
            btnSalesHistory.Height = btnHeight;
            btnEditMenu.Width = btnWidth;
            btnEditMenu.Height = btnHeight;

            // Center them horizontally, stack vertically
            int centerX = panelEditMenu.Width / 2;
            btnSalesHistory.Left = centerX - btnWidth / 2;
            btnSalesHistory.Top = 80;

            btnEditMenu.Left = centerX - btnWidth / 2;
            btnEditMenu.Top = btnSalesHistory.Bottom + spacing;

            // Position upload button and preview on the right side
            int previewWidth = 250;
            int previewHeight = 155;
            int rightMargin = 30;
            picBackgroundPreview.Width = previewWidth;
            picBackgroundPreview.Height = previewHeight;
            picBackgroundPreview.Left = panelEditMenu.Width - previewWidth - rightMargin;
            picBackgroundPreview.Top = 80;

            btnUploadBackground.Width = 180;
            btnUploadBackground.Height = 30;
            btnUploadBackground.Left = picBackgroundPreview.Left;
            btnUploadBackground.Top = picBackgroundPreview.Bottom + 10;
        }

        private void LoadCurrentBackground()
        {
            Image bg = MerchantSettingsStorage.GetBackgroundImage(Form1.CurrentUsername);
            if (bg != null)
                picBackgroundPreview.Image = bg;
        }

        private void btnUploadBackground_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Select Background Image for Your Shop";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image newImage = Image.FromFile(ofd.FileName);
                        MerchantSettingsStorage.SetBackgroundImage(Form1.CurrentUsername, newImage);
                        picBackgroundPreview.Image = newImage;
                        MessageBox.Show("Background image updated successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEditMenu_Click(object sender, EventArgs e)
        {
            MerchantProducts merchantProducts = new MerchantProducts(Form1.CurrentUsername);
            merchantProducts.Show();
            this.Hide();
        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            MerchantHistory history = new MerchantHistory();
            history.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}