using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Training_apparatus.Presenter;

namespace Training_apparatus
{
    public partial class LoginForm : Form, ILoginView
    {
        private readonly ApplicationContext _applicationContext;

        public string Username { get { return loginField.Text; } }
        public string Password { get { return passField.Text; } }

        public event Action Login;
        public event Action GoToRegistration;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Close_button(object sender, EventArgs e)
        {
            Close();
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Black;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.White;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login?.Invoke();
        }

        public void Start()
        {
            Application.Run(this);
        }

        private void registButton_Click(object sender, EventArgs e)
        {
            GoToRegistration?.Invoke();
        }

        public void ShowError(string errorMessage) { }

        private void passField_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
