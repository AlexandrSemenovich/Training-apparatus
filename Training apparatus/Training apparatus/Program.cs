using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using Training_apparatus.Presentation;
using System;
using Training_apparatus.Models.Servise;

namespace Training_apparatus
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ninject.StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());

            kernel.Bind<IRegisterView>().To<RegisterForm>();
            kernel.Bind<ILoginView>().To<LoginForm>();
            kernel.Bind<IMainFormView>().To<MainForm>();
            kernel.Bind<IAdminFormView>().To<AdminForm>();


            kernel.Bind<Scs>().To<Class1>().InSingletonScope();

            kernel.Bind<RegisterPresenter>().ToSelf();
            kernel.Bind<LoginPresenter>().ToSelf();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            kernel.Get<LoginPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());

        }
    }
}