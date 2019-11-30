namespace Training_apparatus
{
    partial class MainForm
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
            this.mainUserForm = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.skinmoisture = new System.Windows.Forms.Label();
            this.pulse = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.list = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.load = new System.Windows.Forms.Label();
            this.surveyDate = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.patient = new System.Windows.Forms.Label();
            this.mainUserForm.SuspendLayout();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.list.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainUserForm
            // 
            this.mainUserForm.Controls.Add(this.Main);
            this.mainUserForm.Controls.Add(this.list);
            this.mainUserForm.Location = new System.Drawing.Point(0, 3);
            this.mainUserForm.Name = "mainUserForm";
            this.mainUserForm.SelectedIndex = 0;
            this.mainUserForm.Size = new System.Drawing.Size(1236, 634);
            this.mainUserForm.TabIndex = 0;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Main.Controls.Add(this.textBox8);
            this.Main.Controls.Add(this.textBox7);
            this.Main.Controls.Add(this.textBox6);
            this.Main.Controls.Add(this.textBox5);
            this.Main.Controls.Add(this.button1);
            this.Main.Controls.Add(this.skinmoisture);
            this.Main.Controls.Add(this.pulse);
            this.Main.Controls.Add(this.pressure);
            this.Main.Controls.Add(this.temp);
            this.Main.Controls.Add(this.pictureBox1);
            this.Main.Location = new System.Drawing.Point(4, 25);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(1228, 605);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(154, 407);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(54, 22);
            this.textBox8.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(154, 353);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(54, 22);
            this.textBox7.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(390, 251);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(54, 22);
            this.textBox6.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(400, 181);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(54, 22);
            this.textBox5.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(928, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "СТАРТ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // skinmoisture
            // 
            this.skinmoisture.AutoSize = true;
            this.skinmoisture.BackColor = System.Drawing.Color.WhiteSmoke;
            this.skinmoisture.Location = new System.Drawing.Point(375, 231);
            this.skinmoisture.Name = "skinmoisture";
            this.skinmoisture.Size = new System.Drawing.Size(79, 17);
            this.skinmoisture.TabIndex = 5;
            this.skinmoisture.Text = "Влажность";
            // 
            // pulse
            // 
            this.pulse.AutoSize = true;
            this.pulse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pulse.Location = new System.Drawing.Point(397, 161);
            this.pulse.Name = "pulse";
            this.pulse.Size = new System.Drawing.Size(47, 17);
            this.pulse.TabIndex = 4;
            this.pulse.Text = "Пульс";
            // 
            // pressure
            // 
            this.pressure.AutoSize = true;
            this.pressure.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pressure.Location = new System.Drawing.Point(151, 378);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(144, 17);
            this.pressure.TabIndex = 3;
            this.pressure.Text = "Кровяного давления";
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.temp.Location = new System.Drawing.Point(151, 432);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(132, 17);
            this.temp.TabIndex = 2;
            this.temp.Text = "Температура кожи";
            this.temp.Click += new System.EventHandler(this.temp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Training_apparatus.Properties.Resources.sportsman;
            this.pictureBox1.Location = new System.Drawing.Point(22, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.list.Controls.Add(this.panel1);
            this.list.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.list.Location = new System.Drawing.Point(4, 25);
            this.list.Name = "list";
            this.list.Padding = new System.Windows.Forms.Padding(3);
            this.list.Size = new System.Drawing.Size(1228, 605);
            this.list.TabIndex = 1;
            this.list.Text = "List";
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.loginField);
            this.panel1.Controls.Add(this.load);
            this.panel1.Controls.Add(this.surveyDate);
            this.panel1.Controls.Add(this.Sex);
            this.panel1.Controls.Add(this.Age);
            this.panel1.Controls.Add(this.patient);
            this.panel1.Location = new System.Drawing.Point(164, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 298);
            this.panel1.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(410, 236);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(354, 22);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(340, 185);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(424, 22);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(255, 125);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 22);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(255, 81);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 22);
            this.textBox1.TabIndex = 10;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(255, 42);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(227, 22);
            this.loginField.TabIndex = 9;
            // 
            // load
            // 
            this.load.AutoSize = true;
            this.load.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.load.Location = new System.Drawing.Point(28, 229);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(357, 29);
            this.load.TabIndex = 4;
            this.load.Text = "Тип физмческой нагрузки :";
            // 
            // surveyDate
            // 
            this.surveyDate.AutoSize = true;
            this.surveyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surveyDate.Location = new System.Drawing.Point(28, 185);
            this.surveyDate.Name = "surveyDate";
            this.surveyDate.Size = new System.Drawing.Size(271, 29);
            this.surveyDate.TabIndex = 3;
            this.surveyDate.Text = "Дата обследования :";
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sex.Location = new System.Drawing.Point(28, 119);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(76, 29);
            this.Sex.TabIndex = 2;
            this.Sex.Text = "Пол :";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Age.Location = new System.Drawing.Point(28, 75);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(128, 29);
            this.Age.TabIndex = 1;
            this.Age.Text = "Возраст :";
            // 
            // patient
            // 
            this.patient.AutoSize = true;
            this.patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patient.Location = new System.Drawing.Point(28, 35);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(135, 29);
            this.patient.TabIndex = 0;
            this.patient.Text = "Пациент :";
            this.patient.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 639);
            this.Controls.Add(this.mainUserForm);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.mainUserForm.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.list.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainUserForm;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.Label skinmoisture;
        private System.Windows.Forms.Label pulse;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage list;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label patient;
        private System.Windows.Forms.Label load;
        private System.Windows.Forms.Label surveyDate;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
    }
}