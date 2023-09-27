using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim7_lek2
{
    internal class People
    {
        Person[] data;
        public People()
        {
            var rnd = new Random();
            var n = rnd.Next(5, 20);
            data = new Person[n];
        }
        public People(int n)
        {
            data = new Person[n];
        }
        //Індексатор за індексом
        public Person this[int index]
        {
            get
            {
                if ((index >= 0) && (index <= data.Length))
                { return data[index]; }
                else
                { throw new IndexOutOfRangeException($"{nameof(index)} out of Range"); }
            }
            set
            {
                if ((index >= 0) && (index <= data.Length))
                {
                    data[index] = value;
                }
                else
                { throw new IndexOutOfRangeException($"{nameof(index)} out of Range"); }
            }
        }
        //Індексатор за іменем
        public Person? this[string name]
        {
            get
            {
                Person? person = null;
                foreach (var p in data)
                {
                    if (p?.Name == name)
                    {
                        person = p;
                        break;
                    }
                }
                
                return person;
            }
        }
    }
}
