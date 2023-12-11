﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    // 프로그래머스 모바일은 개인정보 보호를 위해 고지서를 보낼 때 고객들의 전화번호의 일부를 가립니다.
    // 전화번호가 문자열 phone_number로 주어졌을 때,
    // 전화번호의 뒷 4자리를 제외한 나머지 숫자를 전부* 으로 가린 문자열을 리턴하는 함수, solution을 완성해주세요.
    internal class _027_HidePhoneNums
    {
        public string solution(string phone_number)
        {
            int length = phone_number.Length;
            string remains = new string('*', length - 4) + phone_number.Substring(length - 4);
            return remains;
        }
    }
}
