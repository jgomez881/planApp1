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
	public partial class ContentAlgebraPage : ContentPage
	{
        private ViewModelMaterias Profesores;

        public ContentAlgebraPage ()
		{
			InitializeComponent ();

            Profesores = new ViewModelMaterias();
            BindingContext = Profesores;

        }

        /* Agui leo , creo una pagina y redirigo */
        //sender va toda la informacion de la lista
        #region Comentado
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
        #endregion
        
    }
}