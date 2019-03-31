using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellWorkshop
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FirstView : ContentPage
	{
		public FirstView ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Routing.RegisterRoute(nameof(WorkshopItemsView).ToLower(), typeof(WorkshopItemsView));
            
            var shell = MyShell.CurrentShell;
            
            var uri = $"{shell.RouteScheme}://{shell.RouteHost}/{shell.Route}/SecondShellItem/SecondShellSection/SecondShellContent/{nameof(WorkshopItemsView)}?name={EntryName.Text}".ToLower();

            shell.GoToAsync(new ShellNavigationState(uri));

            
            
        }
    }
}