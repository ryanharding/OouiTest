
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamFormsWeb.XamarinForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();

            load();
        }

        private async Task load()
        {
            buttonX.Text = "hi";

            await Task.Delay(TimeSpan.FromSeconds(5));

            buttonX.Text = "yay";
        }

        int count = 0;
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var button = sender as Button;

            if (button == null)
                return;

            count++;
            button.Text = $"You clicked {count} times!";
        }
    }
}