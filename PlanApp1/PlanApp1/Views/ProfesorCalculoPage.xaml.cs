using PlanApp1.Models;
using PlanApp1.ViewModels;
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
        ViewModelComentarioProfesores ViewModelComentariospro;
        public ProfesorCalculoPage ()
		{
			InitializeComponent ();
            ViewModelComentariospro = new ViewModelComentarioProfesores();
            BindingContext = ViewModelComentariospro;
            //BtnCalificar.Clicked += BtnCalificar_Clicked;


        }

        #region Error
        private void XamlButtonEnviarComentariopro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentComentariosProfesoresPage());
            if (!string.IsNullOrEmpty(editorComentarioProfesor.Text))
            {
                ViewModelComentariospro.ObservableCollectionComentariosP.Add
                (
                    new ComentarioPr()
                    {
                        Mensaje = editorComentarioProfesor.Text,
                    }
                );
                editorComentarioProfesor.Text = "";
            }
        }
	
        #endregion 


        //eventos de lo que va a apasar
        private void BtnCalificar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentCalificarPage());
        }
    }
}