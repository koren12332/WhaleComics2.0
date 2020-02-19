using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using WhaleComics_2._0.MyService;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
        MethodsClient manager = new MethodsClient();
        public MarvelProductsPage()
        {
            this.InitializeComponent();
            MarvelProducts = new ObservableCollection<MyProduct>();
            InitProducts(MarvelProducts);

            //MarvelProducts.Add(new Product
            //{
            //    ProductImage = "Assets/Photos/thor.png",
            //    ProductName = "Thor",
            //    ProductPrice = "20$"
            //});
            //MarvelProducts.Add(new Product
            //{
            //    ProductImage = "Assets/Photos/BetterSpiderman.jpg",
            //    ProductName = "Spiderman",
            //    ProductPrice = "10$"
            //});
            //MarvelProducts.Add(new Product
            //{
            //    ProductImage = "Assets/Photos/betterFalcon.jpg",
            //    ProductName = "falcon",
            //    ProductPrice = "15$"
            //});

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
                myProduct.ProductPrice = "$"+p.ProductPrice.ToString();
                products.Add(myProduct);
            }
        }

        private void MarvelGrdiView_ItemClick(object sender, ItemClickEventArgs e)
        {

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
