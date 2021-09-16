using Microsoft.AspNetCore.Mvc;
using StudentsList.Data;
using StudentsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsList.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepo _students;
        private readonly IScoreRepo _scores;
        private readonly IGradeRepo _grades;

        public HomeController(IStudentRepo students,IScoreRepo scores, IGradeRepo grades)
        {
            _students = students;
            _scores = scores;
            _grades = grades;
        }
        public IActionResult Index()
        {
            var scor = _scores.GetAllScores();
            var list = _students.GetStudentById(1).Scores;
            return View();
        }
    }
}
