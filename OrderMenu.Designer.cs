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
            this.lblCartTitle = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.colCartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.pnlCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();

            // splitContainerMain
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            this.splitContainerMain.Panel1.Controls.Add(this.pnlMenu);
            // 
            // splitContainerMain.Panel2
            this.splitContainerMain.Panel2.Controls.Add(this.pnlCart);
            this.splitContainerMain.Size = new System.Drawing.Size(1000, 700);
            this.splitContainerMain.SplitterDistance = 400;
            this.splitContainerMain.TabIndex = 0;

            // pnlMenu
            this.pnlMenu.Controls.Add(this.lblMenuTitle);
            this.pnlMenu.Controls.Add(this.dgvMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMenu.BackColor = System.Drawing.Color.WhiteSmoke;

            // lblMenuTitle
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMenuTitle.Location = new System.Drawing.Point(10, 10);
            this.lblMenuTitle.Text = "🍽️ Today\'s Menu";
            this.lblMenuTitle.Size = new System.Drawing.Size(180, 32);

            // dgvMenu
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMenuImage,
                this.colMenuName,
                this.colMenuPrice,
                this.colMenuAdd});
            this.dgvMenu.Location = new System.Drawing.Point(10, 60);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersVisible = false;
            this.dgvMenu.Size = new System.Drawing.Size(960, 320);
            this.dgvMenu.TabIndex = 1;

            // colMenuImage
            this.colMenuImage.HeaderText = "Image";
            this.colMenuImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colMenuImage.Name = "colMenuImage";
            this.colMenuImage.Width = 80;

            // colMenuName
            this.colMenuName.HeaderText = "Product Name";
            this.colMenuName.Name = "colMenuName";

            // colMenuPrice
            this.colMenuPrice.HeaderText = "Price (₱)";
            this.colMenuPrice.Name = "colMenuPrice";

            // colMenuAdd
            this.colMenuAdd.HeaderText = "Action";
            this.colMenuAdd.Name = "colMenuAdd";
            this.colMenuAdd.Text = "Add to Cart";
            this.colMenuAdd.UseColumnTextForButtonValue = true;

            // pnlCart
            this.pnlCart.BackColor = System.Drawing.Color.White;
            this.pnlCart.Controls.Add(this.lblCartTitle);
            this.pnlCart.Controls.Add(this.dgvCart);
            this.pnlCart.Controls.Add(this.btnPlaceOrder);
            this.pnlCart.Controls.Add(this.lblGrandTotal);
            this.pnlCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCart.Padding = new System.Windows.Forms.Padding(10);

            // lblCartTitle
            this.lblCartTitle.AutoSize = true;
            this.lblCartTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCartTitle.Location = new System.Drawing.Point(10, 10);
            this.lblCartTitle.Text = "🛒 Your Order";
            this.lblCartTitle.Size = new System.Drawing.Size(150, 30);

            // dgvCart
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
            this.dgvCart.Location = new System.Drawing.Point(10, 60);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.Size = new System.Drawing.Size(960, 200);
            this.dgvCart.TabIndex = 1;

            this.colCartName.HeaderText = "Product";
            this.colCartName.Name = "colCartName";
            this.colCartQty.HeaderText = "Quantity";
            this.colCartQty.Name = "colCartQty";
            this.colCartPrice.HeaderText = "Unit Price";
            this.colCartPrice.Name = "colCartPrice";
            this.colCartTotal.HeaderText = "Total";
            this.colCartTotal.Name = "colCartTotal";

            // btnPlaceOrder
            this.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(800, 280);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(170, 40);
            this.btnPlaceOrder.TabIndex = 2;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;

            // lblGrandTotal
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.Location = new System.Drawing.Point(10, 290);
            this.lblGrandTotal.Text = "Grand Total: ₱0.00";
            this.lblGrandTotal.Size = new System.Drawing.Size(200, 25);

            // OrderMenu
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "OrderMenu";
            this.Text = "Order Menu";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.pnlCart.ResumeLayout(false);
            this.pnlCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
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
    }
}