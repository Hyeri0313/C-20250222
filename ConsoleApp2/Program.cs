using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 불리언 데이터
            // 참(true), 거짓(false)를 나타내는 데 사용되는 데이터 타입이다.
            // 크기 : 1byte
            // 값 : 1(true), 0(false)

            bool isCSharp = true;
            bool isMonday = false;



            // 문자, 문자열 데이터 타입
            // 문자열 데이터는 문자 데이터들을 입력받은 순서대로 나열한 데이터
            
            // 문자
            // char : 하나의 문자를 저장하고 관리하는 데이터
            // 데이터 크기 : 2 bytes
            // char에 들어가는 데이터는 '(문자)'로 선언해줘야 한다.
            char myChar = 'A';

            // 문자열
            // 여러 문자들을 저장하고 관리하기 위한 객체(데이터)
            // string은 데이터 크기가 고정적이지는 않다.
            // string에 들어가는 데이터는 "(하나 이상의 문자)"로 선언해줘야 한다.
            string myString = "Hello World";

            // 구구단을 출력하기 위해서는
            string str1 = "3 * 1 = 3";
            string str2 = "3 * 2 = 6";
            // 문자열에 중간에 값을 넣어주거나 문자열 뒤에 새로운 문자 혹은 값을 추가해서 문자열의 값을 확장할 수 있다.

            // 문자열 포맷팅
            // 문자열 보관과 형식 지정자를 통해서 복잡한 데이터를 보기 좋게 표현하는 기능
            // 코드의 가독성을 높이면서, 복잡한 문자열을 쉽게 조합할 수 있다.
            // => 코드짜기 편하다
            // $ 기호와 중괄호 {}를 사용하여 문자열 내에 직접 변수, 표현식, 형식 지정자를 삽입할 수 있다.
            int int1 = 1;
            string formated1 = $"3 * {int1} = 3"; // 문자열 사이에 {int1}이 있으면 int1에 있는 값을 꺼내서 문자로 변환한다.
            int1 = 2;
            string formated2 = $"3 * {int1} = 6";

            Console.WriteLine(myChar);
            Console.WriteLine(myString);

            Console.WriteLine(formated1);
            Console.WriteLine(formated2);

            // 문자열에 새로운 문자들을 추가할 수 있다.
            str1 = str1 + "입니다.";
            // "3 * 1 = 3" + "입니다."
            // => "3 * 1 = 3입니다."
            str2 = str2 + 10;
            // "3 * 2 = 6" + 10
            // "3 * 2 = 610"
            Console.WriteLine(str1);
            Console.WriteLine(str2);

        }
    }
}
