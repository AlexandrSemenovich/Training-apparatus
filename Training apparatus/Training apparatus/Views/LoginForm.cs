using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Training_apparatus.Presentation;

namespace Training_apparatus
{
    public partial class LoginForm : Form, ILoginView

    {
        private readonly ApplicationContext _applicationContext;
        public LoginForm(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
            InitializeComponent();


        }

        public event Action RegisterUser;
        public event Action EnterUser;
        public event Action EnterAdmin;

        public LoginForm()
        {
            InitializeComponent();


        }

        private void Close_button(object sender, EventArgs e)
        {
            this.Close();
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
            String loginUser = loginField.Text;
            String passUser = passField.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @userlogin AND `pass` = @userpass ", db.getConnection());
            command.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@userpass", MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                /* this.Hide();
                 MainForm mainForm = new MainForm();
                 mainForm.Show();*/
                if (loginField.Text == "admin")
                {
                    this.Hide();
                    AdminForm adminForm = new AdminForm();
                    EnterAdmin?.Invoke();
                    //adminForm.Show();
                }
                else
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    EnterUser?.Invoke();
                    //mainForm.Show();

                }
            }
            else
                MessageBox.Show("NO");


        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            RegisterUser?.Invoke();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void backgroung_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
