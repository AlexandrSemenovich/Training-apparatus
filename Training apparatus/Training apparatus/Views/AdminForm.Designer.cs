namespace Training_apparatus
{
    partial class AdminForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.usersList = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startSurveys = new System.Windows.Forms.Button();
            this.addNewSensors = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Remane = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Setting = new System.Windows.Forms.TabPage();
            this.background = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.load = new System.Windows.Forms.Label();
            this.surveyDate = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.patient = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.usersList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Setting.SuspendLayout();
            this.background.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.usersList);
            this.tabControl1.Controls.Add(this.Setting);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(897, 765);
            this.tabControl1.TabIndex = 0;
            // 
            // usersList
            // 
            this.usersList.Controls.Add(this.panel1);
            this.usersList.Location = new System.Drawing.Point(4, 25);
            this.usersList.Name = "usersList";
            this.usersList.Padding = new System.Windows.Forms.Padding(3);
            this.usersList.Size = new System.Drawing.Size(889, 736);
            this.usersList.TabIndex = 0;
            this.usersList.Text = "userList";
            this.usersList.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.startSurveys);
            this.panel1.Controls.Add(this.addNewSensors);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.Remane);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 730);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // startSurveys
            // 
            this.startSurveys.Location = new System.Drawing.Point(78, 540);
            this.startSurveys.Name = "startSurveys";
            this.startSurveys.Size = new System.Drawing.Size(150, 49);
            this.startSurveys.TabIndex = 6;
            this.startSurveys.Text = "Начать обследование ";
            this.startSurveys.UseVisualStyleBackColor = true;
            // 
            // addNewSensors
            // 
            this.addNewSensors.Location = new System.Drawing.Point(78, 353);
            this.addNewSensors.Name = "addNewSensors";
            this.addNewSensors.Size = new System.Drawing.Size(150, 46);
            this.addNewSensors.TabIndex = 5;
            this.addNewSensors.Text = "Установка новых датчикой";
            this.addNewSensors.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(78, 434);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 62);
            this.button4.TabIndex = 4;
            this.button4.Text = "Регистрация нового обследования";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Remane
            // 
            this.Remane.Location = new System.Drawing.Point(78, 277);
            this.Remane.Name = "Remane";
            this.Remane.Size = new System.Drawing.Size(150, 41);
            this.Remane.TabIndex = 3;
            this.Remane.Text = "Изменить";
            this.Remane.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(78, 205);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(150, 41);
            this.Add.TabIndex = 2;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(78, 130);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(150, 41);
            this.delete.TabIndex = 1;
            this.delete.Text = "Удалить ";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(362, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(482, 683);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.background);
            this.Setting.Location = new System.Drawing.Point(4, 25);
            this.Setting.Name = "Setting";
            this.Setting.Padding = new System.Windows.Forms.Padding(3);
            this.Setting.Size = new System.Drawing.Size(889, 736);
            this.Setting.TabIndex = 1;
            this.Setting.Text = "Setting";
            this.Setting.UseVisualStyleBackColor = true;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.background.Controls.Add(this.save);
            this.background.Controls.Add(this.panel2);
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(887, 743);
            this.background.TabIndex = 0;
            this.background.Paint += new System.Windows.Forms.PaintEventHandler(this.background_Paint);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(673, 590);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(164, 39);
            this.save.TabIndex = 2;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.loginField);
            this.panel2.Controls.Add(this.load);
            this.panel2.Controls.Add(this.surveyDate);
            this.panel2.Controls.Add(this.Sex);
            this.panel2.Controls.Add(this.Age);
            this.panel2.Controls.Add(this.patient);
            this.panel2.Location = new System.Drawing.Point(47, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 298);
            this.panel2.TabIndex = 1;
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
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(255, 81);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(227, 22);
            this.textBox5.TabIndex = 10;
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
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 756);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.tabControl1.ResumeLayout(false);
            this.usersList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Setting.ResumeLayout(false);
            this.background.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage usersList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addNewSensors;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Remane;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage Setting;
        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Label load;
        private System.Windows.Forms.Label surveyDate;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label patient;
        private System.Windows.Forms.Button startSurveys;
        private System.Windows.Forms.Button save;
    }
}