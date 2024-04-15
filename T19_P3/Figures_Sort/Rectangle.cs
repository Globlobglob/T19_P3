using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class Rectangle : Imain
    {
        
        public double SideA { get; set; }
        public double SideB { get; set; }

        public string Name { get; set; }
        /// <summary>
        /// Const with param
        /// </summary>
        /// <param name="name">Rectangle name</param>
        /// <param name="sidea"> Rectangle side a</param>
        /// <param name="sideb">Rectangle side b</param>
        public Rectangle(string name,double sidea, double sideb) {

            SideA = sidea;
            SideB = sideb;
            Name = name;
        }

        /// <summary>
        /// Rectangle prop Print
        /// </summary>
        /// <returns> object rectangle </returns>
        public static Rectangle RectanglePrint()
        {
            Console.Write("Enter Rectangle Name: ");
            string name=Console.ReadLine();
            Console.Write("Enter side a: ");
            double sidea = double.Parse(Console.ReadLine());
            Console.Write("Enter side b: ");
            double sideb = double.Parse(Console.ReadLine());
            return new Rectangle(name,sidea, sideb);
        }

        /// <summary>
        ///  Output methods
        /// </summary>
        /// <returns>All info of Rectangle</returns>
        public override string ToString()
        {
            return $"\nName: {Name}\nSquare= {Square():F2}\nPerimetr= {Perimetr():F2}";
        }

        /// <summary>
        /// Square rectangle
        /// </summary>
        /// <returns></returns>
        public double Square()
        {
            return SideA * SideB;
        }
        /// <summary>
        /// Perimeter rectangle
        /// </summary>
        /// <returns></returns>
        public double Perimetr()
        {
            return SideA+SideB;
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
