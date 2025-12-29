using System;

namespace ConsoleApp2
{
    internal class Variable
    {
        public static void Run()
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("ch.2 변수");
            // 자료형
            int num = 0;
            long bigNum = 500000000000000000L;
            short shortNum = 200;
            byte byteNum = 40;
            bool flag = true;
            char ch = 'a';
            string myName = "Kim Hyeon Jae";
            float num2 = 35.1F;
            double num3 = 35.2350;

            // 형변환 (int -> string)
            int a = 5;
            int b = 6;
            b = a; // b에 a값을 저장
            string c = "";
            c = a.ToString();

            Console.WriteLine(c);


            // 형변환 (string -> int)
            string money = "532";
            int money2 = 0;
            money2 = Int32.Parse(money);
            // 기본 int는 int32를 사용.
            // Int64 : 저장할 수 있는 숫자 범위의 차이
            // Int64 money3 = 3333333333333333;

            Console.WriteLine("money2 : " + money2);


            // System 네임스페이스의 Console 클래스의 WriteLine 메서드를 호출
            System.Console.WriteLine("System을 이용한 호출");
            Console.WriteLine("Hello Worlrd!");
            System.Console.WriteLine("");
        }
    }
}
