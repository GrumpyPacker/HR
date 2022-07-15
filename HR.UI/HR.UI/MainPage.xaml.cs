using System;
using Xamarin.Forms;

namespace HR.UI
{
    public partial class MainPage : ContentPage
    {
        public MainPageVm MainPageView { get; set; }

        public MainPage()
        {
            InitializeComponent();
            MainPageView = MockData.GetMockMainPage();
            BindingContext = this;
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Dashboard());
        }
    }
}
