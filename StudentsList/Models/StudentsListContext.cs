using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsList.Models
{
    public class StudentsListContext : DbContext
    {
        
        public StudentsListContext(DbContextOptions<StudentsListContext> options) : base(options)
        {

        }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Student> Students { get; set; }

            
    }
}
