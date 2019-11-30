using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Training_apparatus.Models.Servise;
using Training_apparatus.Presentation;

namespace Training_apparatus.Presentation
{
    public class LoginPresenter
    {
        private IKernel _kernel;
        private Scs _scs;
        private ILoginView _view;
        public LoginPresenter(IKernel kernel, Scs scs, ILoginView view)
        {
            _kernel = kernel;
            _scs = scs;
            _view = view;
            _view.RegisterUser += RegisterUser;
            _view.EnterUser += EnterUser;
            _view.EnterAdmin += EnterAdmin;
        }

        private void EnterAdmin()
        {
            _kernel.Get<AdminForm>().Run();
        }

        private void EnterUser()
        {
            _kernel.Get<MainFormPresenter>().Run();
        }

        private void RegisterUser()
        {
            _kernel.Get<RegisterPresenter>().Run();
        }

        public void Run()
        {
            _view.Show();
        }

    }
}