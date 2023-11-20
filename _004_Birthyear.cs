using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    // 머쓱이는 40살인 선생님이 몇 년도에 태어났는지 궁금해졌습니다.
    // 나이 age가 주어질 때, 2022년을 기준 출생 연도를 return 하는 solution 함수를 완성해주세요.
    internal class _004_Birthyear
    {
        public int solution(int age)
        {
            int answer = 0;
            return 2022 - age + 1;
        }
    }
}
