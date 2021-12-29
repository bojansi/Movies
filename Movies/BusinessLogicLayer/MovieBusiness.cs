using DataAccessLayer;
using DataAccessLayer.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    public class MovieBusiness
    {
        private readonly MovieRepository movieRepository;

        public MovieBusiness() 
        {
            this.movieRepository = new MovieRepository();
        }

        public List<Movie> GetAllMovies()
        {
            return this.movieRepository.GetAllMovies();
        }

        public Movie GetMoviesById(int id)
        {
            return this.movieRepository.GetAllMovies().FirstOrDefault(m => m.Id.Equals(id));
        }



        //return all Movies with requiredGenre
        public List<Movie> GetMovieWithRequiredGenre(bool favorite, String genre)
        {
            List<Movie> list = this.movieRepository.GetAllMovies();
            if(favorite == true)
            {
                list = list.Where(m => m.Favorite == favorite).ToList();
            }
            if(genre != "")
            {
                list = list.Where(m => m.Genre == genre).ToList();
            }
            return list;

        }

        public bool InsertMovie(Movie m)
        {
            if(this.movieRepository.InsertMovie(m) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateMovie(Movie m)
        {
            if (this.movieRepository.UpdateMovie(m) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteMovie(int Id)
        {
            if (this.movieRepository.DeleteMovie(Id) > 0)
            {
                return true;
            }
            return false;
        }

    }
}
