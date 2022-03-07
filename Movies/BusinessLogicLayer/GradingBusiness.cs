using DataAccessLayer;
using DataAccessLayer.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    public class GradingBusiness
    {
        private readonly GradingRepository gradingRepository;
        public GradingBusiness()
        {
            this.gradingRepository = new GradingRepository();
        }

        public List<Grading> GetAllGradings()
        {
            return this.gradingRepository.GetAllGradings();
        }

        public Grading GetGradingById(int id, int movieId, int userId)
        {
            return this.gradingRepository.GetAllGradings().FirstOrDefault(g =>
            {
                if(g.Id == id && g.Movie_Id == movieId && g.User_Id == userId)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            });
        }
        public bool UpdateGrading(Grading g)
        {
            if(this.gradingRepository.UpdateGrading(g) > 0)
            {
                return true;
            }
            return false;
        }

        public bool InsertGrading(Grading g)
        {
            if (this.gradingRepository.InsertGrading(g) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteGranding(int Id)
        {
            if (this.gradingRepository.DeleteGrading(Id) > 0)
            {
                return true;
            }
            return false;
        }

        public int AlreadyRated(int movieId, int userId)
        {

            var pom = this.gradingRepository.GetAllGradings().FirstOrDefault(g => g.Movie_Id.Equals(movieId) && g.User_Id.Equals(userId));

            return pom == null ? 0 : pom.Rating;
        }

        public double AverageRate(int movieId)
        {
            var tmp = this.gradingRepository.GetAllGradings().Where(r => r.Movie_Id == movieId).ToList();
            return (tmp.Count() == 0) ? 0 : tmp.Average(m => m.Rating);
        }
    }
}
