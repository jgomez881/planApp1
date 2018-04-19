namespace PlanApp1.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Views;
    using Xamarin.Forms;
    using Services;
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
        public ICommand RegisterNewUserCommand
        {
            get
            {
                return new RelayCommand(RegisterNewUser);
            }
        }

        async void RegisterNewUser()
        {
            MainViewModel.GetInstance().NewCustomer = new NewCustomerViewModel();
            /*await navigationService.NavigateOnLogin("NewCustomerView");*/
            await Application.Current.MainPage.Navigation.PushAsync(new NewCustomerPage());
        }

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
                    "Debes ingresar un correo electrónico");
                #region OtraForma
                /*await Application.Current.MainPage.DisplayAlert(
                "Error",
                "You must enter an Email",
                "Accept");*/
                #endregion
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {

                await dialogService.ShowMessage("Error",
                    "Debes ingresar una contraseña");
                #region OtraForma
                /* await Application.Current.MainPage.DisplayAlert(
                     "Error",
                     "You must enter an password.",
                     "Accept");*/
                #endregion

                return;
            }

            this.IsRunning = true;
            this.IsEnabled = false;

            if (this.Email != "jgomez88@gmail.com" || this.Password != "1234")
            {
                this.IsRunning = false;
                this.IsEnabled = true;
                await dialogService.ShowMessage("Error",
                    "Email o contraseña incorrecta.");
                #region otra forma
                   await Application.Current.MainPage.DisplayAlert(
                   "Error",
                   "Email or password incorrect.",
                   "Accept");
                #endregion
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