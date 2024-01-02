using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    internal class _038_RectStars
    {
        // 이 문제에는 표준 입력으로 두 개의 정수 n과 m이 주어집니다.
        // 별(*) 문자를 이용해 가로의 길이가 n, 세로의 길이가 m인 직사각형 형태를 출력해보세요.

        public class Example
        {
            public static void Main()
            {
                String[] s;
                Console.Clear();
                s = Console.ReadLine().Split(' ');
                int n = Int32.Parse(s[0]);
                int m = Int32.Parse(s[1]);
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}
