namespace LogIn1
{
    partial class restaurantMenuTrial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.btnView = new System.Windows.Forms.Button();
            this.lblRestoName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(97, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 485);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblRestoName);
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Controls.Add(this.pictureLogo);
            this.panel2.Location = new System.Drawing.Point(250, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 405);
            this.panel2.TabIndex = 0;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Location = new System.Drawing.Point(52, 48);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(167, 277);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(83, 342);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(103, 38);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblRestoName
            // 
            this.lblRestoName.AutoSize = true;
            this.lblRestoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestoName.Location = new System.Drawing.Point(58, 16);
            this.lblRestoName.Name = "lblRestoName";
            this.lblRestoName.Size = new System.Drawing.Size(0, 25);
            this.lblRestoName.TabIndex = 2;
            // 
            // restaurantMenuTrial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 693);
            this.Controls.Add(this.panel1);
            this.Name = "restaurantMenuTrial";
            this.Text = "restaurantMenuTrial";
            this.Load += new System.EventHandler(this.restaurantMenuTrial_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label lblRestoName;
    }
}