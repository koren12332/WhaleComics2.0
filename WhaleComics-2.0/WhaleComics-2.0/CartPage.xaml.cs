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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WhaleComics_2._0
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CartPage : Page
    {
        public ObservableCollection<Product> CartProducts;
        public ObservableCollection<MyCartProduct> MyCartProducts;
        bool flag = true;


        public CartPage()
        {
            this.InitializeComponent();

        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            CartProducts = (ObservableCollection<Product>)e.Parameter;
            if (CartProducts == null)
            {
                var dialog = new MessageDialog("there are no products in your cart.");
                await dialog.ShowAsync();
            }
            else
            {
                BuildMyCartProducts();
            }
        }

        private void BuildMyCartProducts()
        {
            MyCartProducts = new ObservableCollection<MyCartProduct>();
            foreach (Product item in CartProducts)
            {
                MyCartProduct mp = new MyCartProduct();
                mp.ProductImage = item.ProductImage;
                mp.ProductName = item.ProductName;
                mp.ProductPrice = item.ProductPrice;
                mp.CurrQuantity = CartProducts.Count(p => p.ProductName == item.ProductName);
                if (!MyCartProducts.Any(p => p.ProductName == mp.ProductName))
                    MyCartProducts.Add(mp);
            }
            int subTotal = 0;
            foreach (MyCartProduct mp in MyCartProducts)
            {
                subTotal += mp.CurrQuantity * mp.ProductPrice;
            }
            SubtotalTextBlock.Text = "SubTotal: $" + subTotal.ToString();
        }

        private async void MyCartListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (flag)
            {
                MyCartProduct selectedItem = (MyCartProduct)((ListView)sender).SelectedItem;
                string content = "Are you sure you want to remove this item from your cart?";
                string title = "Remove item";
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
                    MyCartProducts.Remove(selectedItem);
                    flag = !flag;
                }
            }
            else
            {

            }
        }

        private void CheckoutButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO:
            //1) check if the quantity in valid.
            Frame.Navigate(typeof(CheckoutPage), MyCartProducts);
        }
    }
    public class MyCartProduct
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public int ProductQuanity { get; set; }
        public int CurrQuantity { get; set; }
    }
}
