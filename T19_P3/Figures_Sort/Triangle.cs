using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class Triangle:Imain
    {
        public string Name {  get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(string name,double sideA, double sideB, double sideC)
        {
            Name = name;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public override string  ToString()
        {
            return $"\nName: {Name}\nSquare = {Square()}\nPerimetr={Perimetr()}";
        }


        public static Triangle TrianglePrint()
        {
            Console.Write("Enter Triangle Name: ");
            string name=Console.ReadLine();
            Console.Write("Enter side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Side c: ");
            double c = double.Parse(Console.ReadLine());
            return new Triangle(name,a,b,c);
        }

        public double Square()
        {
            return SideA * SideB;
        }

        public double Perimetr()
        {
            return SideA+SideB+SideC;   
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
