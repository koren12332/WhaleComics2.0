using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhaleComicsDataBase
{
    public abstract class BaseDB
    {
        public string connectionString = @"Data Source=DESKTOP-V217OI4\SQLEXPRESS;Initial Catalog=WhaleComicsDataBase;Integrated Security=True";
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataReader reader;
        public BaseDB()
        {
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
        }
        public void Excute(string query)
        {
           try
            {
                command.CommandText = query;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public void ExecuteSelect(string query)
        {
            try
            {
                command.CommandText = query;
                connection.Open();
                reader = command.ExecuteReader();
                CreateModel();
            }
            catch (Exception ex)
            { }
            finally
            {
                connection.Close();
            }
        }

        public abstract void CreateModel();
    }
}
