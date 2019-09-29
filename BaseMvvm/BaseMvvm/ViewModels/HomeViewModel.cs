using System;
using System.Collections.Generic;
using System.Text;

namespace BaseMvvm.ViewModels
{
    public class HomeViewModel : Base.BaseViewModel
    {
        private string title;
        public string Title
        {
            get => title;
            set
            {
                if (value != title)
                {
                    title = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public HomeViewModel()
        {
            Title = "Titolo assegnato dal ctor";
        }

    }
}
