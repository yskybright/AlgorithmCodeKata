using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    internal class _046_StringToRealNums
    {
        // 이렇게 숫자의 일부 자릿수가 영단어로 바뀌어졌거나, 혹은 바뀌지 않고 그대로인 문자열 s가 매개변수로 주어집니다.
        // s가 의미하는 원래 숫자를 return 하도록 solution 함수를 완성해주세요. 
        public class Solution
        {
            public int solution(string s)
            {
                string[] num = new string[]
                {
            "zero",
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine",
                };

                for (int i = 0; i < 10; i++)
                {
                    s = s.Replace(num[i], i.ToString());
                }

                return Int32.Parse(s);
            }
        }
    }
}
