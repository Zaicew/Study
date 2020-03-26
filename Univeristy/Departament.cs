using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univeristy
{
    class Departament
    {
        List<Unit> unitList = new List<Unit>();
        List<Subject> subjectList = new List<Subject>();
        List<Student> studentList = new List<Student>();

        //public bool AddUnit(string name_, string address_)
        //{
        //    //unitList.Add(new Unit(name_, address_));
        //    return true;
        //}
        public bool AddUnit(string name_, string address_)
        {
            this.unitList.Add(new Unit(name_, address_));
            return true;
        }
        public bool AddUnit(Unit u)
        {
            this.unitList.Add(u);
            return true;
        }
        public bool AddSubject(Subject sub_)
        {
            if (this.subjectList.Contains(sub_))
                return false;
            else
            {
                this.subjectList.Add(sub_);
                //this.subjectList.Add(new Subject(sub_.Name, sub_.FieldOfStudy, sub_.SpecjalityOfStudy, sub_.Semestr, sub_.HowManyHours));
                return true;
            }

        }

        public bool AddStudent(Student stu_)
        {
            if (studentList.Contains(stu_))
                return false;
            else
            {
                studentList.Add(stu_);
                //this.studentList.Add(new Student(stu_.Name, stu_.Surname, stu_.BirthDate, stu_.FieldOfStudy, stu_.SpecjalityOfStudy, stu_.YearOfStudy, stu_.Group, stu_.IndexNumberInCollege));
                return true;
            }

        }

        public bool AddLecturer(Lecturer l, string nameOfUnit_)
        {
            for (int i = 0; i < unitList.Count; i++)
            {
                if (l == null || unitList[i].lecturerList.Contains(l))
                {
                    return false;
                }
                if (unitList[i].Name == nameOfUnit_)
                {
                    unitList[i].AddLecturer(l);
                    return true;
                }
            }
            return false;
        }

        public string StudentsInfo()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < studentList.Count; i++)
            {
                sb.Append($"Student list contains {studentList.Count} records: \n{studentList[i].ShowInfo()}");
            }
            return sb.ToString();
        }
        public string UnitsInfo()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < unitList.Count; i++)
            {
                sb.Append($"Unit list contains {unitList.Count} records: \n{unitList[i].ShowInfo()}");
            }
            return sb.ToString();
        }

        public string SubjectsInfo()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < subjectList.Count; i++)
            {
                sb.Append($"Subject list contains {subjectList.Count} records: \n{subjectList[i].ShowInfo()}");
            }
            return sb.ToString();
        }

        public bool AddGrade(int indexNumber_, string subjectName_, double grade_, DateTime? date_ = null)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].IndexNumberInCollege == indexNumber_)
                {
                    for (int j = 0; j<subjectList.Count; j++)
                    {
                        if (subjectList[j].Name == subjectName_)
                        {
                            studentList[i].AddGrade(subjectList[j], grade_, date_);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool DeleteStudent(int indexNumber)
        {
            for (int i = 0; i<studentList.Count; i++)
            {
                if (studentList[i].IndexNumberInCollege == indexNumber)
                {
                    studentList.Remove(studentList[i]);
                    return true;
                }
            }
            return false;
        }

        public bool TransferLecturer(Lecturer l_, string oldUnit_, string newUnit_)
        {
            if((AddLecturer(l_,newUnit_)) == true)
            { 
                for (int i = 0; i < unitList.Count; i++)
                {
                    if (unitList[i].Name == oldUnit_)
                    {
                        if (unitList[i].DeleteLecturer(l_) == true)
                        {
                            unitList[i].DeleteLecturerEasier(l_);
                            AddLecturer(l_, newUnit_);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
