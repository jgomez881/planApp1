namespace PlanApp1.Views
{
    using Xamarin.Forms;
    using System;
    using System.Linq;
    using PlanApp1.ViewModels;
    using PlanApp1.Models;

    public partial class PlansPage : ContentPage
	{
        private ViewModelMaterias Materias;

        public PlansPage ()
		{
			InitializeComponent ();
            /* Liga con la vista */
            Materias = new ViewModelMaterias();
            BindingContext = Materias;
        }
        /* Agui leo , creo una pagina y redirigo */
        private void RedirigirPagina(object sender, ItemTappedEventArgs e)
        {
            
            Materia materia = e.Item as Materia;
            if (materia.Vista != null)
            {
                Page PageDestino = (Page)Activator.CreateInstance(materia.Vista);
                PageDestino.Title = materia.Nombre;
                Navigation.PushAsync(PageDestino);
            }
        }

        private void XamlSearchBarBuscarMateriaTextChanged(object sender, TextChangedEventArgs e)
        {
            XamlListViewCatalogoMaterias.BeginRefresh();

            if ((((e.NewTextValue).Replace(" ", "")) == "") || string.IsNullOrEmpty(e.NewTextValue))
                XamlListViewCatalogoMaterias.ItemsSource = Materias.ObservableCollectionMaterias.DefaultIfEmpty();
            else
                XamlListViewCatalogoMaterias.ItemsSource = Materias.ObservableCollectionMaterias.Where(materia => materia.Nombre.ToUpper().Contains((e.NewTextValue).ToUpper()));
        }


    }
}
