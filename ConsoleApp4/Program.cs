using System.Data.SqlTypes;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 비교 연산자
            // 값 2개를 비교하여 true인지 false인지를 판단한다.
            // 비교 연산
            // 동등(==) : 두개의 값이 같다
            // 부등(!=) : 두개의 값이 같지 않다
            // 크다(>) : 왼쪽이 오른쪽 보다 크다
            // 크거나 같다(>=) : 왼쪽이 오른쪽 보다 크거나 같다
            // 작다(<) : 왼쪽이 오른쪽 보다 작다
            // 작거나 같다(<=) : 왼쪽이 오른쪽 보다 작거나 같다

            bool isEqual = (10 == 5); // => isEqual 이라는 불리언 변수에 (10 == 5)에 대한 판단의 결과를 할당한다.
            bool isNotEqual = (10 != 5); // => isNotEqual 이라는 불리언 변수에 (10 != 5)에 대한 판단의 결과를 할당한다.
            bool isGreaterThan = (10 > 5); // => isGreaterThan 이라는 불리언 변수에 (10 > 5)에 대한 판단의 결과를 할당한다.
            bool isLessThan = (10 < 5); // => isLessThan 이라는 불리언 변수에 (10 < 5)에 대한 판단의 결과를 할당한다.
            bool isGreaterThanOrEqual = (10 >= 5); // => isGreaterThanOrEqual 이라는 불리언 변수에 (10 >= 5)에 대한 판단의 결과를 할당한다.
            bool isLessThanOrEqual = (10 <= 5); // => isLessThanOrEqual 이라는 불리언 변수에 (10 <= 5)에 대한 판단의 결과를 할당한다.

            Console.WriteLine($"Is Equal: {isEqual}");
            Console.WriteLine($"Is Not Equal: {isNotEqual}");
            Console.WriteLine($"Is Greater Than: {isGreaterThan}");
            Console.WriteLine($"Is Less Than: {isLessThan}");
            Console.WriteLine($"Is Greater Than or Equal: {isGreaterThanOrEqual}");
            Console.WriteLine($"Is Less Than Or Equal: {isLessThanOrEqual}");


            // 논리 연산자
            // 2가지 이상의 조건들의 관계를 판단한다.
            // AND(&&) : 모든 조건(두 개 이상의 조건)들이 참(true)일때 true를 반환한다.
            // OR(||)  : 모든 조건(두 개 이상의 조건)들 중 하나 이상의 조건이 참(true)일때 true를 반환한다.
            // NOT(!)  : 조건의 결과를 발전시키다 참이면 거짓, 거짓이면 참으로 변환한다.

            // 남자인지 아닌지
            bool isMan = false; // => 남자
            bool isStudent = true; // => 학생이다
            bool isSunday = true; // => 일요일이다
            // 일요일인데 남자면서 학생인 사람인지?
            Console.WriteLine(isMan && isStudent && isSunday);
            // 일요일인데 여자면서 학생인 사람인지?
            Console.WriteLine(!isMan && isStudent && isSunday);

            // 학생이거나 일요일인 경우 => 학생 혹은 일요일일 경우 true
            Console.WriteLine(!isStudent || isSunday);


            // 증감 연산자
            // 증감 연산자란 값을 1씩 증가시키거나 감소시키는 연산자이다.
            // ++ : 1씩 증가를 시킨다.
            // -- : 1씩 감소를 시킨다.

            int a = 10;
            a++; // a++ => 이 코드가 실행되고 나서 1을 증가시킨다. (후위 증감 연산자)
            Console.WriteLine(a); // 11
            ++a; // ++a => 이 코드가 실행되기 전에 1을 증가시킨다. (전위 증감 연산자)
            Console.WriteLine(a); // 12

            int b = 10;
            Console.WriteLine(b++); // 10
            Console.WriteLine(++b); // 12

            int c = 10;
            c--; // a++ => 이 코드가 실행되고 나서 1을 감소시킨다. (후위 증감 연산자)
            Console.WriteLine(c); // 9
            --c; // ++a => 이 코드가 실행되기 전에 1을 감소시킨다. (전위 증감 연산자)
            Console.WriteLine(c); // 8

            int d = 10;
            Console.WriteLine(d--); // 10
            Console.WriteLine(--d); // 8

        }
    }
}
