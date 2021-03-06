﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_apparatus.Presenter
{
    public interface ILoginView : IView
    {
        event Action Login;
        event Action GoToRegistration;

        string Username { get; }
        string Password { get; }
        
        void ShowError(string errorMessage);
        void Start();
    }
}