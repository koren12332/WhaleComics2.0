using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using WhaleComics_2._0.MyService;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WhaleComics_2._0
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MarvelProductsPage : Page
    {
        public ObservableCollection<MyProduct> MarvelProducts;
        public ObservableCollection<Product> CartProducts;
        MethodsClient manager = new MethodsClient();
        public MarvelProductsPage()
        {
            this.InitializeComponent();
            InitImages();
            MarvelProducts = new ObservableCollection<MyProduct>();
            InitProducts(MarvelProducts);
        }

        private void InitImages()
        {

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            CartProducts = (ObservableCollection<Product>)e.Parameter;
        }

        private async void InitProducts(ObservableCollection<MyProduct> products)
        {
            ProductList prodList = new ProductList();
            prodList = await manager.SelectAllProductAsync();
            foreach (Product p in prodList)
            {
                MyProduct myProduct = new MyProduct();
                if (p.ProductName == "Thor")
                    myProduct.ProductImage = string.Format("Assets/Photos/{0}.png", p.ProductName);
                else
                    myProduct.ProductImage = string.Format("Assets/Photos/{0}.jpg", p.ProductName);
                myProduct.ProductName = p.ProductName;
                myProduct.ProductPrice = "$" + p.ProductPrice.ToString();
                products.Add(myProduct);
            }
        }

        private async void AddToCartButton_Click(object sender, RoutedEventArgs e)
        {
            var mySelectedButton = (Button)sender;
            string productName = mySelectedButton.Name;
            try
            {
                Product p = await manager.SelectProductByNameAsync(productName);
                foreach (var item in MarvelProducts)
                {
                    if (p.ProductName == item.ProductName)
                        p.ProductImage = item.ProductImage;
                }
                //p.ProductImage = MarvelProducts.Where(q => q.ProductName == p.ProductName)
                //    .Select(q => q.ProductImage).ToString();
                CartProducts.Add(p);
                MoveToCartPrompt();
            }
            catch (Exception ex)
            {
            }
        }
        private async void MoveToCartPrompt()
        {
            string content = "Do you want to procced to cart?";
            string title = "Added To Cart";
            var dialog = new MessageDialog(content, title);
            var yesCommand = new UICommand("Yes", cmd => { });
            var cancelCommand = new UICommand("No", cmd => { });

            dialog.Options = MessageDialogOptions.None;
            dialog.Commands.Add(yesCommand);

            dialog.DefaultCommandIndex = 0;
            dialog.CancelCommandIndex = 0;

            if (cancelCommand != null)
            {
                dialog.Commands.Add(cancelCommand);
                dialog.CancelCommandIndex = (uint)dialog.Commands.Count - 1;
            }

            var command = await dialog.ShowAsync();

            if (command == yesCommand)
            {
                Frame.Navigate(typeof(CartPage), CartProducts);
            }
        }
    }
    public class MyProduct
    {
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public string ProductPrice { get; set; }
        //public string ProductType { get; set; }
        //public int ProductQuanity { get; set; }
        //public int ProductNumber { get; set; }
        //public string PruductGenre { get; set; }
    }
}
