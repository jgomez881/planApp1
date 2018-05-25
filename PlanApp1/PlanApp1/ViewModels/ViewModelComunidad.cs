using PlanApp1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PlanApp1.ViewModels
{
    class ViewModelComunidad
    {
        public ObservableCollection<Comentario> ObservableCollectionComentarios { get; set; }

        public ViewModelComunidad()
        {
            ObservableCollectionComentarios = new ObservableCollection<Comentario>(
            );

           
        }
    }
}
