namespace WindowsFormsApp1
{
    partial class Seller_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seller_info));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.owner_state_info = new System.Windows.Forms.ComboBox();
            this.owner_email_info = new System.Windows.Forms.TextBox();
            this.owner_phone_info = new System.Windows.Forms.TextBox();
            this.owner_name_info = new System.Windows.Forms.TextBox();
            this.owner_info_submit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.owner_provisions_info = new System.Windows.Forms.ComboBox();
            this.owner_city_info = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 618);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(137, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Owner Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(72, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(72, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(72, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(72, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "State:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(72, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "City:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // owner_state_info
            // 
            this.owner_state_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.owner_state_info.FormattingEnabled = true;
            this.owner_state_info.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virgina",
            "Wisconsin",
            "Wyoming"});
            this.owner_state_info.Location = new System.Drawing.Point(142, 429);
            this.owner_state_info.Name = "owner_state_info";
            this.owner_state_info.Size = new System.Drawing.Size(179, 33);
            this.owner_state_info.TabIndex = 8;
            // 
            // owner_email_info
            // 
            this.owner_email_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.owner_email_info.Location = new System.Drawing.Point(144, 324);
            this.owner_email_info.Name = "owner_email_info";
            this.owner_email_info.Size = new System.Drawing.Size(253, 30);
            this.owner_email_info.TabIndex = 9;
            this.owner_email_info.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // owner_phone_info
            // 
            this.owner_phone_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.owner_phone_info.Location = new System.Drawing.Point(227, 271);
            this.owner_phone_info.Name = "owner_phone_info";
            this.owner_phone_info.Size = new System.Drawing.Size(170, 30);
            this.owner_phone_info.TabIndex = 11;
            // 
            // owner_name_info
            // 
            this.owner_name_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.owner_name_info.Location = new System.Drawing.Point(148, 218);
            this.owner_name_info.Name = "owner_name_info";
            this.owner_name_info.Size = new System.Drawing.Size(250, 30);
            this.owner_name_info.TabIndex = 12;
            // 
            // owner_info_submit
            // 
            this.owner_info_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.owner_info_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.owner_info_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.owner_info_submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.owner_info_submit.Location = new System.Drawing.Point(166, 534);
            this.owner_info_submit.Name = "owner_info_submit";
            this.owner_info_submit.Size = new System.Drawing.Size(126, 49);
            this.owner_info_submit.TabIndex = 13;
            this.owner_info_submit.Text = "SUBMIT";
            this.owner_info_submit.UseVisualStyleBackColor = false;
            this.owner_info_submit.Click += new System.EventHandler(this.Submit_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(2, 590);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "<<< Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(72, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Animal Provisions:";
            // 
            // owner_provisions_info
            // 
            this.owner_provisions_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.owner_provisions_info.FormattingEnabled = true;
            this.owner_provisions_info.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.owner_provisions_info.Location = new System.Drawing.Point(251, 479);
            this.owner_provisions_info.Name = "owner_provisions_info";
            this.owner_provisions_info.Size = new System.Drawing.Size(62, 33);
            this.owner_provisions_info.TabIndex = 16;
            // 
            // owner_city_info
            // 
            this.owner_city_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.owner_city_info.Location = new System.Drawing.Point(130, 378);
            this.owner_city_info.Name = "owner_city_info";
            this.owner_city_info.Size = new System.Drawing.Size(267, 30);
            this.owner_city_info.TabIndex = 17;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login.Location = new System.Drawing.Point(403, 326);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(58, 27);
            this.Login.TabIndex = 18;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Loigin_click);
            // 
            // Seller_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 615);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.owner_city_info);
            this.Controls.Add(this.owner_provisions_info);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.owner_info_submit);
            this.Controls.Add(this.owner_name_info);
            this.Controls.Add(this.owner_phone_info);
            this.Controls.Add(this.owner_email_info);
            this.Controls.Add(this.owner_state_info);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Seller_info";
            this.Text = "Owner Info";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox owner_state_info;
        private System.Windows.Forms.TextBox owner_email_info;
        private System.Windows.Forms.TextBox owner_phone_info;
        private System.Windows.Forms.TextBox owner_name_info;
        private System.Windows.Forms.Button owner_info_submit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox owner_provisions_info;
        private System.Windows.Forms.TextBox owner_city_info;
        private System.Windows.Forms.Button Login;
    }
}