using Microsoft.AspNetCore.Mvc;
using StudentsList.Data;
using StudentsList.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsList.Controllers
{
    public class TasksController : Controller
    {
        private readonly IStudentRepo _students;
        private readonly IScoreRepo _scores;
        private readonly IGradeRepo _grades;

        public TasksController(IStudentRepo students, IScoreRepo scores, IGradeRepo grades)
        {
            _students = students;
            _scores = scores;
            _grades = grades;
        }
        [Route("task/1")]
        public IActionResult SolutionOne()
        {
            var scores = _scores.GetAllScores();
            var listOfStudents = _students.GetAllStudents();
            return View(listOfStudents);
        }
        [Route("task/2")]
        public IActionResult SolutionTwo()
        {
            var scores = _scores.GetAllScores();
            var listOfStudents = _students.GetAllStudents();
            return View(listOfStudents);
        }
        [Route("task/3")]
        public IActionResult SolutionThree()
        {
            var scores = _scores.GetAllScores();
            var listOfStudents = _students.GetAllStudents();
            var grades = _grades.GetAllGrades();
            var list1 = from grade in grades
                        join student in listOfStudents on grade.Id equals student.GradeId into StudentsInGrade
                        from student in StudentsInGrade.DefaultIfEmpty()
                        select new { grade.GradeNumber, student.Name, avg = student.Scores.Average(m => m.ScoreValue) };
            var gradesWithAvgs = from item in list1
                        group item by new { number = item.GradeNumber } into grouped
                        select new GradesWithAvg
                        {
                            Group = grouped.Key.number,
                            AvgScore = grouped.Average(x => x.avg)
                        };
            gradesWithAvgs = gradesWithAvgs.OrderByDescending(g => g.AvgScore);
            return View(gradesWithAvgs);
        }
    }
}
