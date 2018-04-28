namespace PlanApp1
{
    using Views;
    using Xamarin.Forms;
    using System;
    using System.Data;
    using System.Text;
    using MySql.Data;
    using MySql.Data.MySqlClient;
    public partial class App : Application
	{
        #region Constructors
        public App()
        {
            InitializeComponent();
            /* MySqlConnection conn;
            string myConnectionString;

            myConnectionString = "server=10.131.137.177;uid=user1;" +
                "port=3306;pwd=eafit.2016;database=PlanApp";

            Console.WriteLine("Connecting to MySQL");
            try
            {
                conn = new MySqlConnection(myConnectionString);
                conn.Open();

                DataTable table = conn.GetSchema("Usuario");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }*/
            this.MainPage = new NavigationPage(new LoginPage());

        }
        #endregion

        #region Methods
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        #endregion
    }
}