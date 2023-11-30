using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    // 임의의 양의 정수 n에 대해, n이 어떤 양의 정수 x의 제곱인지 아닌지 판단하려 합니다.
    // n이 양의 정수 x의 제곱이라면 x+1의 제곱을 리턴하고, n이 양의 정수 x의 제곱이 아니라면 -1을 리턴하는 함수를 완성하세요.
    internal class _019_FindSquareNum
    {
        public long solution(long n)
        {
            long x = (long)Math.Sqrt(n);
            return (x*x == n) ? (x+1)*(x+1) : -1;
        }
    }
}
