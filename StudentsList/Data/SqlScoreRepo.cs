using StudentsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsList.Data
{
    public class SqlScoreRepo : IScoreRepo
    {
        private readonly StudentsListContext _context;

        public SqlScoreRepo(StudentsListContext context)
        {
            _context = context;
        }
        public void CreateScore(Score score)
        {
            if (score == null)
            {
                throw new ArgumentNullException(nameof(score));
            }
            _context.Scores.Add(score);
        }

        public void DeleteScore(Score score)
        {
            if (score == null)
            {
                throw new ArgumentNullException(nameof(score));
            }
            _context.Scores.Remove(score);
        }

        public IEnumerable<Score> GetAllScores() => _context.Scores.ToList();
        

        public Score GetScoreById(int id) => _context.Scores.FirstOrDefault(p => p.Id == id);
        

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateScore(Score score)
        {
            throw new NotImplementedException();
        }
    }
}
