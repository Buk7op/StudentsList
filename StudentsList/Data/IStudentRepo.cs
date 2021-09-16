using StudentsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsList.Data
{
    public interface IStudentRepo
    {
        bool SaveChanges();
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
        List<Score> GetScores(int id);
        void CreateStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(Student student);
    }
}
