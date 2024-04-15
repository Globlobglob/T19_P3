using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class Repository
    {
        List<Imain>figures = new List<Imain>();//list figures obj 

        /// <summary>
        /// Print triangle data 
        /// </summary>
        public void TrianglePrint()
        {
            Console.Clear();
            figures.Add(Triangle.TrianglePrint());
        }

        //print Rectangle Data
        public void RectanglePrint()
        {
            Console.Clear();
            figures.Add(Rectangle.RectanglePrint());
        }

        //print Circle Data
        public void  CirclePrint()
        {
            Console.Clear();
            figures.Add(Circle.PrintCircle());
        }

        /// <summary>
        /// print all sort figures
        /// </summary>
        public void GetAll()
        {
           
            figures.Sort();//figures sort by square
            foreach (Imain fig in figures)
            {
                
                Console.WriteLine(fig.ToString());
            }
        }

       

       
       
    }
}
