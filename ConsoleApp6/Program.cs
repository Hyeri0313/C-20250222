namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 조건문
            // if(조건 => true, false 반환되는 데이터 => 비교 연산자, 논리 연산자, bool 데이터)
            // {
            //      위에 if(조건)이 true일 경우에 실행할 코드들
            // }
            if (1 > 5) // true
            {
                // 여기는 위에 if(조건)이 true일때만 실행된다.
                Console.WriteLine("10은 5보다 크다");
            }
            // 위에 있는 if(조건)이 false일 때 다른 처리를 하고 싶다.
            // else문 위에 있는 조건 if(조건)이 false일 때 다른 처리를 하고 싶을 때만 선언하는 문법이다.
            // => 기본적으로는 선언을 안해도 된다.
            // else문을 기본적으로 if문 바로 뒤에 사용되어야 한다.
            // 중간에 다른 코드가 들어올 수 없다.
            else
            {
                // 여기는 위에 if(조건)dl false 일때만 실행된다.
                Console.WriteLine("10은 5보다 크지 않다");
            }

            // 성적표 점수는 1~99까지
            // 90점 이상은 A
            // 80점 이상은 B
            // 70점 이상은 C
            // 60점 이상은 D
            // 나머지는 F
            // 성적의 1점대 점수가 5이상이면 + 를 출력한다.
            // 예) 91 = A, 96 = A+


            // 조건1
            // 90점 이상은 A
            // 80점 이상은 B
            // 70점 이상은 C
            // 60점 이상은 D
            // 나머지는 F

            // 조건 2
            // 성적의 1점대 점수가 5이상이면 + 를 출력한다.

            static void Main(string[] args)
            {
                // Switch 문
                // 변수의 값에 따라서 다양한 코드를 선택적으로 실행할 수 있게 하는 문법

                int grade = 95;
                string tear = "";

                // 10점 대의 점수의 숫자에 따라서 등급을 나타낸다.
                // switch 문
                // switch(변수 혹은 데이터)
                // {
                //      case (변수 혹은 데이터의 특정 값);
                //      {
                //          switch(변수) 있는 값이 case (데이터)와 일치하면 여기있는 코드 블록을 실행한다.
                //      }
                //      break; 여기 있는 케이스를 벗어난다.
                //      case (변수 혹은 데이터의 특정 값);
                //      {
                //          switch(변수) 있는 값이 case (데이터)와 일치하면 여기있는 코드 블록을 실행한다.
                //      }
                //      break; 
                // }

                // 10점 대의 점수의 숫자에 따라서 등급을 나타낸다.
                switch (grade / 10)
                {
                    case 9: // {} 생각해도 상관없다.
                        tear = "A";
                        break;
                    case 8:
                        tear = "B";
                        break;
                    case 7:
                        tear = "C";
                        break;
                    case 6:
                        {
                            tear = "D";
                        }
                        break;
                    default:
                        tear = "F";
                        break;
                }


                // 조건 2
                // 성적의 1점대 점수가 5이상이면 + 를 추가해서 출력한다.
                if (grade % 10 >= 5)
                {
                    tear += "+";
                }

                Console.WriteLine(tear);
            }
        }
    }
}
