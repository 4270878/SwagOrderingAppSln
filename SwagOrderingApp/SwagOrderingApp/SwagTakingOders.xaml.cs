using SwagOrderingApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace SwagOrderingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnsubmitButton_Clicked(object sender, EventArgs e)
        {
            var swagOdering = (SwagOrdering);
            SwagOderingDatabase database = await SwagOderingDatabase.Instance;
            await database.SaveChangesAsync(swagOdering);
            await Navigation.PopAsync();
        }


        private void submitButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
