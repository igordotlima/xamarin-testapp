using TestApp.Data;
using Xamarin.Forms;

namespace TestApp
{
    public partial class MainPage : ContentPage
    {
        private readonly ProductManager _manager;

        public MainPage()
        {
            InitializeComponent();

            _manager = new ProductManager();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var list = await _manager.GetProductsAsync();

            Title = $"Products ({list.Products.Count})";

            lvProductList.ItemsSource = list?.Products;
        }

        private async void OnProductSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) {
                return;
            }

            ProductItem selectedItem = e.SelectedItem as ProductItem;

            await Navigation.PushAsync(new NavigationPage(new ProductPage(selectedItem)));
        }
    }
}
