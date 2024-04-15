using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSort
{
    internal class Avto:IComparable<Avto>
    {
        public int Id { get; set; }
        public string Mark { get; set; }

        public int MaxSpeed { get; set;}
        public int Cost { get; set; }

        public int Discount { get; set; }

        public Avto() { }

        public Avto(int id, string mark,int maxSpeed,int cost,int discount)
        {
           
            Id = id;
            Mark = mark;
            MaxSpeed = maxSpeed;
            Cost = cost;
            Discount = discount;

        }

        public int CompareTo(Avto item) {
            
            return Cost.CompareTo(item.Cost);
        }

    }
}
