using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_apparatus.Models.Servise;

namespace Training_apparatus.Presentation
{
    public class RegisterPresenter
    {
        private IKernel _kernel;
        private Scs _scs;
        private IRegisterView _view;

        public RegisterPresenter() { }

        public RegisterPresenter(IKernel kernel, Scs scs, IRegisterView view)
        {
            _kernel = kernel;
            _scs = scs;
            _view = view;
            _view.SaveUser += LoginUser;
        }

        public void LoginUser()
        {
            //_kernel.Get<LoginPresenter>().Run();
        }

        internal void Run()
        {
 
            _view.Show();
        }
        internal void Close()
        {
            _view.Close();
        }

    }
}