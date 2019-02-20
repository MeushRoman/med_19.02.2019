using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedEgov.Model
{
    public abstract class People
    {
        public int id { get; set; }
        public People() { }
        public People(string name, string surname, string middleName = "")
        {
            this.name = name;
            this.surname = surname;
            this.middleName = middleName;
        }

        public string name { get; set; }
        public string surname { get; set; }
        public string middleName { get; set; }
        public DateTime dob { get; set; }
        public int age {
            get
            {
                return DateTime.Now.Year - dob.Year;
            }
        }
        public virtual void PrintSecNumber()
        {
            Random rnd = new Random();
            Console.WriteLine(rnd.Next());
        }
        public virtual void printInfo()
        {
            Console.WriteLine("{0} {1}. {2}.\n", name, surname[0], middleName[0]);
        }

        public abstract double GetDiscount();
    }
}
