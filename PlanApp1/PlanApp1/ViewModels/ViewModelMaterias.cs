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

        public ObservableCollection<Profesor> ObservableCollectionProfesores { get; set; }

        public ViewModelMaterias()
        {
            ObservableCollectionMaterias = new ObservableCollection<Materia>(new[]
            {
                new Materia { Nombre = "Calculo III", Vista = typeof(ContentCalculoPage)}, 
                new Materia { Nombre = "Algebra Lineal", Vista = typeof(ContentAlgebraPage)},
                new Materia { Nombre = "Fisica I", Vista =  typeof(ContentFisicaPage)},
            });

            ObservableCollectionProfesores = new ObservableCollection<Profesor>(new[]
           {
                new Profesor { Nombre = "Javier Espitia", Vista = typeof(ProfesorCalculoPage)},
                new Profesor { Nombre = "Carlos Marin", Vista = typeof(ProfesorCalculoPage)},
                new Profesor { Nombre = "Patricia Gomez",Vista = typeof(ProfesorCalculoPage)},
                new Profesor { Nombre = "Pedro Vicente",Vista = typeof(ProfesorCalculoPage)},
                new Profesor { Nombre = "Juan Guillermo",Vista = typeof(ProfesorCalculoPage)},
                new Profesor { Nombre = "Juan Carlos",Vista = typeof(ProfesorCalculoPage)},
                new Profesor { Nombre = "ProfesorAlgebra", Vista = typeof(ProfesorAlgebraPage)},
            }
           );


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
