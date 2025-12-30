using System;

namespace ConsoleApp
{
    internal class Function
    {
        public static void myFunction()
        {
            Console.WriteLine("함수 호출됨");
        }

        public static int myAddition(int a, int b)
        {
            int c;
            Console.WriteLine("덧셈 함수 호출");
            c = a + b;
            return c;
        }
    }
}
