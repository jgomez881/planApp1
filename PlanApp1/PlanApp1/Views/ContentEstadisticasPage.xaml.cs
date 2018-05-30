using Plugin.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlanApp1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContentEstadisticasPage : ContentPage
	{
		public ContentEstadisticasPage ()
		{
			InitializeComponent ();
		}

        private void OpenBrowser_OnClicked(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://awesome-table.com/-LB8EbhBxzl6Kw4bx2MI/view");
        }

        private void OpenBrowser1_OnClicked(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://awesome-table.com/-LD40Zfl-HqdJHX2Dg0W/view");
        }
    }
}