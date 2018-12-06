namespace WindowsFormsApp1
{
    partial class Dog_results
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dog_results));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back_button = new System.Windows.Forms.Button();
            this.dog_results_no_button = new System.Windows.Forms.Button();
            this.cat_results_yes_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dog_results_name_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dog_results_age_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dog_results_gender_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dog_results_weight_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dog_results_personality_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dog_results_breed_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 618);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back_button.Location = new System.Drawing.Point(2, 590);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 1;
            this.back_button.Text = "<<< Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // dog_results_no_button
            // 
            this.dog_results_no_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.dog_results_no_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dog_results_no_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dog_results_no_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dog_results_no_button.Location = new System.Drawing.Point(111, 567);
            this.dog_results_no_button.Name = "dog_results_no_button";
            this.dog_results_no_button.Size = new System.Drawing.Size(114, 41);
            this.dog_results_no_button.TabIndex = 2;
            this.dog_results_no_button.Text = "NO";
            this.dog_results_no_button.UseVisualStyleBackColor = false;
            this.dog_results_no_button.Click += new System.EventHandler(this.dog_results_no_button_Click);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dog_results_name_textbox
            // 
            this.dog_results_name_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dog_results_name_textbox.Location = new System.Drawing.Point(182, 219);
            this.dog_results_name_textbox.Name = "dog_results_name_textbox";
            this.dog_results_name_textbox.Size = new System.Drawing.Size(172, 30);
            this.dog_results_name_textbox.TabIndex = 5;
            this.dog_results_name_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(111, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age:";
            // 
            // dog_results_age_textbox
            // 
            this.dog_results_age_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dog_results_age_textbox.Location = new System.Drawing.Point(173, 327);
            this.dog_results_age_textbox.Name = "dog_results_age_textbox";
            this.dog_results_age_textbox.Size = new System.Drawing.Size(95, 30);
            this.dog_results_age_textbox.TabIndex = 7;
            this.dog_results_age_textbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(110, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gender:";
            // 
            // dog_results_gender_textbox
            // 
            this.dog_results_gender_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dog_results_gender_textbox.Location = new System.Drawing.Point(199, 381);
            this.dog_results_gender_textbox.Name = "dog_results_gender_textbox";
            this.dog_results_gender_textbox.Size = new System.Drawing.Size(124, 30);
            this.dog_results_gender_textbox.TabIndex = 9;
            this.dog_results_gender_textbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(113, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Weight:";
            // 
            // dog_results_weight_textbox
            // 
            this.dog_results_weight_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dog_results_weight_textbox.Location = new System.Drawing.Point(199, 448);
            this.dog_results_weight_textbox.Name = "dog_results_weight_textbox";
            this.dog_results_weight_textbox.Size = new System.Drawing.Size(124, 30);
            this.dog_results_weight_textbox.TabIndex = 11;
            this.dog_results_weight_textbox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(113, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Personality:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dog_results_personality_textbox
            // 
            this.dog_results_personality_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dog_results_personality_textbox.Location = new System.Drawing.Point(233, 509);
            this.dog_results_personality_textbox.Name = "dog_results_personality_textbox";
            this.dog_results_personality_textbox.Size = new System.Drawing.Size(124, 30);
            this.dog_results_personality_textbox.TabIndex = 13;
            this.dog_results_personality_textbox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(106, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Breed:";
            // 
            // dog_results_breed_textbox
            // 
            this.dog_results_breed_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dog_results_breed_textbox.Location = new System.Drawing.Point(182, 270);
            this.dog_results_breed_textbox.Name = "dog_results_breed_textbox";
            this.dog_results_breed_textbox.Size = new System.Drawing.Size(172, 30);
            this.dog_results_breed_textbox.TabIndex = 15;
            this.dog_results_breed_textbox.TextChanged += new System.EventHandler(this.dog_results_breed_textbox_TextChanged);
            // 
            // Dog_results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 615);
            this.Controls.Add(this.dog_results_breed_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dog_results_personality_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dog_results_weight_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dog_results_gender_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dog_results_age_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dog_results_name_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cat_results_yes_button);
            this.Controls.Add(this.dog_results_no_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dog_results";
            this.Text = "Dog_results";
            this.Load += new System.EventHandler(this.Dog_results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button dog_results_no_button;
        private System.Windows.Forms.Button cat_results_yes_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dog_results_name_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dog_results_age_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dog_results_gender_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dog_results_weight_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dog_results_personality_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dog_results_breed_textbox;
    }
}