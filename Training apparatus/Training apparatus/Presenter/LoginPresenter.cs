using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_apparatus.Service;
using Training_apparatus.Models.Entity;

namespace Training_apparatus.Presenter
{
    public class LoginPresenter : IPresenter
    {
        private readonly ILoginView _view;
        private readonly ILoginService _service;

        public LoginPresenter(ILoginView view, ILoginService service)
        {
            _view = view;
            _service = service;

            _view.Login += () => Login(_view.Username, _view.Password);
            _view.GoToRegistration += () => GoToRegistration();
        }

        public void Run()
        {
            _view.Show();
        }

        public void StartProgram()
        {
            _view.Start();
        }

        private void Login(string username, string password)
        {
            if (username == "")
                throw new ArgumentNullException("username");
            if (password == "")
                throw new ArgumentNullException("password");

            var user = new User { Name = username, Password = password };
            if (!_service.Login(user))
            {
                _view.ShowError("Invalid username or password");
            }
            else
            {
                new MainFormPresenter(new MainForm()).Run();
                _view.Close();
            }
        }

        private void GoToRegistration()
        {
            new RegistrationPresenter(new RegistrationForm(), new RegistrationService()).Run();
           // _view.Close();
        }
    }
}