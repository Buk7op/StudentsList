using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsList.Models
{
    public class Grade
    {
        public long Id { get; set; }
        public int GradeNumber { get; set; }
        public string TeacherName { get; set; }
        
        public List<Student> Students { get; set; } 
    }
}
