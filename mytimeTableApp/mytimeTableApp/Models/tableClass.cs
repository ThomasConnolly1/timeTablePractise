using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mytimeTableApp.Models
{
    public class tableClass
    {

    }

    public class Students
    {
        public int studentId { get; set; }
        public string  studentName { get; set; }
    }

    public class Course
    {
        public int courseId { get; set; }
        public string courseName { get; set; }
    }

    public class Rooms
    {
        public int roomId { get; set; }
        public string roomName { get; set; }
        public timeIntervals timeSlots { get; set; } // vacancies
    }

     public enum timeIntervals 
    {
       //A = 1,B,C,D,E,F,G,H,I
        morning1, morning2, morning3 //, beforeLunch1, beforeLunch2, beforeLunch3, afterLunch1, afterLunch2, afterLunch3
    };
    
}