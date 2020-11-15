using System;

namespace Course
{
    public class Cource
    {
        String courseName;
        String courseCode;
        int courseCredit;
        public String CourseName
        {
            set { courseName = value; }
            get { return courseName; }
        }
        public String CourseCode
        {
            set { courseCode = value; }
            get { return courseCode; }
        }
        public int CoursrCredit
        {
            set { courseCredit = value; }
            get { return courseCredit; }
        }
        public  void ShowInfo()
        {
            Console.WriteLine("Course Name:" + courseName);
            Console.WriteLine("Course Code:"+courseCode);
            Console.WriteLine("Course Credit:"+courseCredit);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Cource c = new Cource();
            c.CourseName = "OOP2";
            c.CourseCode = "152-36-65";
            c.CoursrCredit = 3;
            c.ShowInfo();
        }
    }
}
