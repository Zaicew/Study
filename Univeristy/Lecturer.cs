using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univeristy
{
    class Lecturer : Person
    {
        public string AcademicTitle { get; set; } = "";
        public string Position { get; set; } = "";

        public Lecturer()
        {

        }

        public Lecturer(string name_, string surname_, DateTime birthDate_, string academicTitle_, string position_)
            :base(name_,surname_,birthDate_)
        {
            this.AcademicTitle = academicTitle_;
            this.Position = position_;
        }

        public override string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ShowInfo() + ", academic title: " + AcademicTitle + ", position: " + Position);
            return sb.ToString();
        }
    }
}
