﻿namespace PlanApp1.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Views;
    using Xamarin.Forms;
    using Services;
    /*si algo borro el usin service y la carpeta y la region service y del constructor*/
    /* Hereda de la BaseViewModel*/
    public class LoginViewModel : BaseViewModel
    {
        /*aqui ponemos a refrescar los campos*/
        #region  Attributes
        private string password;
        private string email;
        private bool isRunning;
        private bool isEnabled;
        #endregion

        #region Services
        DialogService dialogService;
        #endregion

        #region Properties
        public string Email
        {
            /*Refresco la View y me la deja en blanco*/
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }


        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }

        public bool IsRemembered
        {
            get;
            set;
        }

        public bool IsEnabled {
            /*Refresco la aplicacion en tiempo de ejecucion */
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            dialogService = new DialogService();
            this.IsRemembered = true;
            this.IsEnabled = true;
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }


        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {

                await dialogService.ShowMessage("Error", 
                    "You must enter an Email");
                /*await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an Email",
                    "Accept");*/
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {

                await dialogService.ShowMessage("Error",
                    "You must enter an password");
                /* await Application.Current.MainPage.DisplayAlert(
                     "Error",
                     "You must enter an password.",
                     "Accept");*/
                return;
            }

            this.IsRunning = true;
            this.IsEnabled = false;

            if (this.Email != "jkamilogomez5@gmail.com" || this.Password != "1234")
            {
                this.IsRunning = false;
                this.IsEnabled = true;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email or password incorrect.",
                    "Accept");
                this.Password = string.Empty;
                return;
            }
            this.IsRunning = false;
            this.IsEnabled = true;

            this.Email = string.Empty;
            this.Password = string.Empty;

            MainViewModel.GetInstance().Plans= new PlansViewModel();

            await Application.Current.MainPage.Navigation.PushAsync(new PlansPage());

        }
        #endregion
    }
}