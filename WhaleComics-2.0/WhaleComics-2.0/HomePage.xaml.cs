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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Syndication;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WhaleComics_2._0
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        ObservableCollection<BitmapIcon> RssPic;
        MethodsClient manager = new MethodsClient();
        public HomePage()
        {
            this.InitializeComponent();
            RssPic = new ObservableCollection<BitmapIcon>();
            BuildRss();
            BuildDailyProduct();
            //XXX();
        }

        private async void BuildDailyProduct()
        {
            int count = await manager.CountProductsAsync();
            if (count > 0)
            {
                Random r = new Random();
                int proId = r.Next(1, count + 1);
                Product dailyProduct = await manager.SelectProductByNumberAsync(proId);
                DailyProName.Text = "Product's Name: " + dailyProduct.ProductName;
                DailyProPrice.Text = "Product's Price: " + dailyProduct.ProductPrice + " $";
                string uriStr = string.Format(@"C:\Users\LENOVO\source\repos\koren12332\WhaleComics2.0\WhaleComics-2.0\WhaleComics-2.0\Assets\Photos\{0}.jpg", dailyProduct.ProductName);
                BitmapImage image = new BitmapImage(new Uri(uriStr, UriKind.RelativeOrAbsolute));
                DailyPic.Source = image;
            }

            
        }

        private async void BuildRss()
        {
            SyndicationClient client = new SyndicationClient();
            Uri RSSuri = new Uri("https://www.popcultcha.com.au/rss/catalog/category/cid/441/store_id/1");
            var feeds = await client.RetrieveFeedAsync(RSSuri);
            foreach (var feed in feeds.Items)
            {
                string imgUrl = feed.Summary.Text;
                int startCut = imgUrl.IndexOf("src") + 5;
                int stopCut = imgUrl.IndexOf("\" border");
                string feedImgSrc = imgUrl.Substring(startCut, stopCut - startCut);
                BitmapIcon myBit = new BitmapIcon();
                myBit.UriSource = new Uri(feedImgSrc);
                RssPic.Add(myBit);
                //listTitles.Items.Add(myImage);
            }
        }

        

        private void ShowWebRss()
        {
            // Continue implements!
        }

        //private async void XXX()
        //{
        //    UserList List = await manager.SelectAl;lUsersAsync();
        //    TestTextBox.Text = List[0].UserName + " " + List[1].UserName;
        //}

        private void FacebookButton_Click(object sender, RoutedEventArgs e)
        {
            //navigate to where you want
            // you can add tooltip.
        }

        private void ProductOfTheDayButton_Click(object sender, RoutedEventArgs e)
        {
            //navigate to the category page of the product.
        }

        private void InstegramButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TwitterButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    
}
