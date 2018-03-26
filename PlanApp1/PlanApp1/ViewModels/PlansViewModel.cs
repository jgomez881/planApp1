namespace PlanApp1.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Services;
    using System.Windows.Input;

    /*logica buscador*/
    public class PlansViewModel : BaseViewModel
	{


        #region Services
        DialogService dialogService;
        #endregion

        #region Attributes
        bool isRefreshing;
        string filter;
        #endregion

        #region Properties
        public string Filter
        {
           get { return this.filter; }
           set { SetValue(ref this.filter, value); }
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }
        #endregion
      
        #region Constructors
        public PlansViewModel()
        {
            instance = this;
            dialogService = new DialogService();
        }
        #endregion
       
       #region Sigleton
       static PlansViewModel instance;

       public static PlansViewModel GetInstance()
       {
           if (instance == null)
           {
               return new PlansViewModel();
           }

           return instance;
       }
        #endregion

        #region Comentado
        /*
        #region Methods
        public void Add(Category category)
        {
            IsRefreshing = true;
            categories.Add(category);
            Categories = new ObservableCollection<Category>(
                categories.OrderBy(c => c.Description));
            IsRefreshing = false;
        }

        public void Update(Category category)
        {
            IsRefreshing = true;
            var oldCategory = categories
                .Where(c => c.CategoryId == category.CategoryId)
                .FirstOrDefault();
            oldCategory = category;
            Categories = new ObservableCollection<Category>(
                categories.OrderBy(c => c.Description));
            IsRefreshing = false;
        }

        public async Task Delete(Category category)
        {
            IsRefreshing = true;

            var connection = await apiService.CheckConnection();
            if (!connection.IsSuccess)
            {
                IsRefreshing = false;
                await dialogService.ShowMessage("Error", connection.Message);
                return;
            }

            var mainViewModel = MainViewModel.GetInstance();

            var response = await apiService.Delete(
                "http://productszuluapi.azurewebsites.net",
                "/api",
                "/Categories",
                mainViewModel.Token.TokenType,
                mainViewModel.Token.AccessToken,
                category);

            if (!response.IsSuccess)
            {
                IsRefreshing = false;
                await dialogService.ShowMessage(
                    "Error",
                    response.Message);
                return;
            }

            categories.Remove(category);
            Categories = new ObservableCollection<Category>(
                categories.OrderBy(c => c.Description));

            IsRefreshing = false;
        }

        async void LoadCategories()
        {
            IsRefreshing = true;
            var connection = await apiService.CheckConnection();
            if (!connection.IsSuccess)
            {
                categories = dataService.Get<Category>(true);
                if (categories.Count == 0)
                {
                    await dialogService.ShowMessage(
                        "Error",
                        "Dear user, YAPE");
                    return;
                }
            }
            else
            {
                var mainViewModel = MainViewModel.GetInstance();

                var urlAPI = Application.Current.Resources["URLAPI"].ToString();

                var response = await apiService.GetList<Category>(
                    urlAPI,
                    "/api",
                    "/Categories",
                    mainViewModel.Token.TokenType,
                    mainViewModel.Token.AccessToken);

                if (!response.IsSuccess)
                {
                    await dialogService.ShowMessage(
                        "Error",
                        response.Message);
                    return;
                }

                categories = (List<Category>)response.Result;
                SaveCategoriesOnDB();
            }

            Search();
            IsRefreshing = false;
        }

        void SaveCategoriesOnDB()
        {
            dataService.DeleteAll<Category>();
            foreach (var category in categories)
            {
                dataService.Insert(category);
                dataService.Save(category.Products);
            }
        }
        #endregion
    */

        #endregion
        
        #region Commands
        public ICommand SearchCommand
        {
            get
            {
                return new RelayCommand(Search);
            }
        }

        /*ya con esto a medida que buscamos nos van apareciando sugerencias*/
        void Search()
        {
            IsRefreshing = true;

            if (string.IsNullOrEmpty(Filter))
            {
            }
            else
            {
            }

            IsRefreshing = false;
        }

        /*public ICommand RefreshCommand
        {

        }*/
        #endregion
    }
}

