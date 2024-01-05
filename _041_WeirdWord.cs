using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
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

