namespace LogIn1
{
    partial class SignUp
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.groupRole = new System.Windows.Forms.GroupBox();
            this.rbMerchant = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.rbRider = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupRole.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(199, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(313, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "SendFoodz Sign Up";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(58, 130);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(63, 199);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(63, 278);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(137, 20);
            this.lblConfirmPassword.TabIndex = 4;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(62, 154);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(450, 26);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(62, 223);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(450, 26);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(62, 302);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(450, 26);
            this.txtConfirmPassword.TabIndex = 7;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(59, 504);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(458, 50);
            this.btnCreateAccount.TabIndex = 12;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(62, 336);
            this.chkShowPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(148, 24);
            this.chkShowPassword.TabIndex = 8;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToLogin.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnBackToLogin.FlatAppearance.BorderSize = 2;
            this.btnBackToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToLogin.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnBackToLogin.Location = new System.Drawing.Point(62, 566);
            this.btnBackToLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(450, 50);
            this.btnBackToLogin.TabIndex = 12;
            this.btnBackToLogin.Text = "Back to Login";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click_1);
            // 
            // groupRole
            // 
            this.groupRole.Controls.Add(this.rbMerchant);
            this.groupRole.Controls.Add(this.rbCustomer);
            this.groupRole.Controls.Add(this.rbRider);
            this.groupRole.Location = new System.Drawing.Point(62, 402);
            this.groupRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupRole.Name = "groupRole";
            this.groupRole.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupRole.Size = new System.Drawing.Size(450, 68);
            this.groupRole.TabIndex = 0;
            this.groupRole.TabStop = false;
            this.groupRole.Text = "Select Role";
            // 
            // rbMerchant
            // 
            this.rbMerchant.AutoSize = true;
            this.rbMerchant.Location = new System.Drawing.Point(181, 38);
            this.rbMerchant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMerchant.Name = "rbMerchant";
            this.rbMerchant.Size = new System.Drawing.Size(101, 24);
            this.rbMerchant.TabIndex = 2;
            this.rbMerchant.Text = "Merchant";
            this.rbMerchant.UseVisualStyleBackColor = true;
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.Checked = true;
            this.rbCustomer.Location = new System.Drawing.Point(28, 38);
            this.rbCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(123, 24);
            this.rbCustomer.TabIndex = 0;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "👤 Customer";
            this.rbCustomer.UseVisualStyleBackColor = true;
            // 
            // rbRider
            // 
            this.rbRider.AutoSize = true;
            this.rbRider.Location = new System.Drawing.Point(316, 38);
            this.rbRider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbRider.Name = "rbRider";
            this.rbRider.Size = new System.Drawing.Size(92, 24);
            this.rbRider.TabIndex = 1;
            this.rbRider.Text = "🛵 Rider";
            this.rbRider.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.groupRole);
            this.panel1.Controls.Add(this.chkShowPassword);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblConfirmPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.btnCreateAccount);
            this.panel1.Controls.Add(this.btnBackToLogin);
            this.panel1.Location = new System.Drawing.Point(204, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 688);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LogIn1.Properties.Resources.ChatGPT_Image_Apr_17__2026__02_55_18_PM;
            this.pictureBox1.Location = new System.Drawing.Point(81, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(203, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fast and Easy Food Delivery";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(922, 812);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SignUp";
            this.Text = "SendFoodz Sign Up";
            this.Load += new System.EventHandler(this.SignUp_Load_1);
            this.groupRole.ResumeLayout(false);
            this.groupRole.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.RadioButton rbRider;
        private System.Windows.Forms.GroupBox groupRole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbMerchant;
    }
}