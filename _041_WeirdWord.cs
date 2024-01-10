using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    // 문자열 s는 한 개 이상의 단어로 구성되어 있습니다. 각 단어는 하나 이상의 공백문자로 구분되어 있습니다.
    // 각 단어의 짝수번째 알파벳은 대문자로, 홀수번째 알파벳은 소문자로 바꾼 문자열을 리턴하는 함수, solution을 완성하세요.
    internal class _041_WeirdWord
    {
        public string solution(string s)
        {
            string answer = "";
            bool isEven = true;
            for(int i=0; i < s.Length; i++)
            {
                char c = s[i];
                if (c != ' ')
                {
                    if (isEven)
                    {
                        answer += s[i].ToString().ToUpper();
                        isEven = false;
                    }
                    else
                    {
                        answer += s[i].ToString().ToLower();
                        isEven = true;
                    }
                }
                else
                {
                    isEven = true;
                    answer += " ";
                }
            }
            return answer;
        }
    }
}

