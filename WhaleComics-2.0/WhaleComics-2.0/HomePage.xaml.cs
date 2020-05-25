using System;
using System.Collections.Generic;
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
using Windows.Web.Syndication;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WhaleComics_2._0
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        MethodsClient manager = new MethodsClient();
        public HomePage()
        {
            this.InitializeComponent();
            BuildRss();
            //XXX();
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
                int stopCut = imgUrl.IndexOf(".png") + 4;
                //imgUrl = imgUrl.Split('<img src=\"')[1].Split('\" border=\"0\"')[0];
                string feedImgSrc = imgUrl.Substring(startCut, stopCut);
                listTitles.Items.Add(feed.Summary.Text);
            }
        }

        private void ShowWebRss()
        {
            // Continue implements!
        }

        //private async void XXX()
        //{
        //    UserList List = await manager.SelectAllUsersAsync();
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
