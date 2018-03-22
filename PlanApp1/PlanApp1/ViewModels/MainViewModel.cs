﻿namespace PlanApp1.ViewModels
{
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