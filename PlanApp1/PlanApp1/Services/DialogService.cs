﻿namespace PlanApp1.Services
{
    using System;
    using System.Threading.Tasks;
    using Xamarin.Forms;

    public class DialogService 
	{
		public async Task ShowMessage(string title,string message)
        {
            await Application.Current.MainPage.DisplayAlert(title, 
                message, 
                "Aceptar");
        }

        internal Task ShowMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}