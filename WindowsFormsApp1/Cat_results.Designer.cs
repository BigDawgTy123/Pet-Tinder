namespace WindowsFormsApp1
{
    partial class Cat_results
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cat_results));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back_button = new System.Windows.Forms.Button();
            this.cat_results_no_button = new System.Windows.Forms.Button();
            this.cat_results_yes_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cat_results_name_textbox = new System.Windows.Forms.TextBox();
            this.cat_results_breed_textbox = new System.Windows.Forms.TextBox();
            this.cat_results_age_textbox = new System.Windows.Forms.TextBox();
            this.cat_results_gender_textbox = new System.Windows.Forms.TextBox();
            this.cat_results_weight_textbox = new System.Windows.Forms.TextBox();
            this.cat_results_personality_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 618);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.back_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back_button.Location = new System.Drawing.Point(2, 590);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 1;
            this.back_button.Text = "<<< Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // cat_results_no_button
            // 
            this.cat_results_no_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.cat_results_no_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cat_results_no_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cat_results_no_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cat_results_no_button.Location = new System.Drawing.Point(111, 567);
            this.cat_results_no_button.Name = "cat_results_no_button";
            this.cat_results_no_button.Size = new System.Drawing.Size(114, 41);
            this.cat_results_no_button.TabIndex = 2;
            this.cat_results_no_button.Text = "NO";
            this.cat_results_no_button.UseVisualStyleBackColor = false;
            this.cat_results_no_button.Click += new System.EventHandler(this.cat_results_no_button_Click);
            // 
            // cat_results_yes_button
            // 
            this.cat_results_yes_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.cat_results_yes_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cat_results_yes_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cat_results_yes_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cat_results_yes_button.Location = new System.Drawing.Point(245, 567);
            this.cat_results_yes_button.Name = "cat_results_yes_button";
            this.cat_results_yes_button.Size = new System.Drawing.Size(114, 41);
            this.cat_results_yes_button.TabIndex = 3;
            this.cat_results_yes_button.Text = "YES";
            this.cat_results_yes_button.UseVisualStyleBackColor = false;
            this.cat_results_yes_button.Click += new System.EventHandler(this.cat_results_yes_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(106, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(106, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Breed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(111, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(110, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(113, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Weight:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(113, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Personality:";
            // 
            // cat_results_name_textbox
            // 
            this.cat_results_name_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cat_results_name_textbox.Location = new System.Drawing.Point(182, 219);
            this.cat_results_name_textbox.Name = "cat_results_name_textbox";
            this.cat_results_name_textbox.Size = new System.Drawing.Size(172, 30);
            this.cat_results_name_textbox.TabIndex = 10;
            this.cat_results_name_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cat_results_breed_textbox
            // 
            this.cat_results_breed_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cat_results_breed_textbox.Location = new System.Drawing.Point(182, 270);
            this.cat_results_breed_textbox.Name = "cat_results_breed_textbox";
            this.cat_results_breed_textbox.Size = new System.Drawing.Size(172, 30);
            this.cat_results_breed_textbox.TabIndex = 11;
            this.cat_results_breed_textbox.TextChanged += new System.EventHandler(this.cat_results_breed_textbox_TextChanged);
            // 
            // cat_results_age_textbox
            // 
            this.cat_results_age_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cat_results_age_textbox.Location = new System.Drawing.Point(173, 327);
            this.cat_results_age_textbox.Name = "cat_results_age_textbox";
            this.cat_results_age_textbox.Size = new System.Drawing.Size(95, 30);
            this.cat_results_age_textbox.TabIndex = 12;
            this.cat_results_age_textbox.TextChanged += new System.EventHandler(this.cat_results_age_textbox_TextChanged);
            // 
            // cat_results_gender_textbox
            // 
            this.cat_results_gender_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cat_results_gender_textbox.Location = new System.Drawing.Point(199, 381);
            this.cat_results_gender_textbox.Name = "cat_results_gender_textbox";
            this.cat_results_gender_textbox.Size = new System.Drawing.Size(124, 30);
            this.cat_results_gender_textbox.TabIndex = 13;
            this.cat_results_gender_textbox.TextChanged += new System.EventHandler(this.cat_results_gender_textbox_TextChanged);
            // 
            // cat_results_weight_textbox
            // 
            this.cat_results_weight_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cat_results_weight_textbox.Location = new System.Drawing.Point(199, 448);
            this.cat_results_weight_textbox.Name = "cat_results_weight_textbox";
            this.cat_results_weight_textbox.Size = new System.Drawing.Size(124, 30);
            this.cat_results_weight_textbox.TabIndex = 14;
            this.cat_results_weight_textbox.TextChanged += new System.EventHandler(this.cat_results_weight_textbox_TextChanged);
            // 
            // cat_results_personality_textbox
            // 
            this.cat_results_personality_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cat_results_personality_textbox.Location = new System.Drawing.Point(233, 509);
            this.cat_results_personality_textbox.Name = "cat_results_personality_textbox";
            this.cat_results_personality_textbox.Size = new System.Drawing.Size(124, 30);
            this.cat_results_personality_textbox.TabIndex = 15;
            this.cat_results_personality_textbox.TextChanged += new System.EventHandler(this.cat_results_personality_textbox_TextChanged);
            // 
            // Cat_results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 615);
            this.Controls.Add(this.cat_results_personality_textbox);
            this.Controls.Add(this.cat_results_weight_textbox);
            this.Controls.Add(this.cat_results_gender_textbox);
            this.Controls.Add(this.cat_results_age_textbox);
            this.Controls.Add(this.cat_results_breed_textbox);
            this.Controls.Add(this.cat_results_name_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cat_results_yes_button);
            this.Controls.Add(this.cat_results_no_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Cat_results";
            this.Text = "Cat_results";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button cat_results_no_button;
        private System.Windows.Forms.Button cat_results_yes_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cat_results_name_textbox;
        private System.Windows.Forms.TextBox cat_results_breed_textbox;
        private System.Windows.Forms.TextBox cat_results_age_textbox;
        private System.Windows.Forms.TextBox cat_results_gender_textbox;
        private System.Windows.Forms.TextBox cat_results_weight_textbox;
        private System.Windows.Forms.TextBox cat_results_personality_textbox;
    }
}