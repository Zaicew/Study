using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univeristy
{
    public class Student : Person 
    {
        List<FinalGrade> gradesList = new List<FinalGrade>();
        public string FieldOfStudy { get; private set; } = "";
        public string SpecjalityOfStudy { get; private set; } = "";
        public int YearOfStudy { get; private set; } = 0;
        public int Group { get; private set; } = 0;
        public int IndexNumberInCollege { get; private set; } = 0;
        public double Average
        {
            get
            {
                double s = 0;
                gradesList.ForEach(a => s += a.Grade);
                return gradesList.Count == 0 ? 0 : s / gradesList.Count;
            }
        }
        

        public Student()
        {

        }

        public Student(string name_, string surname_, DateTime birthDate_, string fieldOfStudy_, string specjalityOfStudy_, int yearOfStudy_, int group_, int indexNumberInCollege_)
            :base(name_, surname_, birthDate_)
        {
            this.FieldOfStudy = fieldOfStudy_;
            this.SpecjalityOfStudy = specjalityOfStudy_;
            this.YearOfStudy = yearOfStudy_;
            this.Group = group_;
            this.IndexNumberInCollege = indexNumberInCollege_;
        }

        public bool AddGrade(Subject s_, double grade_ = 2.0, DateTime? date_ = null)
        {
            //if (this.[s_] == null) -> co to wgl jest - przeanalizuj

            if (s_.Name == null)
                return false;
            else
            {
                this.gradesList.Add(new FinalGrade(s_, grade_, date_));
                return true;
            }
        }


        //public bool AddGrade2(string subjectName, double grade_ = 2.0, DateTime? date_ = null)
        //{
        //    for (int i = 0; i<gradesList.Count; i++)
        //    {
        //        if (gradesList[i].Subject.Name == subjectName)
        //        {
        //            this.gradesList.Add(new FinalGrade()
        //        }
        //    }


        //    if (s_.Name == null)
        //        return false;
        //    else
        //    {

        //        return true;
        //    }
        //}

        public void ShowAverage()
        {
            Console.Write(this.Average);
        }

        public override string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ShowInfo() + ", field of study: " + FieldOfStudy +
                ", specjality: " + SpecjalityOfStudy + ", year of study: " + YearOfStudy +
                ", group: " + Group + ", index number: " + IndexNumberInCollege + "\nGrades: " + GradesInfo());

            return sb.ToString();
        }

        public string GradesInfo()
        {
            StringBuilder sb = new StringBuilder();
            if (gradesList.Count == 0)
            {
                sb.Append("No grades!");
                return sb.ToString();
            }
            else
            {
                for (int i = 0; i < gradesList.Count; i++)
                {
                    sb.Append("\nName of subject: " + gradesList[i].Subject.Name + ", grade: " + gradesList[i].Grade + ", date: " + gradesList[i].Date);
                }
                sb.Append("\nGrades average: " + Average);
                return sb.ToString();
            }
        }
    }
}
