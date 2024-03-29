﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BaseMvvm.ViewModels.Base
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
         
        protected bool IsDesignMode
        {
            get => DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject());
        }
    }
}