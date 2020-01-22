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
            UserDB uDB = new UserDB();
            ProductDB pDB = new ProductDB();
            User user;
            while (reader.Read())
            {
                user = new User();
                o = new Order();
                string userName = reader["UserName"].ToString();
                o.User = uDB.SelectUserByName(userName);
                int prodNumber = int.Parse(reader["ProductNumber"].ToString());
                o.Product = pDB.SelectProductByNumber(prodNumber);
                o.OrderDate = new DateTime(2020, 1, 1);   //int.Parse(reader["ProductPrice"].ToString());
                o.OrderNumber = int.Parse(reader["OrderNumber"].ToString());
                o.Amount = int.Parse(reader["Amount"].ToString());
                Olist.Add(o);
            }
        }
    }
}
