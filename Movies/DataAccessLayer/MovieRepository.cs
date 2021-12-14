using DataAccessLayer.Modals;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
    public class MovieRepository
    {
        //get all Movies
        List<Movie> GetAllMovies()
        {
            List<Movie> movies = new List<Movie>();

            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Movies";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Movie movie = new Movie();
                    movie.Id = sqlDataReader.GetInt32(0);
                    movie.Name = sqlDataReader.GetString(1);
                    movie.Year = sqlDataReader.GetInt32(2);
                    movie.Genre = sqlDataReader.GetString(3);
                    movie.Favorite = sqlDataReader.GetBoolean(4);
                    movie.IMDBLink = sqlDataReader.GetString(5);
                    movie.Description = sqlDataReader.GetString(6);

                    movies.Add(movie);
                }
            }
            return movies;
        }

        //insert new movie
        public int InsertMovie(Movie m)
        {
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Movies VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", m.Name, m.Year, m.Genre, m.Favorite, m.IMDBLink, m.Description);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }

        //insert new Movie
        public int UpdateMovie(Movie m)
        {
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE Movies Name='{0}', Year='{1}', Genre='{2}', Favorite= '{3}', IMDBLink='{4}', Description='{5}' WHERE Id='{6}'", m.Name, m.Year, m.Genre, m.Favorite, m.IMDBLink, m.Description);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }

        //delete Movie
        public int DeleteMovie(int Id)
        {
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("DELETE FROM Movies WHERE Id='{0}'", Id);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
        
    }
}
