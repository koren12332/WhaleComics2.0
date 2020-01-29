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
    }
}
