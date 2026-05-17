using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn1
{
    using System;
    using System.Windows.Forms;

    namespace LogIn1
    {
        public partial class AddressDialog : Form
        {
            public string DeliveryAddress { get; private set; }

            private TextBox txtAddress;
            private TextBox txtStreet;
            private TextBox txtCity;
            private TextBox txtBarangay;
            private ComboBox cmbProvince;
            private Button btnOk;
            private Button btnCancel;

            public AddressDialog()
            {
                InitializeComponent();
                this.StartPosition = FormStartPosition.CenterParent;
            }

            private void InitializeComponent()
            {
                this.Text = "Delivery Address";
                this.Size = new System.Drawing.Size(500, 350);
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.MaximizeBox = false;
                this.MinimizeBox = false;

                // Labels and TextBoxes
                Label lblAddress = new Label
                {
                    Text = "Street Address:",
                    Location = new System.Drawing.Point(20, 20),
                    Size = new System.Drawing.Size(120, 25),
                    Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                };
                txtStreet = new TextBox
                {
                    Location = new System.Drawing.Point(150, 20),
                    Size = new System.Drawing.Size(300, 25)
                };

                Label lblBarangay = new Label
                {
                    Text = "Barangay:",
                    Location = new System.Drawing.Point(20, 60),
                    Size = new System.Drawing.Size(120, 25),
                    Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                };
                txtBarangay = new TextBox
                {
                    Location = new System.Drawing.Point(150, 60),
                    Size = new System.Drawing.Size(300, 25)
                };

                Label lblCity = new Label
                {
                    Text = "City/Municipality:",
                    Location = new System.Drawing.Point(20, 100),
                    Size = new System.Drawing.Size(120, 25),
                    Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                };
                txtCity = new TextBox
                {
                    Location = new System.Drawing.Point(150, 100),
                    Size = new System.Drawing.Size(300, 25)
                };

                Label lblProvince = new Label
                {
                    Text = "Province:",
                    Location = new System.Drawing.Point(20, 140),
                    Size = new System.Drawing.Size(120, 25),
                    Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                };
                cmbProvince = new ComboBox
                {
                    Location = new System.Drawing.Point(150, 140),
                    Size = new System.Drawing.Size(300, 25),
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                cmbProvince.Items.AddRange(new string[] { "Metro Manila", "Bulacan", "Cavite", "Laguna", "Rizal", "Pampanga","Cebu", "Other" });
                cmbProvince.SelectedIndex = 0;

                Label lblLandmark = new Label
                {
                    Text = "Landmark (Optional):",
                    Location = new System.Drawing.Point(20, 180),
                    Size = new System.Drawing.Size(150, 25),
                    Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                };
                txtAddress = new TextBox
                {
                    Location = new System.Drawing.Point(180, 180),
                    Size = new System.Drawing.Size(270, 25)
                };

                // Buttons
                btnOk = new Button
                {
                    Text = "CONFIRM ADDRESS",
                    DialogResult = DialogResult.OK,
                    Location = new System.Drawing.Point(150, 240),
                    Size = new System.Drawing.Size(130, 40),
                    BackColor = System.Drawing.Color.FromArgb(76, 175, 80),
                    ForeColor = System.Drawing.Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
                };
                btnOk.FlatAppearance.BorderSize = 0;
                btnOk.Click += (s, e) => ValidateAndSetAddress();

                btnCancel = new Button
                {
                    Text = "CANCEL",
                    DialogResult = DialogResult.Cancel,
                    Location = new System.Drawing.Point(300, 240),
                    Size = new System.Drawing.Size(130, 40),
                    BackColor = System.Drawing.Color.FromArgb(244, 67, 54),
                    ForeColor = System.Drawing.Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
                };
                btnCancel.FlatAppearance.BorderSize = 0;

                // Add all controls
                Controls.Add(lblAddress);
                Controls.Add(txtStreet);
                Controls.Add(lblBarangay);
                Controls.Add(txtBarangay);
                Controls.Add(lblCity);
                Controls.Add(txtCity);
                Controls.Add(lblProvince);
                Controls.Add(cmbProvince);
                Controls.Add(lblLandmark);
                Controls.Add(txtAddress);
                Controls.Add(btnOk);
                Controls.Add(btnCancel);
            }

            private void ValidateAndSetAddress()
            {
                if (string.IsNullOrWhiteSpace(txtStreet.Text))
                {
                    MessageBox.Show("Please enter your street address.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStreet.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtBarangay.Text))
                {
                    MessageBox.Show("Please enter your barangay.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBarangay.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCity.Text))
                {
                    MessageBox.Show("Please enter your city/municipality.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCity.Focus();
                    return;
                }

                // Build complete address
                DeliveryAddress = $"{txtStreet.Text}, {txtBarangay.Text}, {txtCity.Text}, {cmbProvince.SelectedItem}";

                if (!string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    DeliveryAddress += $" (Near: {txtAddress.Text})";
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
