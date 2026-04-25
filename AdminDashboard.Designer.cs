namespace LogIn1
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvRiders;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblRiders;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Button btnRefresh;
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.dgvRiders = new System.Windows.Forms.DataGridView();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblRiders = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(272, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(582, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SendFoodz Admin Dashboard";
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeight = 34;
            this.dgvUsers.Location = new System.Drawing.Point(50, 120);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.Size = new System.Drawing.Size(300, 200);
            this.dgvUsers.TabIndex = 2;
            // 
            // dgvRiders
            // 
            this.dgvRiders.ColumnHeadersHeight = 34;
            this.dgvRiders.Location = new System.Drawing.Point(400, 120);
            this.dgvRiders.Name = "dgvRiders";
            this.dgvRiders.RowHeadersWidth = 62;
            this.dgvRiders.Size = new System.Drawing.Size(300, 200);
            this.dgvRiders.TabIndex = 4;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeight = 34;
            this.dgvOrders.Location = new System.Drawing.Point(750, 120);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 62;
            this.dgvOrders.Size = new System.Drawing.Size(300, 200);
            this.dgvOrders.TabIndex = 6;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(50, 90);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(108, 20);
            this.lblUsers.TabIndex = 1;
            this.lblUsers.Text = "Current Users";
            // 
            // lblRiders
            // 
            this.lblRiders.AutoSize = true;
            this.lblRiders.Location = new System.Drawing.Point(400, 90);
            this.lblRiders.Name = "lblRiders";
            this.lblRiders.Size = new System.Drawing.Size(112, 20);
            this.lblRiders.TabIndex = 3;
            this.lblRiders.Text = "Current Riders";
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Location = new System.Drawing.Point(750, 90);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(119, 20);
            this.lblOrders.TabIndex = 5;
            this.lblOrders.Text = "Pending Orders";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(480, 350);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(200, 40);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // AdminDashboard
            // 
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.lblRiders);
            this.Controls.Add(this.dgvRiders);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.btnRefresh);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}