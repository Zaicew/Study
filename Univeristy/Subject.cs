using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univeristy
{
    public class Subject : Iinfo
    {
        public string Name { get; set; }
        public string FieldOfStudy { get; set; }
        public string SpecjalityOfStudy { get; set; }
        public int Semestr { get; set; }
        public int HowManyHours { get; set; }
        public Subject()
        {

        }
        
        public Subject(string name_, string fieldOfStudy_, string specjalityOfStudy_, int semestr_, int howManyHours_)
        {
            this.Name = name_;
            this.FieldOfStudy = fieldOfStudy_;
            this.SpecjalityOfStudy = specjalityOfStudy_;
            this.Semestr = semestr_;
            this.HowManyHours = howManyHours_;
        }

        public virtual string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Subject name: " + Name +", field of study: " + FieldOfStudy + 
                ", specjality: " + SpecjalityOfStudy + ", semestr: " + Semestr + ", it takes: "+ HowManyHours + " hours.");
            return sb.ToString();
        }
    }
}
