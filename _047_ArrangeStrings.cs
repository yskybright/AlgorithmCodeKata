using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    internal class _047_ArrangeStrings
    {
        //문자열로 구성된 리스트 strings와, 정수 n이 주어졌을 때, 각 문자열의 인덱스 n번째 글자를 기준으로 오름차순 정렬하려 합니다.
        //예를 들어 strings가 ["sun", "bed", "car"]이고 n이 1이면 각 단어의 인덱스 1의 문자 "u", "e", "a"로 strings를 정렬합니다.
        public class Solution
        {
            public string[] solution(string[] strings, int n)
            {
                Array.Sort(strings, (a, b) =>
                {
                    int c = a[n].CompareTo(b[n]);
                    if (c == 0)
                    {
                        return a.CompareTo(b);
                    }
                    return c;
                });
                return strings;
            }
        }
    }
}
