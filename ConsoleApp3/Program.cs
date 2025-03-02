namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 기본 산술 연산자, 연산자의 우선 순위
            // 더하기 : +
            // 빼기 : -
            // 나누기 : /
            // 곱하기 : *
            // 나누고 난 나머지 : %

            // sum이라는 변수에 10 + 5 라는 연산이 된 값을 할당한다.
            int sum = 10 + 5; // 15
            Console.WriteLine(sum);

            //difference이라는 변수에 10 - 5 라는 연산이 된 값을 할당한다.
            int diffrence = 10 - 5;
            Console.WriteLine(diffrence);

            // product이라는 변수에 10 * 5 라는 연산이 된 값을 할당한다.
            int product = 10 * 5;
            Console.WriteLine(product);

            // quotient이라는 변수에 10 / 5 라는 연산이 된 값을 할당한다.
            int quotient = 10 / 5; // 나누기(나누고 난 몫)
            Console.WriteLine(quotient);

            // remainder이라는 변수에 10 % 5 라는 연산이 된 값을 할당한다.
            int remainder = 10 % 5; // 나누기(나누고 난 나머지)
            Console.WriteLine(remainder);


            // 연산자의 우선 순위
            // 가장 높은 우선 순위 : ()안에 있는 연산이 가장 먼저 실행된다.
            // 곱하기, 나누기, 나머지 연산 후에 더하기 빼기가 실행된다.
            int result = 3 + 4 * 5; //곱셈이 덧셈보다 우선순위가 높으므로, 4 * 5가 먼저 계산된다.
            Console.WriteLine(result); // 출력 : 23

            int resultWithParentheses = (3 + 4) * 5; // 괄호를 사용하여 덧셈이 먼저 수행되도록 한다.
            Console.WriteLine(resultWithParentheses); // 출력 : 35

            // 특정 변수에 연산을 하고 그 값을 다시 변수에 할당하고 싶을 때
            int a = 10;
            a += 10; // ==> a = a + 10;
            Console.WriteLine(a);
            a -= 10; // ==> a = a - 10;
            Console.WriteLine(a);
            a *= 10; // ==> a = a * 10;
            Console.WriteLine(a);
            a /= 10; // ==> a = a / 10;
            Console.WriteLine(a);
        }
    }
}
