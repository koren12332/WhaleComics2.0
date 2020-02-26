using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhaleComicsDataBase;

namespace WhaleComics
{
    public class Methods : IMethods
    {
        UserDB uDB = new UserDB();
        ProductDB pDB = new ProductDB();
        OrderDB oDB = new OrderDB();

        //User methods
        public void InsertNewUser(User u)
        {
            uDB.InsertNewUser(u);
        }       
        public UserList SelectAllUsers()
        {
            return uDB.SelectAllUsers();
        }
        public User SelectUserByName(string name)
        {
            return uDB.SelectUserByName(name);
        }
        public User SelectUserByNameAndPassword(string name, string pass)
        {
            return uDB.SelectUserByNameAndPassword(name, pass);
        }

        //Product methods
        public Product SelectProductByName(string name)
        {
            return pDB.SelectProductByName(name);
        }
        public ProductList SelectAllProduct()
        {
            return pDB.SelectAllProduct();
        }
        public Product SelectProductByNumber(int prodNumber)
        {
            return pDB.SelectProductByNumber(prodNumber);
        }
    }
}
