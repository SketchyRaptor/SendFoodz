namespace LogIn1
{
    partial class OrderMenu
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.colMenuImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colMenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMenuPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMenuAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCartTitle = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.colCartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.pnlCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.pnlMenu);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.pnlCart);
            this.splitContainerMain.Size = new System.Drawing.Size(1143, 840);
            this.splitContainerMain.SplitterDistance = 480;
            this.splitContainerMain.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.dgvMenu);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlMenu.Size = new System.Drawing.Size(1143, 480);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMenuTitle.Location = new System.Drawing.Point(381, 10);
            this.lblMenuTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(263, 41);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.Text = "🍽️ Today\'s Menu";
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMenuImage,
            this.colMenuName,
            this.colMenuPrice,
            this.colMenuAdd});
            this.dgvMenu.Location = new System.Drawing.Point(22, 89);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersVisible = false;
            this.dgvMenu.RowHeadersWidth = 62;
            this.dgvMenu.Size = new System.Drawing.Size(1097, 360);
            this.dgvMenu.TabIndex = 1;
            // 
            // colMenuImage
            // 
            this.colMenuImage.HeaderText = "Image";
            this.colMenuImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colMenuImage.MinimumWidth = 8;
            this.colMenuImage.Name = "colMenuImage";
            // 
            // colMenuName
            // 
            this.colMenuName.HeaderText = "Product Name";
            this.colMenuName.MinimumWidth = 8;
            this.colMenuName.Name = "colMenuName";
            // 
            // colMenuPrice
            // 
            this.colMenuPrice.HeaderText = "Price (₱)";
            this.colMenuPrice.MinimumWidth = 8;
            this.colMenuPrice.Name = "colMenuPrice";
            // 
            // colMenuAdd
            // 
            this.colMenuAdd.HeaderText = "Action";
            this.colMenuAdd.MinimumWidth = 8;
            this.colMenuAdd.Name = "colMenuAdd";
            this.colMenuAdd.Text = "Add to Cart";
            this.colMenuAdd.UseColumnTextForButtonValue = true;
            // 
            // pnlCart
            // 
            this.pnlCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCart.Controls.Add(this.btnBack);
            this.pnlCart.Controls.Add(this.dgvCart);
            this.pnlCart.Controls.Add(this.btnPlaceOrder);
            this.pnlCart.Controls.Add(this.lblGrandTotal);
            this.pnlCart.Controls.Add(this.panel2);
            this.pnlCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCart.Location = new System.Drawing.Point(0, 0);
            this.pnlCart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlCart.Size = new System.Drawing.Size(1143, 356);
            this.pnlCart.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightGray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(692, 298);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(195, 42);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCartTitle
            // 
            this.lblCartTitle.AutoSize = true;
            this.lblCartTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCartTitle.Location = new System.Drawing.Point(427, 15);
            this.lblCartTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCartTitle.Name = "lblCartTitle";
            this.lblCartTitle.Size = new System.Drawing.Size(201, 37);
            this.lblCartTitle.TabIndex = 0;
            this.lblCartTitle.Text = "🛒 Your Order";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCartName,
            this.colCartQty,
            this.colCartPrice,
            this.colCartTotal});
            this.dgvCart.Location = new System.Drawing.Point(20, 78);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowHeadersWidth = 62;
            this.dgvCart.Size = new System.Drawing.Size(1097, 214);
            this.dgvCart.TabIndex = 1;
            // 
            // colCartName
            // 
            this.colCartName.HeaderText = "Product";
            this.colCartName.MinimumWidth = 8;
            this.colCartName.Name = "colCartName";
            // 
            // colCartQty
            // 
            this.colCartQty.HeaderText = "Quantity";
            this.colCartQty.MinimumWidth = 8;
            this.colCartQty.Name = "colCartQty";
            // 
            // colCartPrice
            // 
            this.colCartPrice.HeaderText = "Unit Price";
            this.colCartPrice.MinimumWidth = 8;
            this.colCartPrice.Name = "colCartPrice";
            // 
            // colCartTotal
            // 
            this.colCartTotal.HeaderText = "Total";
            this.colCartTotal.MinimumWidth = 8;
            this.colCartTotal.Name = "colCartTotal";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(922, 298);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(195, 42);
            this.btnPlaceOrder.TabIndex = 2;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.Location = new System.Drawing.Point(12, 310);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(225, 32);
            this.lblGrandTotal.TabIndex = 3;
            this.lblGrandTotal.Text = "Grand Total: ₱0.00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblMenuTitle);
            this.panel1.Location = new System.Drawing.Point(21, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 64);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblCartTitle);
            this.panel2.Location = new System.Drawing.Point(21, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1096, 64);
            this.panel2.TabIndex = 5;
            // 
            // OrderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 840);
            this.Controls.Add(this.splitContainerMain);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OrderMenu";
            this.Text = "Order Menu";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.pnlCart.ResumeLayout(false);
            this.pnlCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewImageColumn colMenuImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenuPrice;
        private System.Windows.Forms.DataGridViewButtonColumn colMenuAdd;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.Label lblCartTitle;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartTotal;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}