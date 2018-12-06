namespace WindowsFormsApp1
{
    partial class Intermediate_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intermediate_page));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.new_pet_button = new System.Windows.Forms.Button();
            this.list_current_pets_button = new System.Windows.Forms.Button();
            this.intermed_back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 618);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // new_pet_button
            // 
            this.new_pet_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.new_pet_button.FlatAppearance.BorderSize = 0;
            this.new_pet_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.new_pet_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.new_pet_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.new_pet_button.Location = new System.Drawing.Point(153, 224);
            this.new_pet_button.Name = "new_pet_button";
            this.new_pet_button.Size = new System.Drawing.Size(200, 49);
            this.new_pet_button.TabIndex = 1;
            this.new_pet_button.Text = "New Pet";
            this.new_pet_button.UseVisualStyleBackColor = false;
            this.new_pet_button.Click += new System.EventHandler(this.new_pet_button_Click);
            // 
            // list_current_pets_button
            // 
            this.list_current_pets_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.list_current_pets_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.list_current_pets_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.list_current_pets_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.list_current_pets_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.list_current_pets_button.Location = new System.Drawing.Point(154, 309);
            this.list_current_pets_button.Name = "list_current_pets_button";
            this.list_current_pets_button.Size = new System.Drawing.Size(200, 49);
            this.list_current_pets_button.TabIndex = 2;
            this.list_current_pets_button.Text = "Current Pets";
            this.list_current_pets_button.UseVisualStyleBackColor = false;
            this.list_current_pets_button.Click += new System.EventHandler(this.list_current_pets_button_Click);
            // 
            // intermed_back_button
            // 
            this.intermed_back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.intermed_back_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.intermed_back_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.intermed_back_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.intermed_back_button.Location = new System.Drawing.Point(2, 589);
            this.intermed_back_button.Name = "intermed_back_button";
            this.intermed_back_button.Size = new System.Drawing.Size(75, 23);
            this.intermed_back_button.TabIndex = 3;
            this.intermed_back_button.Text = "<<< Back";
            this.intermed_back_button.UseVisualStyleBackColor = false;
            this.intermed_back_button.Click += new System.EventHandler(this.intermed_back_button_Click);
            // 
            // Intermediate_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 615);
            this.Controls.Add(this.intermed_back_button);
            this.Controls.Add(this.list_current_pets_button);
            this.Controls.Add(this.new_pet_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Intermediate_page";
            this.Text = "Intermediate_page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button new_pet_button;
        private System.Windows.Forms.Button list_current_pets_button;
        private System.Windows.Forms.Button intermed_back_button;
    }
}