using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Notice_Board_Final.Models
{
    //Notice View created when a student views the notice
    public class NoticeView
    {
        public int Id { get; set; }
        public int NoticeId { get; set; }

        public int StudentId { get; set; }

        public Notice Notice { get; set; }

        public Student Student { get; set; }
    }
}
