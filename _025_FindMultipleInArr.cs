using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    internal class _025_FindMultipleInArr
    {
        // array의 각 element 중 divisor로 나누어 떨어지는 값을 오름차순으로 정렬한 배열을 반환하는 함수, solution을 작성해주세요.
        // divisor로 나누어 떨어지는 element가 하나도 없다면 배열에 -1을 담아 반환하세요.

        public int[] solution(int[] arr, int divisor)
        {
            int[] answer = new int[arr.Length];
            int num = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % divisor == 0)
                {
                    answer[num] = arr[i];
                    num++;
                }
            }
            
            if(num == 0)
            {
                Array.Resize(ref answer, 1);
                answer[0] = -1;
            }
            else
            {
                Array.Resize(ref answer, num);
                Array.Sort(answer);
            }

            return answer;
        }
    }
}
