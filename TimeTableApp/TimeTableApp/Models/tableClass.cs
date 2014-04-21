using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeTableApp.Models
{
    public class tableClass
    {
    }

    public class students
    {
        public int studentId { get; set; }
        public string firstName { get; set; }
        
    }

    public class courses
    {
        public int courseId { get; set; }
        public string courseName { get; set; }

    }

    public class rooms
    {
        public int roomId { get; set; }
        public string roomName { get; set; }
    }



}