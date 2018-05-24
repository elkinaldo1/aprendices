
namespace aprendices.Model
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Collections.ObjectModel;

    public class Data:Notificable
    {
        private ObservableCollection<Aprendiz> aprendices = new ObservableCollection<Aprendiz>();

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
    }
}
