using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlanApp1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfesorCalculoPage : ContentPage
	{
		public ProfesorCalculoPage ()
		{
			InitializeComponent ();
            //BtnCalificar.Clicked += BtnCalificar_Clicked;

        }
       //eventos de lo que va a apasar
        private void BtnCalificar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentCalificarPage());
        }
    }
}