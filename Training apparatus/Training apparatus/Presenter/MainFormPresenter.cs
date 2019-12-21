using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_apparatus.Service;

namespace Training_apparatus.Presenter
{
    public class MainFormPresenter : IPresenter
    {
        private IMainFormView _view;

        public MainFormPresenter(IMainFormView view)
        {
            _view = view;
        }

        public void Run()
        {
            _view.Show();
        }

    }
}