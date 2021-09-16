using StudentsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace StudentsList.Data
{
    public static class SeedData
    {
        //public static void EnsurePopulated(IApplicationBuilder app, IStudentRepo students, IGradeRepo grades, IScoreRepo scores)
        //{
            


        //    StudentsListContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StudentsListContext>();
        //    if (context.Database.GetPendingMigrations().Any())
        //    {
        //        context.Database.Migrate();
        //    }

        //    if (!context.Students.Any())
        //    {
        //        context.Students.AddRange(
        //            new Student
        //            {
        //                Name = "Сергей",
        //                LastName = "Светличный",
        //                SecondName = "Дмитриевич",
        //                Grade = grades.GetGradeById(1)
        //            }
        //            );
        //    }
            
        //    if (!context.Grades.Any())
        //    {
        //        context.Grades.AddRange(
        //            new Grade
        //            {
        //                GradeNumber = 9,
        //                TeacherName = "Петрова Ирина Леонидовна"
        //            }
                    
                    
                    
                    
        //            );
        //    }

        //}

    }
}
