
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListviewDetails : ContentPage
    {
        public ListviewDetails()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Product = e.Item as ProductModel;
            var xx = BindingContext as MainViewModel;
            xx?.ShowHideProduct(Product);
        }
    }
}