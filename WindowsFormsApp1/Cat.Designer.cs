namespace WindowsFormsApp1
{
    partial class Cat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cat));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.submit_cat_form = new System.Windows.Forms.Button();
            this.gender_combo = new System.Windows.Forms.ComboBox();
            this.personality_combo = new System.Windows.Forms.ComboBox();
            this.breed_combo = new System.Windows.Forms.ComboBox();
            this.laziness_combo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cat_back_button = new System.Windows.Forms.Button();
            this.name_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(97, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(97, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Breed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(97, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Weight:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(97, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(97, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Laziness:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(97, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Personality:";
            // 
            // submit_cat_form
            // 
            this.submit_cat_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.submit_cat_form.Location = new System.Drawing.Point(151, 549);
            this.submit_cat_form.Name = "submit_cat_form";
            this.submit_cat_form.Size = new System.Drawing.Size(122, 43);
            this.submit_cat_form.TabIndex = 14;
            this.submit_cat_form.Text = "SUBMIT";
            this.submit_cat_form.UseVisualStyleBackColor = true;
            this.submit_cat_form.Click += new System.EventHandler(this.button1_Click);
            // 
            // gender_combo
            // 
            this.gender_combo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gender_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gender_combo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gender_combo.FormattingEnabled = true;
            this.gender_combo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_combo.Location = new System.Drawing.Point(186, 358);
            this.gender_combo.MaxDropDownItems = 2;
            this.gender_combo.MaxLength = 2;
            this.gender_combo.Name = "gender_combo";
            this.gender_combo.Size = new System.Drawing.Size(121, 33);
            this.gender_combo.TabIndex = 15;
            this.gender_combo.SelectedIndexChanged += new System.EventHandler(this.gender_combo_SelectedIndexChanged);
            // 
            // personality_combo
            // 
            this.personality_combo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.personality_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.personality_combo.FormattingEnabled = true;
            this.personality_combo.Items.AddRange(new object[] {
            "Neurotic",
            "Extraverted",
            "Dominant",
            "Impulsive",
            "Agreeable",
            "Affectionate",
            "Shy"});
            this.personality_combo.Location = new System.Drawing.Point(217, 410);
            this.personality_combo.Name = "personality_combo";
            this.personality_combo.Size = new System.Drawing.Size(164, 33);
            this.personality_combo.TabIndex = 16;
            // 
            // breed_combo
            // 
            this.breed_combo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.breed_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.breed_combo.FormattingEnabled = true;
            this.breed_combo.Items.AddRange(new object[] {
            "Domestic Shorthair",
            "Domestic Longhair",
            "Persian",
            "Maine Coon",
            "Siamese",
            "American Shorthair",
            "Abyssinian",
            "Exotic Shorthair",
            "Ragdoll",
            "Burmese",
            "Himalayan",
            "Naked"});
            this.breed_combo.Location = new System.Drawing.Point(173, 261);
            this.breed_combo.Name = "breed_combo";
            this.breed_combo.Size = new System.Drawing.Size(208, 33);
            this.breed_combo.TabIndex = 17;
            this.breed_combo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // laziness_combo
            // 
            this.laziness_combo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.laziness_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.laziness_combo.FormattingEnabled = true;
            this.laziness_combo.Items.AddRange(new object[] {
            "Of Course!",
            "Nope"});
            this.laziness_combo.Location = new System.Drawing.Point(199, 457);
            this.laziness_combo.Name = "laziness_combo";
            this.laziness_combo.Size = new System.Drawing.Size(119, 33);
            this.laziness_combo.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 619);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(166, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 54);
            this.label8.TabIndex = 20;
            this.label8.Text = "Cat";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22"});
            this.comboBox1.Location = new System.Drawing.Point(157, 211);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 33);
            this.comboBox1.TabIndex = 21;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1 - 5 lbs",
            "6 - 10 lbs",
            "11 - 15 lbs",
            "15 - 20 lbs"});
            this.comboBox2.Location = new System.Drawing.Point(183, 310);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(98, 33);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // cat_back_button
            // 
            this.cat_back_button.Location = new System.Drawing.Point(2, 590);
            this.cat_back_button.Name = "cat_back_button";
            this.cat_back_button.Size = new System.Drawing.Size(75, 23);
            this.cat_back_button.TabIndex = 23;
            this.cat_back_button.Text = "<<< Back";
            this.cat_back_button.UseVisualStyleBackColor = true;
            this.cat_back_button.Click += new System.EventHandler(this.cat_back_button_Click);
            // 
            // name_input
            // 
            this.name_input.BackColor = System.Drawing.Color.WhiteSmoke;
            this.name_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.name_input.Location = new System.Drawing.Point(173, 166);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(210, 30);
            this.name_input.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(97, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(475, 615);
            this.Controls.Add(this.cat_back_button);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.laziness_combo);
            this.Controls.Add(this.breed_combo);
            this.Controls.Add(this.personality_combo);
            this.Controls.Add(this.gender_combo);
            this.Controls.Add(this.submit_cat_form);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Cat";
            this.Text = "Cat Info Page";
            this.Load += new System.EventHandler(this.Cat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button submit_cat_form;
        private System.Windows.Forms.ComboBox gender_combo;
        private System.Windows.Forms.ComboBox personality_combo;
        private System.Windows.Forms.ComboBox breed_combo;
        private System.Windows.Forms.ComboBox laziness_combo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button cat_back_button;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label label1;
    }
}