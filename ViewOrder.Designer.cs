namespace LogIn1
{
    partial class ViewOrder
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.colOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMerchant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOrderHistory = new System.Windows.Forms.Label();
            this.lstHistory = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderId,
            this.colMerchant,
            this.colItems,
            this.colTotal,
            this.colStatus,
            this.colStage,
            this.colRider});
            this.dgvOrders.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvOrders.Location = new System.Drawing.Point(19, 74);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(960, 240);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
            // 
            // colOrderId
            // 
            this.colOrderId.HeaderText = "Order ID";
            this.colOrderId.MinimumWidth = 6;
            this.colOrderId.Name = "colOrderId";
            this.colOrderId.ReadOnly = true;
            // 
            // colMerchant
            // 
            this.colMerchant.HeaderText = "Merchant";
            this.colMerchant.MinimumWidth = 6;
            this.colMerchant.Name = "colMerchant";
            this.colMerchant.ReadOnly = true;
            // 
            // colItems
            // 
            this.colItems.HeaderText = "Items";
            this.colItems.MinimumWidth = 6;
            this.colItems.Name = "colItems";
            this.colItems.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total (₱)";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colStage
            // 
            this.colStage.HeaderText = "Current Stage";
            this.colStage.MinimumWidth = 6;
            this.colStage.Name = "colStage";
            this.colStage.ReadOnly = true;
            // 
            // colRider
            // 
            this.colRider.HeaderText = "Rider";
            this.colRider.MinimumWidth = 6;
            this.colRider.Name = "colRider";
            this.colRider.ReadOnly = true;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelTop.Controls.Add(this.btnBack);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.lblCustomerName);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 56);
            this.panelTop.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(680, 14);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(800, 14);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCustomerName.ForeColor = System.Drawing.Color.White;
            this.lblCustomerName.Location = new System.Drawing.Point(220, 20);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(0, 23);
            this.lblCustomerName.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(151, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "My Orders";
            // 
            // lblOrderHistory
            // 
            this.lblOrderHistory.AutoSize = true;
            this.lblOrderHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOrderHistory.Location = new System.Drawing.Point(12, 321);
            this.lblOrderHistory.Name = "lblOrderHistory";
            this.lblOrderHistory.Size = new System.Drawing.Size(121, 23);
            this.lblOrderHistory.TabIndex = 2;
            this.lblOrderHistory.Text = "Order History";
            // 
            // lstHistory
            // 
            this.lstHistory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 16;
            this.lstHistory.Location = new System.Drawing.Point(19, 348);
            this.lstHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(960, 116);
            this.lstHistory.TabIndex = 3;
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1000, 480);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.lblOrderHistory);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dgvOrders);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewOrder";
            this.Text = "My Orders - Customer";
            this.Load += new System.EventHandler(this.ViewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblOrderHistory;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMerchant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRider;
    }
}