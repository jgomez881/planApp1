using PlanApp1.Models;
using PlanApp1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace PlanApp1.ViewModels
{
    class ViewModelMaterias
    {
        public ObservableCollection<Materia> ObservableCollectionMaterias { get; set; }

        public ViewModelMaterias()
        {
            ObservableCollectionMaterias = new ObservableCollection<Materia>(new[]
            {
                new Materia { Nombre = "Calculo", Vista = typeof(ContentCalculoPage)}, 
                new Materia { Nombre = "Algebra", Vista = typeof(ContentAlgebraPage)},
                new Materia { Nombre = "Fisica", Vista =  typeof(ContentAlgebraPage)},
            });
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        
    }
}
