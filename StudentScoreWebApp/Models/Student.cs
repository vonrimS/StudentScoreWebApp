using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentScoreWebApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        private string _FullName { get; set; }
        public string FullName
        {
            get { return _FullName; }
            set { _FullName = LastName + " " + FirstName + " " + SecondName; }
        }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public int Score3 { get; set; }
        public int Score4 { get; set; }
        private int _TotalScore { get; set; }
        public int TotalScore
        {
            get { return _TotalScore; }
            set { _TotalScore = Score1 + Score2 + Score3 + Score4; }
        }
        public Student()
        {
            Score1 = Score2 = Score3 = Score4 = 0;
        }
    }
}