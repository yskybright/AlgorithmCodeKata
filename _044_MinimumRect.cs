using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    internal class _044_MinimumRect
    {
        // 모든 명함의 가로 길이와 세로 길이를 나타내는 2차원 배열 sizes가 매개변수로 주어집니다.
        // 모든 명함을 수납할 수 있는 가장 작은 지갑을 만들 때, 지갑의 크기를 return 하도록 solution 함수를 완성해주세요.

        public int solution(int[,] sizes)
        {
            int maxWidth = 0;
            int maxHeight = 0;

            for (int i = 0; i < sizes.GetLength(0); i++)
            {
                int width = sizes[i, 0];
                int height = sizes[i, 1];

                if (height > width)
                {
                    width = sizes[i, 1];
                    height = sizes[i, 0];
                }
                if (height > maxHeight)
                {
                    maxHeight = height;
                }
                if (width > maxWidth)
                {
                    maxWidth = width;
                }
            }

            int answer = maxWidth * maxHeight;
            return answer;
        }
    }
}
