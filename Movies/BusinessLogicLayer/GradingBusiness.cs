using DataAccessLayer;
using DataAccessLayer.Modals;
using System;
using System.Collections.Generic;
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
    }
}
