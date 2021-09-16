using StudentsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsList.Data
{
    public class SqlGradeRepo : IGradeRepo
    {
        private readonly StudentsListContext _context;

        public SqlGradeRepo(StudentsListContext context)
        {
            _context = context;
        }
        public void CreateGrade(Grade grade)
        {
            if(grade == null)
            {
                throw new ArgumentNullException(nameof(grade));
            }
            _context.Grades.Add(grade);
        }

        public void DeleteGrade(Grade grade)
        {
            if (grade == null)
            {
                throw new ArgumentNullException(nameof(grade));
            }
            _context.Grades.Remove(grade);
        }

        public IEnumerable<Grade> GetAllGrades() => _context.Grades.ToList();


        public Grade GetGradeById(int id) => _context.Grades.FirstOrDefault(p => p.Id == id);
        

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateGrade(Grade grade)
        {
            throw new NotImplementedException();
        }

        
    }
}
