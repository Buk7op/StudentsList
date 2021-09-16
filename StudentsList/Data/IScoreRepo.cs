using StudentsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsList.Data
{
    public interface IScoreRepo
    {
        bool SaveChanges();
        IEnumerable<Score> GetAllScores();
        Score GetScoreById(int id);
        void CreateScore(Score score);
        void UpdateScore(Score score);
        void DeleteScore(Score score);

    }
}
