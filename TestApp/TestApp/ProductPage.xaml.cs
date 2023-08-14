using TestApp.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductPage : ContentPage
    {
        public ProductPage(ProductItem product)
        {
            InitializeComponent();

            LoadProduct(product);
        }

        private void LoadProduct(ProductItem product)
        {
            Title = product.Title;

            cvImageList.ItemsSource = product.Images;

            lblProductBrand.Text = product.Brand;
            lblProductTitle.Text = product.Title;

            lblProductPrice.Text = $"{product.Price:C}";
            lblProductRating.Text = $"{product.Rating}/5.0";
            lblProductDescription.Text = product.Description;  
        }
    }
}