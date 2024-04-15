using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* List<Person> man = new List<Person>();

            man.Add(new Person() { Name ="Artyom",Age=20});
            man.Add(new Person() { Name = "Bvan", Age = 30 });
            man.Add(new Person() { Name = "Aivil", Age = 40 });

            man.Sort();

            foreach (Person person in man)
            {
                Console.WriteLine($"{person.Name} { person.Age}"); ;
            }

            */


            List<Avto> avto = new List<Avto>();
            avto.Add(new Avto() { Id=1,Mark="Lexus",MaxSpeed=260,Cost=98898888,Discount=10});
            avto.Add(new Avto() { Id = 1, Mark = "Mazeratti", MaxSpeed = 190,Cost=6262,Discount=20});
            avto.Sort();

            foreach (var item in avto)
            {
                Console.WriteLine($"{item.Mark} Cost-{item.Cost}");
            }

        }
    }
}
