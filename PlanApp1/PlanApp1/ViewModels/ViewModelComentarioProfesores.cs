using PlanApp1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PlanApp1.ViewModels
{
    public class ViewModelComentarioProfesores
    {
        public ObservableCollection<ComentarioPr> ObservableCollectionComentariosP { get; set; }
        public ViewModelComentarioProfesores()
        {
            ObservableCollectionComentariosP = new ObservableCollection<ComentarioPr>(
                      );
        }

    }
}
