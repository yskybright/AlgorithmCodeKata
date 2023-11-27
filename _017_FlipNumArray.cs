using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    // 자연수 n을 뒤집어 각 자리 숫자를 원소로 가지는 배열 형태로 리턴해주세요.
    // 예를들어 n이 12345이면 [5,4,3,2,1]을 리턴합니다.
    internal class _017_FlipNumArray
    {
        public int[] solution(long n)
        {
            string s = n.ToString();
            int[] answer = new int[s.Length]; 
            for(int i = 0; i < s.Length; i++)
            {
                answer[s.Length - i - 1] = int.Parse(s[i].ToString());
            };
            return answer;
        }
    }
}
