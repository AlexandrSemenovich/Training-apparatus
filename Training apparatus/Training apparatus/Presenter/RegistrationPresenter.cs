using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_apparatus.Models.Entity;
using Training_apparatus.Presenter;
using Training_apparatus.Service;

namespace Training_apparatus.Presenter
{
    public class RegistrationPresenter : IPresenter
    {
        private readonly IRegistrationView _view;
        private readonly IRegistrationService _service;

        public RegistrationPresenter(IRegistrationView view, IRegistrationService service)
        {
            _view = view;
            _view.Registration += Registration;

            _service = service;
            _view.Registration += () => Registration();
        }

        public void Registration()
        {
            User user = new User(_view.Login, _view.Password, _view.Username, _view.Surname, _view.Sex);
            if (_service.Registration(user))
            {
                new LoginPresenter(new LoginForm(), new LoginService()).Run();
                _view.Close();
            }
            else
            {
               // _view.ShowError("Invalid 'Initiative' value");
            }
        }
        public event Action RegistrationUpdated;

        private void HandleRegistrationUpdate()
        {
            RegistrationUpdated?.Invoke();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}