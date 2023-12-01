using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    internal class _021_HarshadNum
    {
        public bool solution(int x)
        {
            int div = 0;
            int x2 = x;
            while (x2 > 0)
            {
                div += x2 % 10;
                x2 = x2 / 10;
            }

            if (x % div == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

