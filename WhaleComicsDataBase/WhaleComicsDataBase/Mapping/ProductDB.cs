using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhaleComicsDataBase
{
    public class ProductDB : BaseDB
    {
        public ProductList Plist;
        public string query;
        public ProductDB()
        {
            Plist = new ProductList();
        }
        public ProductList SelectAllProduct()
        {
            query = "SELECT * FROM [ProductTable]";
            base.ExecuteSelect(query);
            return Plist;
        }
        public override void CreateModel()
        {
            Plist.Clear();
            Product p;
            while (reader.Read())
            {
                p = new Product();
                p.ProductName = reader["ProductName"].ToString();
                p.ProductType = reader["ProductType"].ToString();
                p.ProductPrice = int.Parse(reader["ProductPrice"].ToString());
                p.ProductQuanity = int.Parse(reader["ProductQuanity"].ToString());
                p.ProductNumber = int.Parse(reader["ProductNumber"].ToString());
                Plist.Add(p);
            }
        }
    }
}
