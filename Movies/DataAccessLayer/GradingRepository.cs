using DataAccessLayer.Modals;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
    public class GradingRepository
    {
        //getAllGradings from Table
        public List<Grading> GetAllGradings()
        {
            List<Grading> gradings = new List<Grading>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Grading";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Grading gradin = new Grading();
                    gradin.Id = sqlDataReader.GetInt32(0);
                    gradin.Rating = sqlDataReader.GetInt32(1);
                    gradin.User_Id = sqlDataReader.GetInt32(2);
                    gradin.Movie_Id = sqlDataReader.GetInt32(3);

                    gradings.Add(gradin);
                }
            }
            return gradings;
        }

        //insert new Grading
        public int InsertGrading(Grading g)
        {
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Grading VALUES ('{0}', '{1}', '{2}')", g.Rating, g.User_Id, g.Movie_Id);
                
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
        }

        //update Grading
        public int UpdateGrading(Grading g)
        {
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE Grading SET Rating='{0}', User_Id='{1}', Movie_Id='{3}' WHERE Id='{4}'", g.Rating, g.User_Id, g.Movie_Id, g.Id);

                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int DeleteGrading(int Id)
        {
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("DELETE FROM Grading WHERE Id='{0}'", Id);
                
                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
                
            }
        }
    }
}
