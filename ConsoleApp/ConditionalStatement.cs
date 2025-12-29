using System;

namespace ConsoleApp
{
    internal class ConditionalStatement
    {
        public static void Run()
        {
            Console.WriteLine("ch.5 조건문");
            int a = 5;
            int b = 10;

            // if(true)
            if (b > a)
            {
                a++;
                Console.WriteLine("a 값은 : " + a);
            }

            // if(false)
            if (b < a)
            {
                a--;
                Console.WriteLine("a 값은 : " + a);
            }

            if (b < a)
            {
                b--;
                Console.WriteLine("b 값은 : " + b);
            }
            else
            {
                b = b - 2;
                Console.WriteLine("b 값은 : " + b);
            }

            Console.WriteLine("======================");
            int money = 8000;
            if (money < 5000)
            {
                Console.WriteLine("돈이 5000 미만일 때 동작");
            }
            else if (money < 7000)
            {
                Console.WriteLine("돈이 5000 이상 7000 미만일 때 동장");
            }
            else if (money < 9000)
            {
                Console.WriteLine("돈이 7000 이상 9000 미만일 때 동작");
            }
            else
            {
                Console.WriteLine("돈이 9000 이상일 때 동작");
            }

            // switch 문
            int week = 3;
            // switch문을 사용할 때는 비교하려하는 값이 같은 타입으로 이루어졌을 경우.
            // switch(expression)에서 expression은 각각의 case와 값을 비교한다.
            // 만약 일치하면 해당 case에 속한 코드를 실행한다.
            switch (week)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break; // break문을 만나면 switch문을 빠져나간다.

                case 2:
                    Console.WriteLine("화요일");
                    break;

                case 3:
                    Console.WriteLine("수요일");
                    break;

                case 4:
                    Console.WriteLine("목요일");
                    break;

                // default는 else와 같은 역할을 한다. 없어도 괜찮다.
                default:
                    Console.WriteLine("선택된 요일이 없습니다.");
                    break;
            }// break실행으로 여기서부터 다시 시작.
            //  if문으로 사용해도 별 차이 없음.
            //  다만 조건을 추가한다 해도 동일한 용도 및 타입으로 사용디ㅗㄹ 가능성이 높을 경우, switch문으로 자주 사용.
        }
    }
}
