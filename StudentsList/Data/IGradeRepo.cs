using StudentsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsList.Data
{
    public interface IGradeRepo
    {
        bool SaveChanges();
        IEnumerable<Grade> GetAllGrades();
        Grade GetGradeById(int id);
        void CreateGrade(Grade grade);
        void UpdateGrade(Grade grade);
        void DeleteGrade(Grade grade);
    }
}
