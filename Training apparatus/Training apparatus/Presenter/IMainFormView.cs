﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_apparatus.Presenter
{
    public interface IMainFormView : IView
    {
        event Action UserEnter;
    }
}