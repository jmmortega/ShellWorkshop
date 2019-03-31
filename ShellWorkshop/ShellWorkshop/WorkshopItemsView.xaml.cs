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
    [QueryProperty("Name", "name")]
	public partial class WorkshopItemsView : ContentPage
	{
		public WorkshopItemsView ()
		{
			InitializeComponent ();
            ActorsCollection.ItemsSource = DataGeneration.CreateActors();
        }                
    }
}