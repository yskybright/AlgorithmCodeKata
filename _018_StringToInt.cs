using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    internal class _018_StringToInt
    {
        public int solution(string s)
        {
            string str = s;
            bool success = int.TryParse(str, out int answer);
            
            if (success) 
            { 
              return answer;
            }
            else
            { 
              return 0; 
            }
        }
    }
}
