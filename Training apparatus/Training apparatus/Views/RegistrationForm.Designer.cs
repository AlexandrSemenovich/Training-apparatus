namespace Training_apparatus
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.userSexField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.backgroung = new System.Windows.Forms.Panel();
            this.buttonSingin = new System.Windows.Forms.Button();
            this.loginField = new System.Windows.Forms.TextBox();
            this.REGISTRATION = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userSurnameField = new System.Windows.Forms.TextBox();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.Label();
            this.backgroung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // userSexField
            // 
            this.userSexField.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userSexField.Location = new System.Drawing.Point(177, 546);
            this.userSexField.Multiline = true;
            this.userSexField.Name = "userSexField";
            this.userSexField.Size = new System.Drawing.Size(227, 22);
            this.userSexField.TabIndex = 8;
            this.userSexField.Enter += new System.EventHandler(this.userSexField_Enter);
            this.userSexField.Leave += new System.EventHandler(this.userSexField_Leave);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.Location = new System.Drawing.Point(177, 632);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(227, 25);
            this.passField.TabIndex = 6;
            this.passField.UseSystemPasswordChar = true;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // backgroung
            // 
            this.backgroung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.backgroung.Controls.Add(this.buttonSingin);
            this.backgroung.Controls.Add(this.loginField);
            this.backgroung.Controls.Add(this.REGISTRATION);
            this.backgroung.Controls.Add(this.pictureBox1);
            this.backgroung.Controls.Add(this.userSurnameField);
            this.backgroung.Controls.Add(this.userNameField);
            this.backgroung.Controls.Add(this.userSexField);
            this.backgroung.Controls.Add(this.passField);
            this.backgroung.Controls.Add(this.pictureBox3);
            this.backgroung.Controls.Add(this.pictureBox2);
            this.backgroung.Controls.Add(this.Close);
            this.backgroung.Location = new System.Drawing.Point(-11, -30);
            this.backgroung.Name = "backgroung";
            this.backgroung.Size = new System.Drawing.Size(554, 826);
            this.backgroung.TabIndex = 1;
            this.backgroung.Paint += new System.Windows.Forms.PaintEventHandler(this.backgroung_Paint);
            // 
            // buttonSingin
            // 
            this.buttonSingin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(217)))), ((int)(((byte)(43)))));
            this.buttonSingin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSingin.Location = new System.Drawing.Point(207, 712);
            this.buttonSingin.Name = "buttonSingin";
            this.buttonSingin.Size = new System.Drawing.Size(159, 50);
            this.buttonSingin.TabIndex = 14;
            this.buttonSingin.Text = "Sing in";
            this.buttonSingin.UseVisualStyleBackColor = false;
            this.buttonSingin.Click += new System.EventHandler(this.buttonSingin_Click);
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(177, 377);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(227, 22);
            this.loginField.TabIndex = 13;
            this.loginField.TextChanged += new System.EventHandler(this.loginField_TextChanged);
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // REGISTRATION
            // 
            this.REGISTRATION.AutoSize = true;
            this.REGISTRATION.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.REGISTRATION.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.REGISTRATION.Location = new System.Drawing.Point(142, 266);
            this.REGISTRATION.Name = "REGISTRATION";
            this.REGISTRATION.Size = new System.Drawing.Size(275, 38);
            this.REGISTRATION.TabIndex = 12;
            this.REGISTRATION.Text = "REGISTRATION";
            this.REGISTRATION.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Training_apparatus.Properties.Resources.namecard;
            this.pictureBox1.Location = new System.Drawing.Point(51, 335);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // userSurnameField
            // 
            this.userSurnameField.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userSurnameField.Location = new System.Drawing.Point(177, 489);
            this.userSurnameField.Multiline = true;
            this.userSurnameField.Name = "userSurnameField";
            this.userSurnameField.Size = new System.Drawing.Size(227, 22);
            this.userSurnameField.TabIndex = 10;
            this.userSurnameField.Enter += new System.EventHandler(this.userSurnameField_Enter);
            this.userSurnameField.Leave += new System.EventHandler(this.userSurnameField_Leave);
            // 
            // userNameField
            // 
            this.userNameField.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameField.Location = new System.Drawing.Point(177, 432);
            this.userNameField.Multiline = true;
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(227, 22);
            this.userNameField.TabIndex = 9;
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(107, 614);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(192, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 202);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(420, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(43, 17);
            this.Close.TabIndex = 0;
            this.Close.Text = "Close";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 781);
            this.Controls.Add(this.backgroung);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.backgroung.ResumeLayout(false);
            this.backgroung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox userSexField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel backgroung;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.TextBox userSurnameField;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label REGISTRATION;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Button buttonSingin;
    }
}