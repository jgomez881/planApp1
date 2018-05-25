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
	public partial class ContentComunidadPage : ContentPage
	{
        ViewModelComunidad ViewModelComunidadComentarios;
		public ContentComunidadPage ()
		{
            InitializeComponent();
            ViewModelComunidadComentarios = new ViewModelComunidad();
            BindingContext = ViewModelComunidadComentarios;
            //XamlButtonEnviarComentario.Clicked += XamlButtonEnviarComentario_Clicked;
        }

        private void XamlButtonEnviarComentario_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(XamlEntryNuevoComentario.Text))
            {
                ViewModelComunidadComentarios.ObservableCollectionComentarios.Add
                (
                    new Comentario()
                    {
                        Mensaje = XamlEntryNuevoComentario.Text,
                        Fecha = DateTime.Today
                    }
                );
                XamlEntryNuevoComentario.Text = "";
            }
        }
    }
}