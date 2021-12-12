using DataAccessLayer.Modals;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
    public class UserRepository
    {
        public List<User> GetUsers()
        {
            //return list of students
            List<User> users = new List<User>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Users";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    User user = new User();
                    user.Id = sqlDataReader.GetInt32(0);
                    user.Name = sqlDataReader.GetString(1);
                    user.Surname = sqlDataReader.GetString(2);
                    user.Email = sqlDataReader.GetString(3);
                    user.UserName = sqlDataReader.GetString(4);
                    user.Password = sqlDataReader.GetString(5);
                    users.Add(user);
                }


            }
            return users;
        }

        //insert new user

        public int InsertUser(User s)
        {
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Users VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", s.Name, s.Surname, s.Email, s.UserName, s.Password);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }

        //update user
        public int UpdateUser(User s)
        {
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE Users SET Name='{0}', Surname= '{1}', Email='{2}', UserName='{3}', Password= '{4}' WHERE Id= '{5}'", s.Name, s.Surname, s.Email, s.UserName, s.Password, s.Id);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();

            }
        }

        //delete user
        public int DeleteUser(int Id)
        {
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("DELETE FROM Users WHERE Id='{0}'", Id);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
