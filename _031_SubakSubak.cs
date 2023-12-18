﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    // 길이가 n이고, "수박수박수박수...."와 같은 패턴을 유지하는 문자열을 리턴하는 함수, solution을 완성하세요.
    // 예를 들어 n이 4이면 "수박수박"을 리턴하고 3이라면 "수박수"를 리턴하면 됩니다.
    internal class _031_SubakSubak
    {
    public string solution(int n)
        {
            string answer = "";
            for (int i = 0; i < n; i++)
            {
                answer += i%2 == 0? "수" : "박";
            }
            return answer;
        }
    }
}

