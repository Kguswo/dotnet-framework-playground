using ConsoleApp;
using System; // System 네임스페이스 사용 

namespace ConsoleApp2 // 네임스페이스 선언
                      // 공간 선언을 통해 중복되는 이름을 피할 수 있다. ex) ConsoleApp1.Apple 클래스 와 ConsoleApp2.Apple 클래스
{

    // 클래스는 하나의 객체를 표현한다.
    // ex) 자동차(Car) 클래스가 있으면 자동차의 구성요소(멤버변수)와 행동적인 요소(method)를 가질 수 있다.
    class Car
    {
        public string Model { get; set; } // 자동차 모델 속성
        public int Year { get; set; }     // 자동차 연식 속성
        public void Move() // 자동차 이동 메서드
        {
            Console.WriteLine("자동차 이동.");
        }
    }

    // class Program은 C#에서 프로그램의 가장 첫번째 실행되는 Main 메서드를 포함하는 용도로 주로 사용된다.
    internal class Program
    {
        // 프로그램의 주요 진입점(Entry Point)인 Main 메서드
        static void Main(string[] args)
        {
            // System 네임스페이스의 Console 클래스의 WriteLine 메서드를 호출하여 "Hello, World!" 문자열을 콘솔에 출력
            Console.WriteLine("Hello, World!");

            Variable.Run(); // Variable 클래스의 run 메서드 호출
            Operator.Run(); // Operator 클래스의 run 메서드 호출
            Arrays.Run();    // Array 클래스의 run 메서드 호출
            ConditionalStatement.Run(); // ConditionalStatement 클래스의 run 메서드 호출
            LoopStatement.Run(); // LoopStatement 클래스의 run 메서드 호출
            ExceptionHandling.Run(); // ExceptionHandling 클래스의 run 메서드 호출
            Function.myFunction(); // Function 클래스의 myFunction 메서드 호출
            Function.myAddition(1, 2); // Function 클래스의 myAddition 메서드 호출
        }
    }
}
