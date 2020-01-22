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
    public sealed partial class FunkoPopPage : Page
    {
        public List<Genre> FunkoPops;
        public FunkoPopPage()
        {
            this.InitializeComponent();
            FunkoPops = new List<Genre>();
            FunkoPops.Add(new Genre { GenreIcon = "Assets/Photos/ironman.jpg", GenreCategory = "Marvel" });
            FunkoPops.Add(new Genre { GenreIcon = "Assets/Photos/batman.jpg", GenreCategory = "DC" });
            FunkoPops.Add(new Genre { GenreIcon = "Assets/Photos/harrypotter.jpg", GenreCategory = "HP" });
        }

        private void GenresListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selectedFunko = (Genre)e.ClickedItem;
            if (selectedFunko.GenreCategory.Equals("Marvel"))
                this.Frame.Navigate(typeof(MarvelProductsPage));
        }
    }
}
