using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    internal class _019_FindSquareNum
    {
        public long solution(long n)
        {
            long x = (long)Math.Sqrt(n);
            return (x*x == n) ? (x+1)*(x+1) : -1;
        }
    }
}
