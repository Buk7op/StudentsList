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
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StudentsListContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StudentsListContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            
            if (!context.Grades.Any())
            {
                context.Grades.AddRange(
                    new Grade
                    {
                        GradeNumber = 9,
                        TeacherName = "Петрова Ирина Леонидовна"
                    },
                    new Grade
                    {
                        GradeNumber = 10,
                        TeacherName = "Толпегин Олег Ссаныч"
                    },
                    new Grade
                    {
                        GradeNumber = 11,
                        TeacherName = "Зазимко Владлен Ссаныч"
                    }
                    );
                context.SaveChanges();
                context.Students.AddRange(
                    new Student
                    {
                        Name = "Petr",
                        LastName = "Orlov",
                        SecondName = "Pector",
                        GradeId = 1
                    },
                    new Student
                    {
                        Name = "Ivan",
                        LastName = "Ivanov",
                        SecondName = "Ivanovich",
                        GradeId = 2
                    },
                    new Student
                    {
                        Name = "Artem",
                        LastName = "Kirillov",
                        SecondName = "Starostovich",
                        GradeId = 3
                    }
                    );
                context.SaveChanges();
                context.Scores.AddRange(
                    new Score
                    {
                        LessonName = "Algebra",
                        ScoreDate = DateTime.Parse("2021-10-10"),
                        ScoreValue = 5,
                        StudentId = 1
                    },
                    new Score
                    {
                        LessonName = "English",
                        ScoreDate = DateTime.Parse("2021-10-10"),
                        ScoreValue = 5,
                        StudentId = 1
                    },
                    new Score
                    {
                        LessonName = "Physic",
                        ScoreDate = DateTime.Parse("2021-10-10"),
                        ScoreValue = 5,
                        StudentId = 1
                    },
                    new Score
                    {
                        LessonName = "Geography",
                        ScoreDate = DateTime.Parse("2021-10-10"),
                        ScoreValue = 5,
                        StudentId = 1
                    },
                    new Score
                    {
                        LessonName = "Algebra",
                        ScoreDate = DateTime.Parse("2021-11-10"),
                        ScoreValue = 4,
                        StudentId = 2
                    },
                    new Score
                    {
                        LessonName = "English",
                        ScoreDate = DateTime.Parse("2021-12-10"),
                        ScoreValue = 3,
                        StudentId = 2
                    },
                    new Score
                    {
                        LessonName = "Physic",
                        ScoreDate = DateTime.Parse("2021-10-09"),
                        ScoreValue = 2,
                        StudentId = 3
                    },
                    new Score
                    {
                        LessonName = "Geography",
                        ScoreDate = DateTime.Parse("2021-11-10"),
                        ScoreValue = 3,
                        StudentId = 3
                    }
                    );
                context.SaveChanges();
            }

        }

    }
}
