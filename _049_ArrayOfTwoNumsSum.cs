using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    internal class _049_ArrayOfTwoNumsSum
    // 정수 배열 numbers가 주어집니다.
    // numbers에서 서로 다른 인덱스에 있는 두 개의 수를 뽑아 더해서 만들 수 있는 모든 수를
    // 배열에 오름차순으로 담아 return 하도록 solution 함수를 완성해주세요.
    { 
        public class Solution
        {
            public int[] solution(int[] numbers)
            {
                List<int> answer = new List<int>();
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        int tmp = numbers[i] + numbers[j];
                        if (answer.Contains(tmp) == false)
                        {
                            answer.Add(tmp);
                        }
                    }
                }
                answer.Sort();
                return answer.ToArray();
            }
        }
    }
}

