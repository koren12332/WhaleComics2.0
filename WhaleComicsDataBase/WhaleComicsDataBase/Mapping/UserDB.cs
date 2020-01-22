using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhaleComicsDataBase
{
    public class UserDB : BaseDB
    {
        public UserList Ulist;
        public string query;
        public UserDB()
        {

            Ulist = new UserList();
        }
        public UserList SelectAllUsers()
        {
            query = "SELECT * FROM [UserTable]";
            base.ExecuteSelect(query);
            return Ulist;
        }
        public User SelectUserByName(string name)
        {
            query = string.Format("SELECT * FROM [UserTable] WHERE UserName = '{0}'", name);
            base.ExecuteSelect(query);
            if (Ulist.Count > 0)
                return Ulist[0];
            return null;
        }

        public User SelectUserByNameAndPassword(string name, string pass)
        {
            query = string.Format("SELECT * FROM [UserTable] WHERE UserName = '{0}' AND UserPassword = '{1}'", name,pass);
            base.ExecuteSelect(query);
            if (Ulist.Count > 0)
                return Ulist[0];
            return null;
        }

        public override void CreateModel()
        {
            Ulist.Clear();
            User u;
            while (reader.Read())
            {
                u = new User();
                u.UserName = reader["UserName"].ToString();
                u.UserAddress = reader["UserAddress"].ToString();
                u.UserEmail = reader["UserEmail"].ToString();
                u.UserPassword = reader["UserPassword"].ToString();
                u.UserPhoneNumber = reader["UserPhoneNumber"].ToString();
                Ulist.Add(u);
            }
        }
    }
}
