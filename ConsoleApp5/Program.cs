namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 캐스팅
            // 데이터 타입 간의 변환을 처리하는 방법
            // 1. 암시적 캐스팅
            // 변환되는 데이터 타입이 원본 데이터 타입보다 더 큰 범위를 가지거나 더 많은 정보를 저장할 수 있을 때 발생한다.
            int a = 1000000000;
            long b = a; // long은 int보다 더 큰 범위를 가질 수 있기 때문에 long에 int 데이터를 넣으면 암시적 캐스팅이 발생한다.


            // 2. 명시적 캐스팅
            // 변환되는 데이터 타입이 원본 데이터 타입보다 더 작은 범위를 가지거나 더 적은 정보만을 저장할 수 있을 때 사용한다.
            // 더 큰 데이터 범위에서 더 작은 데이터 범위로 데이터를 변환시키기 때문에 이 과정에서 데이터 손실이 발생할 수 있다.
            long c = 1000000000;
            int d = (int)c; // long은 int보다 더 큰 범위를 가질 수 있기 때문에 int 데이터에 long을 임시적으로 넣을 수가 없다.
                            // 그래서 명시적으로 (int)c를 선언하여 데이터 타입의 전환을 강제할 수 있다.

            float myFlost = 1234.5678f;
            int myInt = (int)myFlost;

            // int / int => int형 데이터가 나온다.
            // int / float Or float / int => float형 데이터가 나온다.
            int intResult = 10 / 3; // 3.3333...
            float floatResult = 10 / 3.0f; // 3.3333...
            Console.WriteLine(intResult); // 3
            Console.WriteLine(floatResult); // 3.3333...

            int num1 = 10;
            int num2 = 3;
            float output = num1 / num2; // => 3
            float output2 = num1 / (float)num2; // 3.3333....
            Console.WriteLine(output); // 3
            Console.WriteLine(output2); // 3.3333...

        }
    }
}
