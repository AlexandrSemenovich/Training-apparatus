using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_apparatus.Presentation
{
    public interface ILoginView
    {
        event Action RegisterUser;
        event Action EnterUser;
        event Action EnterAdmin;

        void Show();
    }
}