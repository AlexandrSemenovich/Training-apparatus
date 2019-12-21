using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_apparatus.Presenter
{
    public interface IRegistrationView : IView
    {
        event Action Registration;
        string Surname { get; }
        string Sex { get; }
        string Username { get; }
        string Login { get; }
        string Password { get; }
    }
}
