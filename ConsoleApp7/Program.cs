using System.ComponentModel.Design;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("데이터 값을 출력");
            // Console 창에서 입력 받기 = string
            // string input = Console.ReadLine();
            // Console.WriteLine($"입력받은 데이터 출력 {input}");

            // 문제
            // 사용자로부터 날씨를 입력받고, 해당하는 메시지를 출력하세요
            // 맑음 => 오늘은 날씨가 좋네요!
            // 비 => 우산을 챙기세요
            // 눈 => 따뜻하게 입으세요
            // 나머지 => 날씨 정보를 알 수 없습니다.

            // 출력 형식
            // 오늘의 날씨를 입력하세요 (맑음/비/눈) : (사용자 입력) ex) 맑음
            // 오늘은 날씨가 좋네요!

            // Console.Write("오늘의 날씨를 입력하세요 (맑음/비/눈) :");




            Console.Write("오늘의 날씨를 입력하세요 (맑음/비/눈) : ");
            string weather = Console.ReadLine();

            if (weather == "맑음")
            {
                Console.WriteLine("오늘은 날씨가 좋네요!");
            }
            else
            {
                Console.WriteLine($"{weather}");
            }
            if (weather == "비")
            {
                Console.WriteLine("우산을 챙기세요");
            }
            else
            {
                Console.WriteLine($"{weather}");
            }


        }
    }
}
