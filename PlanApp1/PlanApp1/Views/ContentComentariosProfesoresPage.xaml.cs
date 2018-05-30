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
	public partial class ContentComentariosProfesoresPage : ContentPage
	{
        public ViewModelComentarioProfesores ComentarioProfesores;

        public ContentComentariosProfesoresPage (string comentario)
		{
            ComentarioProfesores = new ViewModelComentarioProfesores();
            ComentarioProfesores.ObservableCollectionComentariosP.Add(new Models.ComentarioPr { Mensaje = comentario });
			InitializeComponent ();
            BindingContext = ComentarioProfesores;
		}
	}
}