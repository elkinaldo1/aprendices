
namespace aprendices.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using aprendices.Model;
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using Xamarin.Forms;
    using Model.Services;

    public class AprendizPageViewModel:Notificable 
    {
        private ObservableCollection<Aprendiz> aprendices;

        public ObservableCollection<Aprendiz> Aprendices
        {
            get
            {
                return aprendices;
            }
            set
            {
                if (aprendices == value)
                {
                    return;
                }
                aprendices = value;
                OnPropertyChanged();
            }
        }

        private bool isEnabled;

        public bool IsEnabled
        {
            get
            {
                return isEnabled;
            }
            set
            {
                if (isEnabled == value)
                {
                    return;
                }
                isEnabled = value;
                OnPropertyChanged();
            }
        }

        public Command CargarAprendizCommand { get; set; }
        public AprendizPageViewModel()
        {
            aprendices = new ObservableCollection<Aprendiz>();
            CargarAprendizCommand = new Command((obj) => CargarAprendices());
        }

        private async void CargarAprendices()
        {
            if (!IsEnabled)
            {
                IsEnabled = true;
                await Task.Delay(3000);
                Data listAprendices = CaracterizacionAprendices.CargarAprendices();
                aprendices = listAprendices.Aprendices;
                IsEnabled = false;
            }
        }
    }    
}
