namespace WindowsFormsApp1
{
    partial class Seller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seller));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dog_button = new System.Windows.Forms.Button();
            this.cat_button = new System.Windows.Forms.Button();
            this.lizard_button = new System.Windows.Forms.Button();
            this.buyer_back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 622);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dog_button
            // 
            this.dog_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.dog_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dog_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.dog_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dog_button.Location = new System.Drawing.Point(154, 226);
            this.dog_button.Name = "dog_button";
            this.dog_button.Size = new System.Drawing.Size(203, 47);
            this.dog_button.TabIndex = 1;
            this.dog_button.Text = "Dog";
            this.dog_button.UseVisualStyleBackColor = false;
            this.dog_button.Click += new System.EventHandler(this.dog_button_Click);
            // 
            // cat_button
            // 
            this.cat_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.cat_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cat_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.cat_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cat_button.Location = new System.Drawing.Point(155, 311);
            this.cat_button.Name = "cat_button";
            this.cat_button.Size = new System.Drawing.Size(203, 47);
            this.cat_button.TabIndex = 2;
            this.cat_button.Text = "Cat";
            this.cat_button.UseVisualStyleBackColor = false;
            this.cat_button.Click += new System.EventHandler(this.cat_button_Click);
            // 
            // lizard_button
            // 
            this.lizard_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.lizard_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lizard_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.lizard_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lizard_button.Location = new System.Drawing.Point(154, 398);
            this.lizard_button.Name = "lizard_button";
            this.lizard_button.Size = new System.Drawing.Size(203, 47);
            this.lizard_button.TabIndex = 3;
            this.lizard_button.Text = "Lizard";
            this.lizard_button.UseVisualStyleBackColor = false;
            this.lizard_button.Click += new System.EventHandler(this.lizard_button_Click);
            // 
            // buyer_back_button
            // 
            this.buyer_back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.buyer_back_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buyer_back_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buyer_back_button.Location = new System.Drawing.Point(2, 587);
            this.buyer_back_button.Name = "buyer_back_button";
            this.buyer_back_button.Size = new System.Drawing.Size(75, 23);
            this.buyer_back_button.TabIndex = 4;
            this.buyer_back_button.Text = "<<< Back";
            this.buyer_back_button.UseVisualStyleBackColor = false;
            this.buyer_back_button.Click += new System.EventHandler(this.buyer_back_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "What Type of Animal?";
            this.label1.UseMnemonic = false;
            // 
            // Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 615);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buyer_back_button);
            this.Controls.Add(this.lizard_button);
            this.Controls.Add(this.cat_button);
            this.Controls.Add(this.dog_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Seller";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dog_button;
        private System.Windows.Forms.Button cat_button;
        private System.Windows.Forms.Button lizard_button;
        private System.Windows.Forms.Button buyer_back_button;
        private System.Windows.Forms.Label label1;
    }
}