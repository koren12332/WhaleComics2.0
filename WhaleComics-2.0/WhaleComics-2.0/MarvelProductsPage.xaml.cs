using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        public List<Product> MarvelProducts;
        public MarvelProductsPage()
        {
            this.InitializeComponent();
            MarvelProducts = new List<Product>();

            MarvelProducts.Add(new Product
            {
                ProductImage = "Assets/Photos/thor.png",
                ProductName = "Thor",
                ProductPrice = "20$"
            });
            MarvelProducts.Add(new Product
            {
                ProductImage = "Assets/Photos/BetterSpiderman.jpg",
                ProductName = "Spiderman",
                ProductPrice = "10$"
            });
            MarvelProducts.Add(new Product
            {
                ProductImage = "Assets/Photos/betterFalcon.jpg",
                ProductName = "falcon",
                ProductPrice = "15$"
            });

        }
        private void MarvelGrdiView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
