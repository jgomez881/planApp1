﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlanApp1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfesorAlgebraPage : ContentPage
	{
		public ProfesorAlgebraPage ()
		{
			InitializeComponent ();
		}

        private void BtnCalificar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentCalificarPage());
        }
    }
}