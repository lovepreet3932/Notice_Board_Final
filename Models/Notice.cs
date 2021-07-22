using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Notice_Board_Final.Models
{
    //Represents the Notice on the board with  a title and content
    public class Notice
    {
        public int Id { get; set; }

        public string NoticeTitle { get; set; }

        public string NoticeInformation { get; set; }


    }
}
