using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhaleComics_2._0.MyService;

namespace WhaleComics_2._0
{
    public class Genre
    {

        public string GenreIcon { get; set; }
        public string GenreCategory { get; set; }
    }
    public static class AllKnowMe
    {
        public static ObservableCollection<Product> AllMyProducts;
        public static User CurrUser;
    }
}
