﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    // 함수 solution은 정수 x와 자연수 n을 입력 받아, x부터 시작해 x씩 증가하는 숫자를 n개 지니는 리스트를 리턴해야 합니다.
    // 다음 제한 조건을 보고, 조건을 만족하는 함수, solution을 완성해주세요.
    internal class _016_AddxList

    {
        public long[] solution(int x, int n)
        {
            long[] answer = new long[n];
            for(int i = 0; i < n; i++)
            {
                answer[i] = (long)x * (i +1);
            }
            return answer;
        }
    }
}
