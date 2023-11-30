using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    internal class _020_DescendLong
    {
        public long solution(long n)
        {
            char[] a = n.ToString().ToCharArray();
            Array.Sort(a);
            Array.Reverse(a);

            long answer = long.Parse(new string(a));
            return answer;
        }
    }
}
