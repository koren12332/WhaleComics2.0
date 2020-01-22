using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhaleComicsDataBase
{
    public class OrderDB : BaseDB
    {
        public OrderList Olist;
        public string query;
        public OrderDB()
        {
            Olist = new OrderList();
        }
        public OrderList SelectAllProduct()
        {
            query = "SELECT * FROM [OrderTable]";
            base.ExecuteSelect(query);
            return Olist;
        }
        public override void CreateModel()
        {
            Olist.Clear();
            Order o;
            while (reader.Read())
            {
                o = new Order();
                //o.User = reader["ProductName"].ToString();
                //o.Product = reader["ProductType"].ToString();
                //o.OrderDate = int.Parse(reader["ProductPrice"].ToString());
                o.OrderNumber = int.Parse(reader["ProductQuanity"].ToString());
                o.Amount = int.Parse(reader["ProductNumber"].ToString());
                Olist.Add(o);
            }
        }
    }
}
