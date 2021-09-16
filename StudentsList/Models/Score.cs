using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsList.Models
{
    public class Score
    {
        public long Id { get; set; }
        public string LessonName { get; set; }
        public int ScoreValue { get; set; }
        [Column(TypeName = "date")]
        public DateTime ScoreDate { get; set; }
        [ForeignKey("StudentId")]
        public long StudentId { get; set; }
        public virtual Student Student { get; set; }

    }
}
