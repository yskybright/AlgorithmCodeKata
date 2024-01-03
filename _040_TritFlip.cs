using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    // 자연수 n이 매개변수로 주어집니다. n을 3진법 상에서 앞뒤로 뒤집은 후,
    // 이를 다시 10진법으로 표현한 수를 return 하도록 solution 함수를 완성해주세요.
    internal class _040_TritFlip
    {
        public class Solution
        {
            public int solution(int n)
            {
                int answer = 0;
                List<int> list = new List<int>();

                // n을 3진법으로 나타내기 (list라서 앞뒤 반전)
                while (true) 
                {
                    if (n == 0) break;
                    int tritvalue = n % 3;
                    list.Add(tritvalue);
                    n = n / 3;
                }
                
                // 곱셈 편의성을 위해 다시 앞뒤 반전
                list.Reverse();

                // 3진법을 10진법으로 치환
                for(int i = 0; i < list.Count; i++)
                {
                    answer += (int)(list[i] * Math.Pow(3, i));
                }
                return answer;
            }
        }
    }
}
