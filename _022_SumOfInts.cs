using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    internal class _022_SumOfInts
    {
        public long solution(int a, int b)
        {
            long answer = 0;
            while (a != b)
            {
                answer += a;
                a = (a > b) ? a - 1 : a + 1;
            }

            return answer + b;
        }
    }
}
