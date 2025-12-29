using System;

namespace ConsoleApp
{
    internal class Arrays
    {
        public static void run()
        {
            Console.WriteLine("ch4. 배열");
            // 배열(Array): 동일한 데이터 타입의 여러 값을 하나의 변수에 저장할 수 있는 자료구조

            // 배열의 선언
            string[] cars = new string[10];

            // 배열의 선언과 동시에 초기화
            string[] foods = { "Pizza", "Burger", "Pasta" };

            // int 형의 배열 생성
            int[] arr = { 10, 20, 30, 40, 50 };

            // 배열의 요소에 접근하기
            // 배열요소가 위치하는 숫자를 적어준다.
            Console.WriteLine("첫번째 값 : " + foods[0]); // "Pizza" 출력
            Console.WriteLine("두번째 값 : " + foods[1]); // "Burger" 출력
            Console.WriteLine("세번째 값 : " + foods[2]); // "Pasta" 출력

            // 배열의 요소 변경
            foods[0] = "Sushi";
            Console.WriteLine("첫번째 값 변경 후 : " + foods[0]); // "Sushi" 출력

            // 배열의 길이 확인
            Console.WriteLine("배열의 길이: " + foods.Length); // 3 출력

            // 2차원 배열의 선언과 초기화
            // 열의 크기가 동일해야한다.

            int[,] board = {
                { 1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
             };

            int var = board[0, 2]; // 1행 3열의 값에 접근
            Console.WriteLine("2차원 배열의 값: " + var); // 3 출력

            // 가변 배열
            // 추가할 1차원 배열 크기 필수로 입력
            int[][] myNums = new int[4][];
            myNums[0] = new int[2] { 1, 2 };
            myNums[1] = new int[3] { 3, 4, 5 };
            myNums[2] = new int[4] { 6, 7, 8, 9 };
            myNums[3] = new int[2];
            int var2 = myNums[0][1];

            Console.WriteLine("var2: " + var2); // 2 출력
            Console.WriteLine("");
        }
    }
}
