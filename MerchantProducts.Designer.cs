namespace LogIn1
{
    partial class MerchantProducts
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
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.splitterMain = new System.Windows.Forms.SplitContainer();
            this.pnlInputForm = new System.Windows.Forms.Panel();
            this.grpFoodOptions = new System.Windows.Forms.GroupBox();
            this.btnAddFoodOption = new System.Windows.Forms.Button();
            this.pnlFoodOptionsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.grpProductInfo = new System.Windows.Forms.GroupBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.picProductImage = new System.Windows.Forms.PictureBox();
            this.lblImageName = new System.Windows.Forms.Label();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFoodOptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterMain)).BeginInit();
            this.splitterMain.Panel1.SuspendLayout();
            this.splitterMain.Panel2.SuspendLayout();
            this.splitterMain.SuspendLayout();
            this.pnlInputForm.SuspendLayout();
            this.grpFoodOptions.SuspendLayout();
            this.grpProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.lblTitle);
            this.mainPanel.Controls.Add(this.splitterMain);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mainPanel.Size = new System.Drawing.Size(1400, 900);
            this.mainPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add Products";
            // 
            // splitterMain
            // 
            this.splitterMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitterMain.Location = new System.Drawing.Point(10, 50);
            this.splitterMain.Name = "splitterMain";
            // 
            // splitterMain.Panel1
            // 
            this.splitterMain.Panel1.BackColor = System.Drawing.Color.White;
            this.splitterMain.Panel1.Controls.Add(this.pnlInputForm);
            // 
            // splitterMain.Panel2
            // 
            this.splitterMain.Panel2.BackColor = System.Drawing.Color.White;
            this.splitterMain.Panel2.Controls.Add(this.dgvProducts);
            this.splitterMain.Size = new System.Drawing.Size(1380, 840);
            this.splitterMain.SplitterDistance = 420;
            this.splitterMain.TabIndex = 0;
            // 
            // pnlInputForm
            // 
            this.pnlInputForm.AutoScroll = true;
            this.pnlInputForm.BackColor = System.Drawing.Color.White;
            this.pnlInputForm.Controls.Add(this.grpFoodOptions);
            this.pnlInputForm.Controls.Add(this.grpProductInfo);
            this.pnlInputForm.Controls.Add(this.btnAddProduct);
            this.pnlInputForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputForm.Location = new System.Drawing.Point(0, 0);
            this.pnlInputForm.Name = "pnlInputForm";
            this.pnlInputForm.Padding = new System.Windows.Forms.Padding(15);
            this.pnlInputForm.Size = new System.Drawing.Size(420, 840);
            this.pnlInputForm.TabIndex = 0;
            // 
            // grpFoodOptions
            // 
            this.grpFoodOptions.BackColor = System.Drawing.Color.White;
            this.grpFoodOptions.Controls.Add(this.btnAddFoodOption);
            this.grpFoodOptions.Controls.Add(this.pnlFoodOptionsContainer);
            this.grpFoodOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.grpFoodOptions.Location = new System.Drawing.Point(15, 320);
            this.grpFoodOptions.Name = "grpFoodOptions";
            this.grpFoodOptions.Size = new System.Drawing.Size(390, 350);
            this.grpFoodOptions.TabIndex = 2;
            this.grpFoodOptions.TabStop = false;
            this.grpFoodOptions.Text = "Food Options";
            // 
            // btnAddFoodOption
            // 
            this.btnAddFoodOption.BackColor = System.Drawing.Color.Green;
            this.btnAddFoodOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFoodOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddFoodOption.ForeColor = System.Drawing.Color.White;
            this.btnAddFoodOption.Location = new System.Drawing.Point(15, 310);
            this.btnAddFoodOption.Name = "btnAddFoodOption";
            this.btnAddFoodOption.Size = new System.Drawing.Size(360, 32);
            this.btnAddFoodOption.TabIndex = 1;
            this.btnAddFoodOption.Text = "+ Add Food Option";
            this.btnAddFoodOption.UseVisualStyleBackColor = false;
            // 
            // pnlFoodOptionsContainer
            // 
            this.pnlFoodOptionsContainer.AutoScroll = true;
            this.pnlFoodOptionsContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFoodOptionsContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFoodOptionsContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlFoodOptionsContainer.Location = new System.Drawing.Point(15, 30);
            this.pnlFoodOptionsContainer.Name = "pnlFoodOptionsContainer";
            this.pnlFoodOptionsContainer.Size = new System.Drawing.Size(360, 270);
            this.pnlFoodOptionsContainer.TabIndex = 0;
            this.pnlFoodOptionsContainer.WrapContents = false;
            // 
            // grpProductInfo
            // 
            this.grpProductInfo.BackColor = System.Drawing.Color.White;
            this.grpProductInfo.Controls.Add(this.btnSelectImage);
            this.grpProductInfo.Controls.Add(this.picProductImage);
            this.grpProductInfo.Controls.Add(this.lblImageName);
            this.grpProductInfo.Controls.Add(this.txtProductDescription);
            this.grpProductInfo.Controls.Add(this.lblDescription);
            this.grpProductInfo.Controls.Add(this.txtProductName);
            this.grpProductInfo.Controls.Add(this.lblProductName);
            this.grpProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.grpProductInfo.Location = new System.Drawing.Point(15, 15);
            this.grpProductInfo.Name = "grpProductInfo";
            this.grpProductInfo.Size = new System.Drawing.Size(390, 300);
            this.grpProductInfo.TabIndex = 1;
            this.grpProductInfo.TabStop = false;
            this.grpProductInfo.Text = "Product Information";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnSelectImage.ForeColor = System.Drawing.Color.White;
            this.btnSelectImage.Location = new System.Drawing.Point(220, 255);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(155, 32);
            this.btnSelectImage.TabIndex = 6;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = false;
            // 
            // picProductImage
            // 
            this.picProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProductImage.Location = new System.Drawing.Point(15, 180);
            this.picProductImage.Name = "picProductImage";
            this.picProductImage.Size = new System.Drawing.Size(200, 107);
            this.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProductImage.TabIndex = 5;
            this.picProductImage.TabStop = false;
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblImageName.Location = new System.Drawing.Point(15, 155);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(140, 20);
            this.lblImageName.TabIndex = 4;
            this.lblImageName.Text = "No image selected";
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(15, 120);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(360, 30);
            this.txtProductDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(15, 100);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 20);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(15, 60);
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
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(15, 685);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(390, 45);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Save Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductName,
            this.colDescription,
            this.colFoodOptions,
            this.colImage,
            this.colEdit,
            this.colDelete});
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.Size = new System.Drawing.Size(956, 840);
            this.dgvProducts.TabIndex = 0;
            // 
            // colProductName
            // 
            this.colProductName.DataPropertyName = "ProductName";
            this.colProductName.HeaderText = "Product Name";
            this.colProductName.MinimumWidth = 120;
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Width = 120;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "Description";
            this.colDescription.MinimumWidth = 150;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 150;
            // 
            // colFoodOptions
            // 
            this.colFoodOptions.DataPropertyName = "FoodOptionsDisplay";
            this.colFoodOptions.HeaderText = "Food Options";
            this.colFoodOptions.MinimumWidth = 200;
            this.colFoodOptions.Name = "colFoodOptions";
            this.colFoodOptions.ReadOnly = true;
            this.colFoodOptions.Width = 200;
            // 
            // colImage
            // 
            this.colImage.DataPropertyName = "ImagePath";
            this.colImage.HeaderText = "Image";
            this.colImage.MinimumWidth = 100;
            this.colImage.Name = "colImage";
            this.colImage.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "Edit";
            this.colEdit.MinimumWidth = 80;
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            this.colEdit.Width = 80;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Delete";
            this.colDelete.MinimumWidth = 80;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "Delete";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 80;
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
            this.Name = "MerchantProducts";
            this.Text = "Merchant Products Management";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.splitterMain.Panel1.ResumeLayout(false);
            this.splitterMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitterMain)).EndInit();
            this.splitterMain.ResumeLayout(false);
            this.pnlInputForm.ResumeLayout(false);
            this.grpFoodOptions.ResumeLayout(false);
            this.grpProductInfo.ResumeLayout(false);
            this.grpProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SplitContainer splitterMain;
        private System.Windows.Forms.Panel pnlInputForm;
        private System.Windows.Forms.GroupBox grpProductInfo;
        private System.Windows.Forms.GroupBox grpFoodOptions;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox picProductImage;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.FlowLayoutPanel pnlFoodOptionsContainer;
        private System.Windows.Forms.Button btnAddFoodOption;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFoodOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImage;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}