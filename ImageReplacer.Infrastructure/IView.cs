﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageReplacer.Infrastructure
{
    public interface IView
    {
        IViewModel ViewModel { get; set; }
    }
}
