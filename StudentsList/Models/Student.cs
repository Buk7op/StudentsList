using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsList.Models
{
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public List<Score> Scores { get; set; }
        [ForeignKey("GradeId")]
        public long GradeId { get; set; }
        public virtual Grade Grade { get; set; }
    }
}
