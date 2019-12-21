using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_apparatus.Service;

namespace Training_apparatus.Presentation
{
    public class AdminForm
    {

        private IKernel _kernel;
        private UserService _scs;
        private IAdminFormView _view;
        public AdminForm(IKernel kernel, UserService scs, IAdminFormView view)
        {
            _kernel = kernel;
            _scs = scs;
            _view = view;
        }

        public void Run()
        {
            _view.Show();
        }
    }
}