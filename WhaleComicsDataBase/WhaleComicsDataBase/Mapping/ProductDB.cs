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
        public Product SelectProductByNumber(int prodNumber)
        {
            query = string.Format("SELECT * FROM [ProductTable] WHERE ProductNumber = {0}", prodNumber);
            base.ExecuteSelect(query);
            if (Plist.Count > 0)
                return Plist[0];
            return null;
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
