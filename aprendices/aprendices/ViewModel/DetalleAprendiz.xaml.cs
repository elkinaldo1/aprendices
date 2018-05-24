using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using aprendices.Model;

namespace aprendices.ViewModel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetalleAprendiz : ContentPage
	{
		public DetalleAprendiz (Aprendiz aprendizSeleccionado)
		{
			InitializeComponent ();
            this.BindingContext = aprendizSeleccionado;
		}
	}
}