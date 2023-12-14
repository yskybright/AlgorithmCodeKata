using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    // 단어 s의 가운데 글자를 반환하는 함수, solution을 만들어 보세요.
    // 단어의 길이가 짝수라면 가운데 두글자를 반환하면 됩니다.
    internal class _030_ReturnMiddleChars
    {
        public string solution(string s)
        {
            string answer = "";

            int middle = s.Length / 2;
            if (s.Length % 2 != 0) 
            {
                answer = s.Substring(middle, 1);
            }
            else 
            {
                answer = s.Substring(middle - 1, 2);
            }
            return answer;
        }
    }
}
