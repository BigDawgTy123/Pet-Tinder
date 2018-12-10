namespace WindowsFormsApp1
{
    partial class Lizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lizard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lizard_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.age_combo = new System.Windows.Forms.ComboBox();
            this.breed_combo = new System.Windows.Forms.ComboBox();
            this.weight_combo = new System.Windows.Forms.ComboBox();
            this.gender_combo = new System.Windows.Forms.ComboBox();
            this.personality_combo = new System.Windows.Forms.ComboBox();
            this.preffered_temp_combo = new System.Windows.Forms.ComboBox();
            this.food_type = new System.Windows.Forms.ComboBox();
            this.lizard_submit = new System.Windows.Forms.Button();
            this.lizard_back_button = new System.Windows.Forms.Button();
            this.name_text = new System.Windows.Forms.TextBox();
            this.l_name_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 620);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lizard_label
            // 
            this.lizard_label.AutoSize = true;
            this.lizard_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.lizard_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.lizard_label.ForeColor = System.Drawing.SystemColors.Control;
            this.lizard_label.Location = new System.Drawing.Point(138, 55);
            this.lizard_label.Name = "lizard_label";
            this.lizard_label.Size = new System.Drawing.Size(151, 54);
            this.lizard_label.TabIndex = 1;
            this.lizard_label.Text = "Lizard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(98, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(98, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Breed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(98, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Weight:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(98, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gender:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(98, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Personality:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(98, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Preffered Temp:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(98, 460);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Food Type:";
            // 
            // age_combo
            // 
            this.age_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.age_combo.FormattingEnabled = true;
            this.age_combo.Items.AddRange(new object[] {
            "     1",
            "     2",
            "     3",
            "     4",
            "     5",
            "     6",
            "     7",
            "     8",
            "     9",
            "10 - 15",
            "16 - 20",
            "21 - 25",
            "26 - 30",
            "31 - 35",
            "36 - 40",
            "41 - 45",
            "46 - 50"});
            this.age_combo.Location = new System.Drawing.Point(158, 206);
            this.age_combo.Name = "age_combo";
            this.age_combo.Size = new System.Drawing.Size(83, 33);
            this.age_combo.TabIndex = 11;
            // 
            // breed_combo
            // 
            this.breed_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.breed_combo.FormattingEnabled = true;
            this.breed_combo.Items.AddRange(new object[] {
            "Beaded Lizard",
            "Carolina Anole",
            "Chameleon",
            "Chuckwalla",
            "Basilisk",
            "Desert Iguana",
            "Frill-Necked",
            "Gecko",
            "Gila Monster",
            "Green Iguana",
            "Komodo Dragon",
            "Leopard Lizard",
            "Thorny Devil"});
            this.breed_combo.Location = new System.Drawing.Point(174, 245);
            this.breed_combo.Name = "breed_combo";
            this.breed_combo.Size = new System.Drawing.Size(173, 33);
            this.breed_combo.TabIndex = 12;
            // 
            // weight_combo
            // 
            this.weight_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.weight_combo.FormattingEnabled = true;
            this.weight_combo.Items.AddRange(new object[] {
            "1 - 5 LBS",
            "6 - 10 LBS",
            "11 - 20 LBS",
            "21 - 100 LBS",
            "101 - 150 LBS",
            "151 - 200 LBS",
            "+200 LBS"});
            this.weight_combo.Location = new System.Drawing.Point(184, 287);
            this.weight_combo.Name = "weight_combo";
            this.weight_combo.Size = new System.Drawing.Size(99, 33);
            this.weight_combo.TabIndex = 13;
            // 
            // gender_combo
            // 
            this.gender_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gender_combo.FormattingEnabled = true;
            this.gender_combo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_combo.Location = new System.Drawing.Point(187, 329);
            this.gender_combo.Name = "gender_combo";
            this.gender_combo.Size = new System.Drawing.Size(96, 33);
            this.gender_combo.TabIndex = 14;
            // 
            // personality_combo
            // 
            this.personality_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.personality_combo.FormattingEnabled = true;
            this.personality_combo.Items.AddRange(new object[] {
            "Shy/Timid",
            "Agressive",
            "Dosile",
            "Heat-Lovin",
            "Jealous",
            "Friendly"});
            this.personality_combo.Location = new System.Drawing.Point(218, 370);
            this.personality_combo.Name = "personality_combo";
            this.personality_combo.Size = new System.Drawing.Size(163, 33);
            this.personality_combo.TabIndex = 15;
            // 
            // preffered_temp_combo
            // 
            this.preffered_temp_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.preffered_temp_combo.FormattingEnabled = true;
            this.preffered_temp_combo.Items.AddRange(new object[] {
            "65 - 70",
            "71 - 75",
            "76 - 80",
            "81 - 85",
            "85 - 90",
            "90 - 100"});
            this.preffered_temp_combo.Location = new System.Drawing.Point(257, 413);
            this.preffered_temp_combo.Name = "preffered_temp_combo";
            this.preffered_temp_combo.Size = new System.Drawing.Size(101, 33);
            this.preffered_temp_combo.TabIndex = 16;
            // 
            // food_type
            // 
            this.food_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.food_type.FormattingEnabled = true;
            this.food_type.Items.AddRange(new object[] {
            "Herbivore",
            "Carnivore",
            "Omnivore"});
            this.food_type.Location = new System.Drawing.Point(217, 457);
            this.food_type.Name = "food_type";
            this.food_type.Size = new System.Drawing.Size(141, 33);
            this.food_type.TabIndex = 17;
            this.food_type.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // lizard_submit
            // 
            this.lizard_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.lizard_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lizard_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.lizard_submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lizard_submit.Location = new System.Drawing.Point(147, 552);
            this.lizard_submit.Name = "lizard_submit";
            this.lizard_submit.Size = new System.Drawing.Size(126, 49);
            this.lizard_submit.TabIndex = 18;
            this.lizard_submit.Text = "SUBMIT";
            this.lizard_submit.UseVisualStyleBackColor = false;
            this.lizard_submit.Click += new System.EventHandler(this.lizard_submit_Click);
            // 
            // lizard_back_button
            // 
            this.lizard_back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.lizard_back_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lizard_back_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lizard_back_button.Location = new System.Drawing.Point(2, 590);
            this.lizard_back_button.Name = "lizard_back_button";
            this.lizard_back_button.Size = new System.Drawing.Size(75, 23);
            this.lizard_back_button.TabIndex = 19;
            this.lizard_back_button.Text = "<<< Back";
            this.lizard_back_button.UseVisualStyleBackColor = false;
            this.lizard_back_button.Click += new System.EventHandler(this.lizard_back_button_Click);
            // 
            // name_text
            // 
            this.name_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.name_text.Location = new System.Drawing.Point(174, 166);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(212, 30);
            this.name_text.TabIndex = 10;
            // 
            // l_name_label
            // 
            this.l_name_label.AutoSize = true;
            this.l_name_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.l_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.l_name_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.l_name_label.Location = new System.Drawing.Point(98, 169);
            this.l_name_label.Name = "l_name_label";
            this.l_name_label.Size = new System.Drawing.Size(70, 25);
            this.l_name_label.TabIndex = 2;
            this.l_name_label.Text = "Name:";
            this.l_name_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 615);
            this.Controls.Add(this.lizard_back_button);
            this.Controls.Add(this.lizard_submit);
            this.Controls.Add(this.food_type);
            this.Controls.Add(this.preffered_temp_combo);
            this.Controls.Add(this.personality_combo);
            this.Controls.Add(this.gender_combo);
            this.Controls.Add(this.weight_combo);
            this.Controls.Add(this.breed_combo);
            this.Controls.Add(this.age_combo);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l_name_label);
            this.Controls.Add(this.lizard_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Lizard";
            this.Text = "Lizard Info Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lizard_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox age_combo;
        private System.Windows.Forms.ComboBox breed_combo;
        private System.Windows.Forms.ComboBox weight_combo;
        private System.Windows.Forms.ComboBox gender_combo;
        private System.Windows.Forms.ComboBox personality_combo;
        private System.Windows.Forms.ComboBox preffered_temp_combo;
        private System.Windows.Forms.ComboBox food_type;
        private System.Windows.Forms.Button lizard_submit;
        private System.Windows.Forms.Button lizard_back_button;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.Label l_name_label;
    }
}