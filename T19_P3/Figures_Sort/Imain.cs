using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    public interface Imain:IComparable<Imain>
    {
        /// <summary>
        /// main Interface with methods
        /// </summary>
        /// <returns></returns>
        double Perimetr();
        double Square();
        string ToString();


        new int CompareTo(Imain figures);
        

    }
}
