using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalSite
{
    public class Address
    {
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
    }

    public class Social
    {
        public string name { get; set; }
        public string url { get; set; }
        public string className { get; set; }
    }

    public class Main
    {
        public string name { get; set; }
        public string occupation { get; set; }
        public string image { get; set; }
        public string bio { get; set; }
        public string contactmessage { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public Address address { get; set; }
        public string website { get; set; }
        public string resumedownload { get; set; }
        public List<Social> social { get; set; }
    }

    public class Education
    {
        public string school { get; set; }
        public string degree { get; set; }
        public string graduated { get; set; }
        public string description { get; set; }
        public string gpa { get; set; }
        public string courses { get; set; }
    }

    public class Work
    {
        public string company { get; set; }
        public string title { get; set; }
        public string years { get; set; }
        public string description { get; set; }
        public string duties { get; set; }
    }

    public class Skill
    {
        public string name { get; set; }
        public string level { get; set; }
    }

    public class Resume
    {
        public string skillmessage { get; set; }
        public List<Education> education { get; set; }
        public List<Work> work { get; set; }
        public List<Skill> skills { get; set; }
        public string designLang { get; set; }
        public string consepts { get; set; }
        public string tools { get; set; }
        public string frameworks { get; set; }
        public string databases { get; set; }
        public string libraries { get; set; }
    }

    public class Project
    {
        public string title { get; set; }
        public string category { get; set; }
        public string image { get; set; }
        public string url { get; set; }
    }

    public class Portfolio
    {
        public List<Project> projects { get; set; }
    }

    public class Testimonial
    {
        public string text { get; set; }
        public string user { get; set; }
    }

    public class Testimonials
    {
        public List<Testimonial> testimonials { get; set; }
    }

    public class ResumeData
    {
        public Main main { get; set; }
        public Resume resume { get; set; }
        public Portfolio portfolio { get; set; }
        public Testimonials testimonials { get; set; }
        public TeachingExpreiences teachingExpreiences { get; set; }
    }
    public class TeachingExpreience
    {
        public string year { get; set; }
        public string instructor { get; set; }
        public string course { get; set; }
        public string title { get; set; }
        public string institue { get; set; }
    }
    public class Talk
    {
        public string subject { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public string link { get; set; }
    }
    public class TeachingExpreiences
    {
        public List<TeachingExpreience> expreiences { get; set; }
        public List<Talk> talks { get; set; }
    }
}
