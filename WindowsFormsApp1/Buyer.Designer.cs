namespace WindowsFormsApp1
{
    partial class Buyer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buyer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buyer_back_button = new System.Windows.Forms.Button();
            this.to_buying_dog_page = new System.Windows.Forms.Button();
            this.to_buying_cat_page = new System.Windows.Forms.Button();
            this.to_buying_lizard_page = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 620);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(33, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "What are you looking for?";
            // 
            // buyer_back_button
            // 
            this.buyer_back_button.Location = new System.Drawing.Point(2, 589);
            this.buyer_back_button.Name = "buyer_back_button";
            this.buyer_back_button.Size = new System.Drawing.Size(75, 23);
            this.buyer_back_button.TabIndex = 3;
            this.buyer_back_button.Text = "<<< Back";
            this.buyer_back_button.UseVisualStyleBackColor = true;
            this.buyer_back_button.Click += new System.EventHandler(this.buyer_back_button_Click);
            // 
            // to_buying_dog_page
            // 
            this.to_buying_dog_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.to_buying_dog_page.Location = new System.Drawing.Point(180, 227);
            this.to_buying_dog_page.Name = "to_buying_dog_page";
            this.to_buying_dog_page.Size = new System.Drawing.Size(119, 42);
            this.to_buying_dog_page.TabIndex = 4;
            this.to_buying_dog_page.Text = "Dog";
            this.to_buying_dog_page.UseVisualStyleBackColor = true;
            this.to_buying_dog_page.Click += new System.EventHandler(this.button1_Click);
            // 
            // to_buying_cat_page
            // 
            this.to_buying_cat_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.to_buying_cat_page.Location = new System.Drawing.Point(180, 312);
            this.to_buying_cat_page.Name = "to_buying_cat_page";
            this.to_buying_cat_page.Size = new System.Drawing.Size(119, 42);
            this.to_buying_cat_page.TabIndex = 5;
            this.to_buying_cat_page.Text = "Cat";
            this.to_buying_cat_page.UseVisualStyleBackColor = true;
            this.to_buying_cat_page.Click += new System.EventHandler(this.to_buying_cat_page_Click);
            // 
            // to_buying_lizard_page
            // 
            this.to_buying_lizard_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.to_buying_lizard_page.Location = new System.Drawing.Point(180, 399);
            this.to_buying_lizard_page.Name = "to_buying_lizard_page";
            this.to_buying_lizard_page.Size = new System.Drawing.Size(119, 42);
            this.to_buying_lizard_page.TabIndex = 6;
            this.to_buying_lizard_page.Text = "Lizard";
            this.to_buying_lizard_page.UseVisualStyleBackColor = true;
            this.to_buying_lizard_page.Click += new System.EventHandler(this.to_buying_lizard_page_Click);
            // 
            // Buyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 615);
            this.Controls.Add(this.to_buying_lizard_page);
            this.Controls.Add(this.to_buying_cat_page);
            this.Controls.Add(this.to_buying_dog_page);
            this.Controls.Add(this.buyer_back_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Buyer";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buyer_back_button;
        private System.Windows.Forms.Button to_buying_dog_page;
        private System.Windows.Forms.Button to_buying_cat_page;
        private System.Windows.Forms.Button to_buying_lizard_page;
    }
}