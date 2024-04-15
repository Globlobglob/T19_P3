using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class Circle:Imain
    {
        /// <summary>
        /// Class circle inh Imain
        /// </summary>
        public double R { get; set; } 
        public string Name { get; set; }
        
        /// <summary>
        /// Const with param
        /// </summary>
        /// <param name="name">Circle name</param>
        /// <param name="r"> circle radius</param>
        public Circle(string name,double r) { 
            
            Name = name;
            R = r;
        }
        /// <summary>
        /// My override methods
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"\nName: {Name}\nSquare = {Square():F2}\nPerimetr={Perimetr():F2}";
        }
        /// <summary>
        /// static methods for print circle properties
        /// </summary>
        /// <returns></returns>
        public static Circle PrintCircle()
        {
            Console.Write("Enter Circle Name: ");
            string name=Console.ReadLine();
            Console.Write("Enter R: ");
            double r =double.Parse(Console.ReadLine());
            return new Circle(name,r);
        }
        /// <summary>
        /// Square methods
        /// </summary>
        /// <returns> circle square </returns>
        public double Square()
        {
            return Math.PI * Math.Pow(2, R);
        }
        /// <summary>
        /// Perimeter
        /// </summary>
        /// <returns>circle Perimeter</returns>
        public double Perimetr()
        {
            return 2*Math.PI* R;
        }

        /// <summary>
        /// Comparable Square
        /// </summary>
        /// <param name="figures"></param>
        /// <returns></returns>
       public int CompareTo(Imain figures)
        {
            return Square().CompareTo(figures.Square());
        }
       

    }
}
