using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    internal class _012_ArrayMean
    {
        // 정수를 담고 있는 배열 arr의 평균값을 return하는 함수, solution을 완성해보세요.
        public double solution(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double answer = sum/arr.Length;
            return answer;
        }

    }
}
