using Microsoft.EntityFrameworkCore;
using StudentsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsList.Data
{
    public class SqlStudentRepo : IStudentRepo
    {
        private StudentsListContext _context;

        public SqlStudentRepo(StudentsListContext context)
        {
            _context = context;
        }
        public void CreateStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }
            _context.Students.Add(student);
        }

        public void DeleteStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }
            _context.Students.Remove(student);
        }

        public IEnumerable<Student> GetAllStudents() => _context.Students.ToList();

        public Student GetStudentById(int id) => _context.Students.FirstOrDefault(p => p.Id == id);

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public List<Score> GetScores(int id) => _context.Scores.Include(s => s.StudentId).ToList();





    }
}
