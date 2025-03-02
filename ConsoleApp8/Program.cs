namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parse
            // 문자열 데이터를 int, double 과 같은 다른 데이터 타입으로 변환시키는 기능
            // Console.Write("숫자를 입력해주세요 : ");
            // string input = Console.ReadLine();
            // input에 들어온 값을 숫자로 변환하고 싶다.
            // int value = int.Parse(input);
            // Console.WriteLine(value);
            // Console.Write("문자를 입력해주세요 : ");
            // string input2 = Console.ReadLine();
            // Console.WriteLine(input2);


            // 놀이동산 입장권
            // 사용자로부터 나이, 군인 할인, 연관 회원 여부를 입력 받아서 입장 요금을 계산합니다.

            // 무료 입장 조건
            // 1. 나이가 3세 이하
            // 2. 나이가 65세 이상
            // 3. 연간 회원

            // 할인 적용
            // 1. 군인일 경우 -> 30% 할인

            // 일반 요금
            // 성인(19~64세) : 10000원
            // 청소년(13~18세) : 8000원
            // 어린이(4~12세) : 5000원

            // 출력 예시
            // 나이를 입력하세요 : 20
            // 군인인가요? (네/아니요) : 네
            // 연간 회원인가요? (네/아니요) : 아니요
            // 입장료는 7000원입니다.

            // 출력 예시
            // 나이를 입력하세요 : 20
            // 군인인가요? (네/아니요) : 네
            // 연간 회원인가요? (네/아니요) : 네
            // 무료 입장입니다.

            Console.Write("나이를 입력하세요 : ");
            string ageInput = Console.ReadLine();
            int age = int.Parse(ageInput);
            string input = "";
            if (age > 4) // 4살 미만
            {
                input = "무료 입장입니다.";
            }
            else
            {
                Console.WriteLine();
            }


            // Parse

            // 군인 여부 입력

            // 연간 회원 여부 입력

            Console.Write("군인인가요? : ");
            string Input = Console.ReadLine();
            Console.Write("연간 회원인가요? : ");


        }
    }
}
