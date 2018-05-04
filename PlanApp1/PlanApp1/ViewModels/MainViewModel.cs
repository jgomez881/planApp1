namespace PlanApp1.ViewModels
{
    //MainViewModel hace la conexion con las otras vistas
	public class MainViewModel
	{
        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }

        public  PlansViewModel Plans
        {
            get;
            set;
        }

        public NewCustomerViewModel  NewCustomer
        { 
            get; 
            set; 
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if(instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion
    }
}