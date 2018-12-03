namespace WindowsFormsApp1
{
    partial class Dog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dog));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.breed_label = new System.Windows.Forms.Label();
            this.weight_label = new System.Windows.Forms.Label();
            this.gender_label = new System.Windows.Forms.Label();
            this.personality_label = new System.Windows.Forms.Label();
            this.playfulness_label = new System.Windows.Forms.Label();
            this.shedding_label = new System.Windows.Forms.Label();
            this.age_combo = new System.Windows.Forms.ComboBox();
            this.breed_combo = new System.Windows.Forms.ComboBox();
            this.weight_combo = new System.Windows.Forms.ComboBox();
            this.gender_combo = new System.Windows.Forms.ComboBox();
            this.personality_combo = new System.Windows.Forms.ComboBox();
            this.playfulness_combo = new System.Windows.Forms.ComboBox();
            this.shedding_combo = new System.Windows.Forms.ComboBox();
            this.dog_submit = new System.Windows.Forms.Button();
            this.dog_back_button = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(167, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dog";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.age_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.age_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.age_label.Location = new System.Drawing.Point(98, 210);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(54, 25);
            this.age_label.TabIndex = 3;
            this.age_label.Text = "Age:";
            // 
            // breed_label
            // 
            this.breed_label.AutoSize = true;
            this.breed_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.breed_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.breed_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.breed_label.Location = new System.Drawing.Point(98, 251);
            this.breed_label.Name = "breed_label";
            this.breed_label.Size = new System.Drawing.Size(70, 25);
            this.breed_label.TabIndex = 4;
            this.breed_label.Text = "Breed:";
            // 
            // weight_label
            // 
            this.weight_label.AutoSize = true;
            this.weight_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.weight_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.weight_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.weight_label.Location = new System.Drawing.Point(98, 295);
            this.weight_label.Name = "weight_label";
            this.weight_label.Size = new System.Drawing.Size(80, 25);
            this.weight_label.TabIndex = 5;
            this.weight_label.Text = "Weight:";
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.gender_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gender_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gender_label.Location = new System.Drawing.Point(98, 339);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(83, 25);
            this.gender_label.TabIndex = 6;
            this.gender_label.Text = "Gender:";
            // 
            // personality_label
            // 
            this.personality_label.AutoSize = true;
            this.personality_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.personality_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.personality_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.personality_label.Location = new System.Drawing.Point(98, 381);
            this.personality_label.Name = "personality_label";
            this.personality_label.Size = new System.Drawing.Size(114, 25);
            this.personality_label.TabIndex = 7;
            this.personality_label.Text = "Personality:";
            // 
            // playfulness_label
            // 
            this.playfulness_label.AutoSize = true;
            this.playfulness_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.playfulness_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.playfulness_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playfulness_label.Location = new System.Drawing.Point(98, 428);
            this.playfulness_label.Name = "playfulness_label";
            this.playfulness_label.Size = new System.Drawing.Size(118, 25);
            this.playfulness_label.TabIndex = 8;
            this.playfulness_label.Text = "Playfulness:";
            // 
            // shedding_label
            // 
            this.shedding_label.AutoSize = true;
            this.shedding_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.shedding_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.shedding_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.shedding_label.Location = new System.Drawing.Point(98, 472);
            this.shedding_label.Name = "shedding_label";
            this.shedding_label.Size = new System.Drawing.Size(102, 25);
            this.shedding_label.TabIndex = 9;
            this.shedding_label.Text = "Shedding:";
            // 
            // age_combo
            // 
            this.age_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_combo.FormattingEnabled = true;
            this.age_combo.Items.AddRange(new object[] {
            "   1",
            "   2",
            "   3",
            "   4",
            "   5",
            "   6",
            "   7",
            "   8",
            "   9",
            "   10",
            "   11",
            "   12",
            "   13",
            "   14",
            "   15",
            "   16"});
            this.age_combo.Location = new System.Drawing.Point(160, 206);
            this.age_combo.Name = "age_combo";
            this.age_combo.Size = new System.Drawing.Size(70, 33);
            this.age_combo.TabIndex = 11;
            // 
            // breed_combo
            // 
            this.breed_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breed_combo.FormattingEnabled = true;
            this.breed_combo.Items.AddRange(new object[] {
            "Austrialian Shepherd",
            "Border Collie",
            "Beagle",
            "Poodle",
            "German Shepherd",
            "Bulldog",
            "Labrador Retriever",
            "Rottweilers",
            "Yorkshire Terrier",
            "Pointer",
            "Boxer",
            "Siberian Huskie",
            "Dachshund",
            "Great Danes",
            "Corgis",
            "Doberman Pinscher"});
            this.breed_combo.Location = new System.Drawing.Point(174, 248);
            this.breed_combo.Name = "breed_combo";
            this.breed_combo.Size = new System.Drawing.Size(221, 33);
            this.breed_combo.TabIndex = 13;
            // 
            // weight_combo
            // 
            this.weight_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_combo.FormattingEnabled = true;
            this.weight_combo.Items.AddRange(new object[] {
            "1 - 10 LBS",
            "11 - 30 LBS",
            "31 - 50 LBS",
            "51 - 70 LBS",
            "71 - 90 LBS",
            "91 - 110 LBS",
            "111 - 150 LBS",
            "+151 LBS"});
            this.weight_combo.Location = new System.Drawing.Point(184, 292);
            this.weight_combo.Name = "weight_combo";
            this.weight_combo.Size = new System.Drawing.Size(144, 33);
            this.weight_combo.TabIndex = 14;
            // 
            // gender_combo
            // 
            this.gender_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_combo.FormattingEnabled = true;
            this.gender_combo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_combo.Location = new System.Drawing.Point(187, 336);
            this.gender_combo.Name = "gender_combo";
            this.gender_combo.Size = new System.Drawing.Size(89, 33);
            this.gender_combo.TabIndex = 15;
            // 
            // personality_combo
            // 
            this.personality_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personality_combo.FormattingEnabled = true;
            this.personality_combo.Items.AddRange(new object[] {
            "Confident",
            "Shy/Timid",
            "Independent",
            "Laidback",
            "Adaptable"});
            this.personality_combo.Location = new System.Drawing.Point(218, 377);
            this.personality_combo.Name = "personality_combo";
            this.personality_combo.Size = new System.Drawing.Size(144, 33);
            this.personality_combo.TabIndex = 16;
            // 
            // playfulness_combo
            // 
            this.playfulness_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playfulness_combo.FormattingEnabled = true;
            this.playfulness_combo.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Spastic"});
            this.playfulness_combo.Location = new System.Drawing.Point(222, 425);
            this.playfulness_combo.Name = "playfulness_combo";
            this.playfulness_combo.Size = new System.Drawing.Size(140, 33);
            this.playfulness_combo.TabIndex = 17;
            // 
            // shedding_combo
            // 
            this.shedding_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.shedding_combo.FormattingEnabled = true;
            this.shedding_combo.Items.AddRange(new object[] {
            "Hypoallergenic",
            "Low",
            "Medium",
            "High"});
            this.shedding_combo.Location = new System.Drawing.Point(206, 469);
            this.shedding_combo.Name = "shedding_combo";
            this.shedding_combo.Size = new System.Drawing.Size(156, 33);
            this.shedding_combo.TabIndex = 18;
            // 
            // dog_submit
            // 
            this.dog_submit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dog_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.dog_submit.Location = new System.Drawing.Point(134, 543);
            this.dog_submit.Name = "dog_submit";
            this.dog_submit.Size = new System.Drawing.Size(126, 49);
            this.dog_submit.TabIndex = 19;
            this.dog_submit.Text = "SUBMIT";
            this.dog_submit.UseVisualStyleBackColor = false;
            this.dog_submit.Click += new System.EventHandler(this.dog_submit_Click);
            // 
            // dog_back_button
            // 
            this.dog_back_button.Location = new System.Drawing.Point(2, 590);
            this.dog_back_button.Name = "dog_back_button";
            this.dog_back_button.Size = new System.Drawing.Size(75, 23);
            this.dog_back_button.TabIndex = 20;
            this.dog_back_button.Text = "<<< Back";
            this.dog_back_button.UseVisualStyleBackColor = true;
            this.dog_back_button.Click += new System.EventHandler(this.dog_back_button_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.name_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.name_label.Location = new System.Drawing.Point(98, 169);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(70, 25);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "Name:";
            // 
            // name_text
            // 
            this.name_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_text.Location = new System.Drawing.Point(176, 167);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(219, 30);
            this.name_text.TabIndex = 10;
            // 
            // Dog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 615);
            this.Controls.Add(this.dog_back_button);
            this.Controls.Add(this.dog_submit);
            this.Controls.Add(this.shedding_combo);
            this.Controls.Add(this.playfulness_combo);
            this.Controls.Add(this.personality_combo);
            this.Controls.Add(this.gender_combo);
            this.Controls.Add(this.weight_combo);
            this.Controls.Add(this.breed_combo);
            this.Controls.Add(this.age_combo);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.shedding_label);
            this.Controls.Add(this.playfulness_label);
            this.Controls.Add(this.personality_label);
            this.Controls.Add(this.gender_label);
            this.Controls.Add(this.weight_label);
            this.Controls.Add(this.breed_label);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dog";
            this.Text = "Dog Info Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label breed_label;
        private System.Windows.Forms.Label weight_label;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.Label personality_label;
        private System.Windows.Forms.Label playfulness_label;
        private System.Windows.Forms.Label shedding_label;
        private System.Windows.Forms.ComboBox age_combo;
        private System.Windows.Forms.ComboBox breed_combo;
        private System.Windows.Forms.ComboBox weight_combo;
        private System.Windows.Forms.ComboBox gender_combo;
        private System.Windows.Forms.ComboBox personality_combo;
        private System.Windows.Forms.ComboBox playfulness_combo;
        private System.Windows.Forms.ComboBox shedding_combo;
        private System.Windows.Forms.Button dog_submit;
        private System.Windows.Forms.Button dog_back_button;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_text;
    }
}