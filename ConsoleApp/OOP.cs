using System;

namespace ConsoleApp
{
    // 파일 이름과 class의 이름을 되도록이면 동일하게 한다.
    // 하나의 파일에 class 선언은 한개만 해서 알아보기 편하게 한다.
    // 단어끼리 구분할 떄 단어 시작은 대문자로 한다.
    // ex) class StudyClass
    class OOP
    {
        private int pblcvar;
        private string str;

        public void myFunction()
        {
            Console.WriteLine("OOP 클래스의 myFunction 함수 호출됨");
        }
    }

    // 캡슐화
    class Capsulation
    {
        private int mode;

        public int Mode()
        {
            return mode;
        }

        public void Mode(int a)
        {
            mode = a;
        }
    }

    // 상속
    class ParentClass
    {
        protected int a = 123;

        public void run()
        {
            Console.WriteLine("달리다.");
        }
    }

    class ChildClass : ParentClass
    {
        public int getA()
        {
            return a;
        }
    }

    // 다형성
    class Animal
    {
        // virtual 키워드를 사용하여 자식 클래스에서 재정의 가능하도록 설정
        public virtual void Bark()
        {
            Console.WriteLine("동물이 소리를 내다.");
        }
    }

    class Cat : Animal
    {
        // override 키워드를 사용하여 부모 클래스의 메서드를 재정의
        public override void Bark()
        {
            Console.WriteLine("야옹");
        }
    }

    class Dog : Animal
    {
        // 오버라이딩(Overriding) : 부모 클래스의 메서드를 자식 클래스에서 재정의하는 것
        public override void Bark()
        {
            Console.WriteLine("멍멍");
        }

        // 오버로딩(Overloading) : 같은 이름의 메서드를 매개변수의 타입이나 개수를 다르게 하여 여러 개 정의하는 것
        public void newBark(int a)
        {
            Console.WriteLine(a);
        }

        public void newBark(string a, string b)
        {
            Console.WriteLine(a + " " + b);
        }
    }
}
