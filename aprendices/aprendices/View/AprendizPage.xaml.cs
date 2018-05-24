using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprendices.View
{
    using ViewModel;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    using Model;
    using View;

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AprendizPage : ContentPage
	{
		public AprendizPage ()
		{
			InitializeComponent ();
            this.BindingContext = new AprendizPageViewModel();
            lstName.ItemSelected += LstName_ItemSelected;
        }

        private void LstName_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var aprendizSeleccionado = (Aprendiz)e.SelectedItem;
            if (aprendizSeleccionado == null)
            {
                return;
            }
            Navigation.PushAsync(new DetalleAprendiz(aprendizSeleccionado));
            lstName.SelectedItem = null;
        }
    }
}