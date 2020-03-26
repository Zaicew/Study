using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univeristy
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Code in Main is not mine. Someone put the task on the internet and sent the code as a test. 
             * 
             */
            string[] names = { "Jacek", "Marek", "Iwona", "Jola", "Tomek", "Wojtek" };
            string[] surnames = { "Kowalski", "Nowak", "Marchewka", "Zaręba", "Młotek", "Kleszcz" };
            string[] subjects = { "Programowanie Obiektowe", "Sieci", "Grafika Rastrowa", "Angielski", "Aplikacje WWW" };
            string[] units = { "IISI", "KIK", "ICIS" };
            string[] title = { "dr", "dr inż.", "prof.", "prof. inż.", "inż." };
            Random rnd = new Random();

            Departament w = new Departament();

            {
                // przedmioty
                subjects.ToList().ForEach(a => w.AddSubject(
                    new Subject(a, "Informatyka", "Inżynieria Oprogramowania", rnd.Next(1, 7), rnd.Next(1, 3) * 15)
                ));
                // studenci
                for (int i = 1000; i < 1020; i++)
                    w.AddStudent(new Student(
                        names[rnd.Next(names.Length)],
                        surnames[rnd.Next(surnames.Length)],
                        DateTime.Now.AddYears(-27).AddDays(rnd.Next(365 * 4)),
                        "Informatyka", "Inżynieria Oprogramowania", rnd.Next(1, 4), rnd.Next(1, 10), i
                    ));
                //jednostki
                units.ToList().ForEach(a =>
                {
                    var j = new Unit(a, "Dąbroskiwgo 69");
                    w.AddUnit(j);
                    for (int i = 0; i < 3; i++)
                        j.AddLecturer(new Lecturer(
                            names[rnd.Next(names.Length)],
                            surnames[rnd.Next(surnames.Length)],
                            DateTime.Now.AddYears(-47).AddDays(rnd.Next(365 * 14)),
                            title[rnd.Next(title.Length)],
                            ""
                        ));
                }
                );
                //oceny
                for (int i = 0; i < 200; i++)
                    w.AddGrade(
                        rnd.Next(1000, 1020),
                        subjects[rnd.Next(subjects.Length)],
                        rnd.Next(2, 5),
                        DateTime.Now.AddDays(-rnd.Next(2, 360 * 3))
                    );
            }

            // szuka liste i wypisuje
            //w.Filtruj<Student>(s => s.grupa == 4).ForEach(s=>s.WypiszInfo(false));
            // wypisuje studentów z ocenami
            //w.Info<Student>(true, s => s.srednia > 0);
            // dodaje studenta
            //w.Dodaj(new Student("Ela", "Nowa", null, "IO", "Informatyka", 2, 4, 123));

            Console.WriteLine("\nStudenci:");
            Console.WriteLine(w.StudentsInfo());
            Console.WriteLine("\nJednostki i pracownicy:");
            Console.WriteLine(w.UnitsInfo());
            Console.WriteLine("\nPrzedmioty:");
            Console.WriteLine(w.SubjectsInfo());
            Console.WriteLine("\n\nStudenci lat 1-2:");
            Console.WriteLine(w.StudentsInfo());


            //{
            //    Console.WriteLine("\n\nOceny z Sieci roku 2:");
            //    var p = w.Znajdz<Przedmiot>(a => a.nazwa == "Sieci");
            //    p.WypiszInfo(false);
            //    w.Filtruj<Student>(s => s.rok == 2)
            //        .ForEach(s => Console.WriteLine($"{s.nrIndeksu}: {s[p]}"));
            //}

            //Console.WriteLine("\n\nPrzedmioty rok 1:");
            //w.SubjectsInfo(false, a => a.rok == 1);


            //{
            //    var wyk = new Wykladowca("<Jacek>", nazwiska[0], DateTime.Now, tytul[0], "");
            //    var j = w.Znajdz<Jednostka>(a => a.nazwa == "KIK").DodajWykladowce(wyk);
            //    Console.WriteLine("\n\nJednosti:");
            //    w.UnitsInfo(true);
            //    Console.WriteLine(w.TransferLecturer(wyk, "KIK", "IISI"));
            //    Console.WriteLine("\n\nJednosti:");
            //    w.UnitsInfo(true);
            //}
            Console.ReadKey();
        }
    }
}
