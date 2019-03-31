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
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            LabelName.Text = $"My name is {Name}";
        }

        public string Name { get; set; }
    }
}