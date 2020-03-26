using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univeristy
{
    class Unit : Iinfo
    {
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public List<Lecturer> lecturerList = new List<Lecturer>();

        public Unit()
        {

        }

        public Unit(string name_, string address_)
        {
            this.Name = name_;
            this.Address = address_;
        }

        public void AddLecturer(Lecturer l_)
        {
            this.lecturerList.Add(new Lecturer(l_.Name, l_.Surname, l_.BirthDate, l_.AcademicTitle, l_.Position));
        }

        public bool DeleteLecturer(Lecturer l_)
        {
            for(int i = 0; i<lecturerList.Count; i++)
            {
                if (l_ == lecturerList[i])
                {
                    lecturerList.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public bool DeleteLecturerEasier(Lecturer l_)
        {
            return lecturerList.Remove(l_);
        }

        public string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} {Address}, This unit has {lecturerList.Count} lecturers. \nLecturers: ");
            for (int i = 0; i<lecturerList.Count; i++)
            {
                sb.Append
                    (
                    "\t\nName: " + lecturerList[i].Name +
                    ", surname: " + lecturerList[i].Surname +
                    ", academic title: " + lecturerList[i].AcademicTitle +
                    ", position : " + lecturerList[i].Position
                    );
            }
            return sb.ToString();
        }
        public string LecturersInfo()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine($"Lecturers: ({lecturerList.Count}):");
            lecturerList.ForEach(a => Console.WriteLine($"\tName: {a.Name}, surname {a.Surname}, academic title: {a.AcademicTitle}, postition: {a.Position}"));

            return sb.ToString();
        }


        //public void InfoWykladowcy()
        //{
        //    Console.WriteLine($"Lecturers: ({lecturerList.Count}):");
        //    lecturerList.ForEach(a => Console.WriteLine($"\t{a}"));
        //}
    }
}
