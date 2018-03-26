namespace PlanApp1.ViewModels
{
    using System.ComponentModel;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Helpers;
    using Models;
    using PlanApp1.Views;
    using Services;
    using Xamarin.Forms;

    public class NewCustomerViewModel : BaseViewModel
    {

        #region Services
       /* ApiService apiService;*/
        DialogService dialogService;
        #endregion

        #region Attributes
        bool isRunning;
        bool isEnabled;
        #endregion

        #region Properties
        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }

        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }

        public string FirstName
        {
            get;
            set;
        }


        public string LastName
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string Phone
        {
            get;
            set;
        }


        public string Password
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }

        public string Confirm
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public NewCustomerViewModel()
        {
            /*apiService = new ApiService();*/
            dialogService = new DialogService();
            /*Es decir como arranca el boton */
            IsEnabled = true;
        }
        #endregion

        #region Commands
        public ICommand SaveCommand
        {
            get
            {
                return new RelayCommand(Save);
            }
        }

        async void Save()
        {
            /*aca validamos que si hallan ingresado*/
            if (string.IsNullOrEmpty(FirstName))
            {
                await dialogService.ShowMessage(
                    "Error",
                    "You must enter a first name.");
                return;
            }

            if (string.IsNullOrEmpty(LastName))
            {
                await dialogService.ShowMessage(
                    "Error",
                    "You must enter a last name.");
                return;
            }

            if (string.IsNullOrEmpty(Email))
            {
                await dialogService.ShowMessage(
                    "Error",
                    "You must enter a email.");
                return;
            }

            if (!RegexUtilities.IsValidEmail(Email))
            {
                await dialogService.ShowMessage(
                    "Error",
                    "You must enter a valid email.");
                return;
            }

            if (string.IsNullOrEmpty(Password))
            {
                await dialogService.ShowMessage(
                    "Error",
                    "You must enter a password.");
                return;
            }

            if (Password.Length < 6)
            {
                await dialogService.ShowMessage(
                    "Error",
                    "The password must have at least 6 characters length.");
                return;
            }

            if (string.IsNullOrEmpty(Confirm))
            {
                await dialogService.ShowMessage(
                    "Error",
                    "You must enter a password confirm.");
                return;
            }

            if (!Password.Equals(Confirm))
            {
                await dialogService.ShowMessage(
                    "Error",
                    "The password and confirm, does not match.");
                return;
            }

            IsRunning = true;
            IsEnabled = false;


            var customer = new Customer
            {
                Address = Address,
                Email = Email,
                FirstName = FirstName,
                LastName = LastName,
                Password = Password,
                Phone = Phone,
            };
            #region Comentado
            /*var connection = await apiService.CheckConnection();
           if (!connection.IsSuccess)
           {
               IsRunning = false;
               IsEnabled = true;
               await dialogService.ShowMessage("Error", connection.Message);
               return;
           }
           // aca mandamos todos los datos que el usuario halla digitado
           var customer = new Customer
           {
               Address = Address,
               CustomerType = 1,
               Email = Email,
               FirstName = FirstName,
               LastName = LastName,
               Password = Password,
               Phone = Phone,
           };

           var response = await apiService.Post(
               "http://productszuluapi.azurewebsites.net",
               "/api",
               "/Customers",
               customer);

           if (!response.IsSuccess)
           {
               IsRunning = false;
               IsEnabled = true;
               await dialogService.ShowMessage(
                   "Error",
                   response.Message);
               return;
           }

           var response2 = await apiService.GetToken(
               "http://productszuluapi.azurewebsites.net",
               Email,
               Password);

           if (response2 == null)
           {
               IsRunning = false;
               IsEnabled = true;
               await dialogService.ShowMessage(
                   "Error",
                   "The service is not available, please try latter.");
               Password = null;
               return;
           }

           if (string.IsNullOrEmpty(response2.AccessToken))
           {
               IsRunning = false;
               IsEnabled = true;
               await dialogService.ShowMessage(
                   "Error",
                   response2.ErrorDescription);
               Password = null;
               return;
           }
           */

            #endregion

            var mainViewModel = MainViewModel.GetInstance();
            mainViewModel.Plans = new PlansViewModel();
            /**/await Application.Current.MainPage.Navigation.PushAsync(new PlansPage());

            IsRunning = false;
            IsEnabled = true;
        }
        #endregion
    }
}