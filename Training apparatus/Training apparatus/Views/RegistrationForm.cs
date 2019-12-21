using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Training_apparatus.Models.Entity;
using Training_apparatus.Presenter;

namespace Training_apparatus
{

    public partial class RegistrationForm : Form, IRegistrationView
    {
        public string Login { get { return loginField.Text; } }
        public string Password { get { return passField.Text; } }
        public string Username { get { return userNameField.Text; } }
        public string Sex { get { return userSexField.Text; } }
        public string Surname { get { return userSurnameField.Text; } }

        public event Action Registration;

        public RegistrationForm()
        {
            this.FormClosed += new FormClosedEventHandler(FormClosedwer);
            InitializeComponent();
            loginField.Text = "Введите имя пользователя";
            loginField.ForeColor = Color.Gray;
            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;
            userSurnameField.Text = "Введите фамилию";
            userSurnameField.ForeColor = Color.Gray;
            userSexField.Text = "Введите свой пол";
            userSexField.ForeColor = Color.Gray;
            passField.Text = "Введите пароль";
            passField.ForeColor = Color.Gray;
        }

     
        private void backgroung_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите имя пользователя")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите имя пользователя";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введите фамилию")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введите фамилию";
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        private void userSexField_Enter(object sender, EventArgs e)
        {
            if (userSexField.Text == "Введите свой пол")
            {
                userSexField.Text = "";
                userSexField.ForeColor = Color.Black;
            }
        }

        private void userSexField_Leave(object sender, EventArgs e)
        {
            if (userSexField.Text == "")
            {
                userSexField.Text = "Введите свой пол";
                userSexField.ForeColor = Color.Gray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if(passField.Text == "Введите пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (userSexField.Text == "")
            {
                passField.Text = "Введите пароль";
                passField.ForeColor = Color.Gray;
            }
        }

        private void buttonSingin_Click(object sender, EventArgs e)
        {
            Registration?.Invoke();

        }



        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
        }
        public void FormClosedwer(object sender, EventArgs e)
        {
            //SaveUser?.Invoke(new User());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
