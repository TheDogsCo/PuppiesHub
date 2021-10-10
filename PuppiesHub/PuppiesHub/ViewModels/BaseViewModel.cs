﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PuppiesHub.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
