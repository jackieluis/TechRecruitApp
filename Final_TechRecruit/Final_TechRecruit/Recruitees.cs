using System;
namespace Final_TechRecruit
{
    public class Recruitees
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageURL { get; set; }
        public string FullName { get; set; }
        public string Degree { get; set; }
        public string Email { get; set; }
        public string Biography { get; set; }
        public string SchoolAttended { get; set; }
        public string Strengths { get; set; }
        public string Languages { get; set; }
        public string Software { get; set; }
        
        

        public Recruitees(string fn, string ln, string iurl, string deg, string em, string bio, string school, string str, string lang, string sw)
        {
            FirstName = fn;
            LastName = ln;
            FullName = fn + " " + ln;
            ImageURL = iurl;
            Degree = deg;
            Email = em;
            Biography = bio;
            SchoolAttended = school;
            Strengths = str;
            Languages = lang;
            Software = sw;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

    }
}
