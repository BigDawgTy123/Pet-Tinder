namespace WindowsFormsApp1
{
    partial class Welcome_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_Screen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buyerButton = new System.Windows.Forms.Button();
            this.sellerButton = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 615);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buyerButton
            // 
            this.buyerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.buyerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buyerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyerButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buyerButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buyerButton.Location = new System.Drawing.Point(176, 233);
            this.buyerButton.Name = "buyerButton";
            this.buyerButton.Size = new System.Drawing.Size(168, 41);
            this.buyerButton.TabIndex = 1;
            this.buyerButton.Text = "Buying";
            this.buyerButton.UseVisualStyleBackColor = false;
            this.buyerButton.Click += new System.EventHandler(this.buyerButton_Click);
            // 
            // sellerButton
            // 
            this.sellerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.sellerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sellerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.sellerButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sellerButton.Location = new System.Drawing.Point(176, 303);
            this.sellerButton.Name = "sellerButton";
            this.sellerButton.Size = new System.Drawing.Size(168, 41);
            this.sellerButton.TabIndex = 2;
            this.sellerButton.Text = "Selling";
            this.sellerButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sellerButton.UseVisualStyleBackColor = false;
            this.sellerButton.Click += new System.EventHandler(this.sellerButton_Click);
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.close_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close_button.Location = new System.Drawing.Point(180, 525);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(126, 49);
            this.close_button.TabIndex = 3;
            this.close_button.Text = "CLOSE";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Welcome_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 615);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.sellerButton);
            this.Controls.Add(this.buyerButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Welcome_Screen";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buyerButton;
        private System.Windows.Forms.Button sellerButton;
        private System.Windows.Forms.Button close_button;
    }
}

