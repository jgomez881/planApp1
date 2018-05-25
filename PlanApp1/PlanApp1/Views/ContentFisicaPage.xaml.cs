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
	public partial class ContentFisicaPage : ContentPage
	{
        private ViewModelMaterias Profesores;

        public ContentFisicaPage ()
		{
            Profesores = new ViewModelMaterias();
            InitializeComponent ();
            BindingContext = Profesores;
        }

        /* Agui leo , creo una pagina y redirigo */
        //sender va toda la informacion de la lista
        private void RedirigirPagina(object sender, ItemTappedEventArgs e)
        {

            Profesor profesor = e.Item as Profesor;
            if (profesor.Vista != null)
            {
                Page PageDestino = (Page)Activator.CreateInstance(profesor.Vista);
                PageDestino.Title = profesor.Nombre;
                Navigation.PushAsync(PageDestino);
            }
        }



    }
}