using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    internal class _039_GCDandLCM
    {
        // 두 수를 입력받아 두 수의 최대공약수와 최소공배수를 반환하는 함수, solution을 완성해 보세요.
        // 배열의 맨 앞에 최대공약수, 그다음 최소공배수를 넣어 반환하면 됩니다.
        // 예를 들어 두 수 3, 12의 최대공약수는 3, 최소공배수는 12이므로 solution(3, 12)는 [3, 12]를 반환해야 합니다.

        public int[] solution(int n, int m)
        {
            int[] answer = new int[2];
            int cdg; //최대공약수
            int csg; //최소공배수

            cdg = gcd(n, m);
            csg = (n * m) / cdg;

            answer[0] = cdg;
            answer[1] = csg;
            return answer;
        }

        // gcd = greatest common divisor
        public int gcd(int n, int m)
        {
            if (m == 0) return n;
            else return gcd(m, n % m);
        }
    }
}
