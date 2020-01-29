using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WhaleComicsDataBase;

namespace WhaleComics
{
    [ServiceContract]
    public interface IMethods
    {
        //Users Methods
        [OperationContract]
        UserList SelectAllUsers();
        [OperationContract]
        User SelectUserByName(string name);
        [OperationContract]
        void InsertNewUser(User u);

        //Product Methods


        //Order Methods
    }
}
