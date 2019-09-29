using System;
using System.Collections.Generic;
using System.Text;

namespace BaseMvvm.ViewModels
{
    public class HomeViewModel : Base.BaseViewModel
    {
        public RealyComands CambiaTitoloCommand { get; private set; }

        private string _title;
        private string _nuovoTitolo;
        public string Title
        {
            get => _title;
            set
            {
                if (value != _title)
                {
                    _title = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string NuovoTitolo
        {
            get => _nuovoTitolo;
            set
            {
                if (value != _nuovoTitolo)
                {
                    _nuovoTitolo = value;
                    NotifyPropertyChanged();
                    CambiaTitoloCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public HomeViewModel()
        {
            CambiaTitoloCommand = new RealyComands(cambiaTitoloMethod, cambiaTitoloCanExec);
        }


        private void cambiaTitoloMethod(object param) => Title = NuovoTitolo;

        private bool cambiaTitoloCanExec(object param) => (NuovoTitolo?.Length > 5 && NuovoTitolo.Length < 10);

    }
}
