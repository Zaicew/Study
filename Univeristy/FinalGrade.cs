using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univeristy
{
    public class FinalGrade : Iinfo
    {
        public Subject Subject { get; private set; }
        public double Grade { get; private set; }
        public DateTime Date { get; private set; }

        public FinalGrade(Subject p, double grade_ = 2.0, DateTime? date_ = null)
        {
            this.Subject = p;
            this.Grade = grade_;
            if (date_ == null)
                this.Date = DateTime.Now;
            else
                this.Date = (DateTime)date_;
        }

        public string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Subject: " + Subject.Name + ", grade: " + Grade + ", date: " + Date);
            return sb.ToString();
        }
    }
}
