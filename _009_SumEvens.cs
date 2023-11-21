using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    internal class _009_SumEvens
    // 정수 n이 주어질 때, n이하의 짝수를 모두 더한 값을 return 하도록 solution 함수를 작성해주세요.
    {
        public int solution(int n)
        {
            int answer = 0;
            for(int i = 2; i <= n; i += 2)
            {
                answer += i;
            }
            return answer;
        }
    }
}
