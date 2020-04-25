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
            Uri RSSuri = new Uri("https://www.reddit.com/r/Funko/.rss");
            var feeds = await client.RetrieveFeedAsync(RSSuri);
            foreach (var feed in feeds.Items)
            {
                listTitles.Items.Add(feed.Title.Text);
            }

        }

        private async void XXX()
        {
            UserList List = await manager.SelectAllUsersAsync();
            TestTextBox.Text = List[0].UserName + " " + List[1].UserName;
        }

        private void FacebookButton_Click(object sender, RoutedEventArgs e)
        {
            //navigate to where you want
            // you can add tooltip.
        }
    }
        
}
