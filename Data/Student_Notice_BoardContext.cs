using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Student_Notice_Board_Final.Models;

namespace Student_Notice_Board_Final.Models
{
    public class Student_Notice_BoardContext : DbContext
    {
        public Student_Notice_BoardContext (DbContextOptions<Student_Notice_BoardContext> options)
            : base(options)
        {
        }

        public DbSet<Student_Notice_Board_Final.Models.Notice> Notice { get; set; }

        public DbSet<Student_Notice_Board_Final.Models.NoticeView> NoticeView { get; set; }

        public DbSet<Student_Notice_Board_Final.Models.Student> Student { get; set; }
    }
}
