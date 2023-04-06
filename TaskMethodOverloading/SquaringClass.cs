using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMethodOverloading
{
    internal class SquaringClass
    {
        public int Squaring(int a)
        {
            return a * a;
        }

        public int Squaring(int a, int b)
        {
            int result = 0;
            for (int i = 0; i < b; i++)
            {
                result += a * a;
            }
            return result;
        }
    }
}
