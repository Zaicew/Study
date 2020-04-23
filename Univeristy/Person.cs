using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univeristy
{
    public class Person : Iinfo
    {
        public string Name { get; protected set; }
        public string Surname { get; protected set; }
        public DateTime BirthDate { get; protected set; }
    public Person()
        {

        }

        public Person(string name_, string surname_, DateTime? birthDate_ = null)
        {
            this.Name = name_;
            this.Surname = surname_;
            this.BirthDate = birthDate_ != null ? (DateTime)birthDate_ : DateTime.Now;
        }

        public virtual string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Person name: " + Name + ", surname: " + Surname + ", birth date: " + BirthDate.ToShortDateString());
            return sb.ToString();
        }

    }
}
