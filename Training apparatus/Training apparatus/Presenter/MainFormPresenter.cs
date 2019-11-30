using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_apparatus.Models.Servise;

namespace Training_apparatus.Presentation
{
    public class MainFormPresenter
    {
        private IMainFormView _view;
        private IKernel _kernel;
        private Scs _scs;
        public MainFormPresenter(IKernel kernel, Scs scs, IMainFormView view)
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