using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim6_lek2
{
    internal class Person
    {
        //поля всі закриті
        string lastname = "", status = "", health = "";
        int age = 0;
        double salary = 0.0;
        //Методи властивості
        //стратегія Read,Write-once
        //Читання, запис при першому звернені
        public string LastName
        {
            set { if (lastname=="")
                lastname = value; }
            get { return lastname; }
        }
        //стратегія Read only
        //Лише читання
        public string Status
        {
            get { return status; }
        }
        //стратегія Read ,Write
        //Читання та запис
        public int Age
        {   set
            {
                if ( value<0)
                {
                    throw new IndexOutOfRangeException($"{nameof(Age)} <0");
                }
                age = value;
                if (age < 7) status = "дитина";
                else if (age < 17) status = "школяр";
                else if (age < 22) status = "студент";
                else status = "доросла людина, що працює";
            }
            get { return age; } 
        }
        //стратегія Write only
        //Лише запиc
        public double Salary
        {
            set {
                if (value < 10000)
                {
                    throw new IndexOutOfRangeException($"{nameof(Salary)} <10000");
                }
                salary = value; }
        }
        public string Health
        { get; set; }
    }
}
