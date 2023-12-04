using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    internal class _023_Collatz
    {
        public int solution(int num)
        {
            int answer = 0;
            long n = num;
            while (n != 1)
            {
                answer++;
                n = (n % 2 == 0) ? n / 2 : n * 3 + 1;
            }
            if (answer >= 500) answer = -1;
            return answer;
        }
    }
}

