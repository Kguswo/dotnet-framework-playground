using System;

namespace ConsoleApp2
{
    internal class Operator
    {
        public static void Run()
        {
            Console.WriteLine("");
            Console.WriteLine("ch.3 연산자");
            int a = 10;
            int b = 3;
            Console.WriteLine("a + b = " + (a + b)); // 덧셈
            Console.WriteLine("a - b = " + (a - b)); // 뺄셈
            Console.WriteLine("a * b = " + (a * b)); // 곱셈
            Console.WriteLine("a / b = " + (a / b)); // 나눗셈
            Console.WriteLine("a % b = " + (a % b)); // 나머지
            a++; // a를 1 증가
            Console.WriteLine("a++ = " + a);
            b--; // b를 1 감소
            Console.WriteLine("b-- = " + b);

            int num = a > b ? a : b; // 삼항 연산자
            Console.WriteLine("큰 수는? " + num);

            bool flag1 = true;
            bool flag2 = false;
            string str = "abc";
            bool result = a == b; // 같음
            Console.WriteLine("a == b : " + result);
            result = a != b; // 같지 않음
            Console.WriteLine("a != b : " + result);
            result = a > b; // 큼
            Console.WriteLine("a > b : " + result);
            result = a < b; // 작음
            Console.WriteLine("a < b : " + result);
            result = str.Contains("ab"); // 포함
            Console.WriteLine("ab in abc?" + result);

            Console.WriteLine("");
        }
    }
}
