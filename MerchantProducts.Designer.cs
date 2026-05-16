namespace LogIn1
{
    partial class MerchantProducts
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.splitterMain = new System.Windows.Forms.SplitContainer();
            this.pnlInputForm = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpProductInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblImageName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterMain)).BeginInit();
            this.splitterMain.Panel1.SuspendLayout();
            this.splitterMain.Panel2.SuspendLayout();
            this.splitterMain.SuspendLayout();
            this.pnlInputForm.SuspendLayout();
            this.grpProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.splitterMain);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mainPanel.Size = new System.Drawing.Size(1400, 900);
            this.mainPanel.TabIndex = 0;
            // 
            // splitterMain
            // 
            this.splitterMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterMain.Location = new System.Drawing.Point(10, 10);
            this.splitterMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitterMain.Name = "splitterMain";
            // 
            // splitterMain.Panel1
            // 
            this.splitterMain.Panel1.BackColor = System.Drawing.Color.White;
            this.splitterMain.Panel1.Controls.Add(this.pnlInputForm);
            // 
            // splitterMain.Panel2
            // 
            this.splitterMain.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitterMain.Panel2.Controls.Add(this.dataGridView1);
            this.splitterMain.Size = new System.Drawing.Size(1378, 878);
            this.splitterMain.SplitterDistance = 419;
            this.splitterMain.TabIndex = 0;
            // 
            // pnlInputForm
            // 
            this.pnlInputForm.AutoScroll = true;
            this.pnlInputForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInputForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInputForm.Controls.Add(this.btnBack);
            this.pnlInputForm.Controls.Add(this.grpProductInfo);
            this.pnlInputForm.Controls.Add(this.btnSaveProduct);
            this.pnlInputForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputForm.Location = new System.Drawing.Point(0, 0);
            this.pnlInputForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlInputForm.Name = "pnlInputForm";
            this.pnlInputForm.Padding = new System.Windows.Forms.Padding(15);
            this.pnlInputForm.Size = new System.Drawing.Size(419, 878);
            this.pnlInputForm.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(15, 516);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(388, 45);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpProductInfo
            // 
            this.grpProductInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProductInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpProductInfo.Controls.Add(this.label1);
            this.grpProductInfo.Controls.Add(this.btnSelectImage);
            this.grpProductInfo.Controls.Add(this.txtQuantity);
            this.grpProductInfo.Controls.Add(this.pictureBox1);
            this.grpProductInfo.Controls.Add(this.lblImageName);
            this.grpProductInfo.Controls.Add(this.txtPrice);
            this.grpProductInfo.Controls.Add(this.lblPrice);
            this.grpProductInfo.Controls.Add(this.txtProductName);
            this.grpProductInfo.Controls.Add(this.lblProductName);
            this.grpProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.grpProductInfo.Location = new System.Drawing.Point(15, 15);
            this.grpProductInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProductInfo.Name = "grpProductInfo";
            this.grpProductInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProductInfo.Size = new System.Drawing.Size(390, 395);
            this.grpProductInfo.TabIndex = 1;
            this.grpProductInfo.TabStop = false;
            this.grpProductInfo.Text = "Product Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quantity";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnSelectImage.ForeColor = System.Drawing.Color.White;
            this.btnSelectImage.Location = new System.Drawing.Point(219, 335);
            this.btnSelectImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(155, 41);
            this.btnSelectImage.TabIndex = 6;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(15, 188);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(360, 30);
            this.txtQuantity.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(19, 244);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblImageName.Location = new System.Drawing.Point(15, 220);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(140, 20);
            this.lblImageName.TabIndex = 4;
            this.lblImageName.Text = "No image selected";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(15, 120);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(360, 30);
            this.txtPrice.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(15, 100);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 20);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(15, 60);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(360, 30);
            this.txtProductName.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblProductName.Location = new System.Drawing.Point(15, 40);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(122, 20);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSaveProduct.ForeColor = System.Drawing.Color.White;
            this.btnSaveProduct.Location = new System.Drawing.Point(15, 463);
            this.btnSaveProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(388, 45);
            this.btnSaveProduct.TabIndex = 0;
            this.btnSaveProduct.Text = "Save Product";
            this.btnSaveProduct.UseVisualStyleBackColor = false;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colPrice,
            this.colQty,
            this.colTotal});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(955, 878);
            this.dataGridView1.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 8;
            this.colName.Name = "colName";
            this.colName.Width = 150;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 8;
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 150;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Quantity";
            this.colQty.MinimumWidth = 8;
            this.colQty.Name = "colQty";
            this.colQty.Width = 150;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 8;
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 150;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            // 
            // MerchantProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MerchantProducts";
            this.Text = "Merchant Products Management";
            this.mainPanel.ResumeLayout(false);
            this.splitterMain.Panel1.ResumeLayout(false);
            this.splitterMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitterMain)).EndInit();
            this.splitterMain.ResumeLayout(false);
            this.pnlInputForm.ResumeLayout(false);
            this.grpProductInfo.ResumeLayout(false);
            this.grpProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.SplitContainer splitterMain;
        private System.Windows.Forms.Panel pnlInputForm;
        private System.Windows.Forms.GroupBox grpProductInfo;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Button btnBack;
    }
}