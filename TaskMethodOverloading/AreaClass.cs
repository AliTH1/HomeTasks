using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMethodOverloading
{
    internal class AreaClass
    {
        public int Area(int r)
        {
            //Çevrənin sahəsi - S = p*r² (p=3)
            return 3 * r * r;
        }

        public int Area(int a, int b)
        {
            //Düzbucaqlının sahəsi - S = a*b
            return a * b;
        }

        public int Area(int a, int b, int c)
        {
            //Düzbucaqlı paralelpipedin tam səthinin sahəsi - S=2(a*b+a*c+b*c)
            return 2 * (a * b + a * c + b * c);
        }

        public int Area(int r, int a, int b, int c)
        {
            //Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S=p*r; p=(a+b+c)/2
            int p = (a + b + c) / 2;
            return p * r;
        }
    }
}
