﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    internal class _023_Collatz
    {
        // 1-1. 입력된 수가 짝수라면 2로 나눕니다. 
        // 1-2. 입력된 수가 홀수라면 3을 곱하고 1을 더합니다.
        // 2. 결과로 나온 수에 같은 작업을 1이 될 때까지 반복합니다. 
        // 위 작업을 몇 번이나 반복해야 하는지 반환하는 함수, solution을 완성해 주세요.
        // 단, 주어진 수가 1인 경우에는 0을, 작업을 500번 반복할 때까지 1이 되지 않는다면 –1을 반환해 주세요.
        public int solution(int num)
        {
            int answer = 0;
            long n = num;
            while (n != 1)
            {
                answer++;
                n = (n % 2 == 0) ? n / 2 : n * 3 + 1;
            }
            if (answer >= 500) answer = -1;
            return answer;
        }
    }
}

