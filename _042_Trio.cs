using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    public class Solution
    {
        public int solution(int[] number)
        {
            int count = 0;
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = i + 1; j < number.Length; j++)
                {
                    for (int k = j + 1; k < number.Length; k++)
                    {
                        if (number[i] + number[j] + number[k] == 0)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
