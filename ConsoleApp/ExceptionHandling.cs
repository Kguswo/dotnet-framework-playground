using System;

namespace ConsoleApp2
{
    internal class ExceptionHandling
    {
        public static void Run()
        {
            try
            {
                // 오류가 발생할 것으로 예상되는 코드

                // 사용자로부터 입력 받기
                Console.WriteLine("값을 입력해주세요.");
                int i = Int32.Parse(Console.ReadLine());

                int[] numbers = { 1, 2, 3, 4, 5 };
                Console.WriteLine("요청된 값 : " + numbers[i]);
                // 오류 생성하기
                // throw new Exception();
                // throw new Exception("사용자의 에러를 발생시켜보자");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("특정 오류만 잡았습니다. Main함수의 IndexOutOfRangeException");
                Console.WriteLine("오류 메시지 : " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("그 외 오류가 발생하여 이 부분이 실행됩니다.");
                Console.WriteLine("오류 메시지 : " + e.Message);
                // 오류를 다시 던질수도 있음
                // throw e;
            }
            finally
            {
                Console.WriteLine("오류발생, 오류 미발생이어도 무조건 실행되는 부분이 finally");
            }
        }
    }
}
