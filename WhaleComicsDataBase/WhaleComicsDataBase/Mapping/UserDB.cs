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
