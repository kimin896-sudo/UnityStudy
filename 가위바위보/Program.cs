using System;


    internal class Program
    {
        enum SRP
        {
            SCISSORSSS = 1,
            ROCK = 2,
            PAPER = 3,
        }
        static void Main(string[] args)
        {
            bool isBool = true;
            while (isBool)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("가위 바위 보 게임(1. 가위, 2. 바위 3. 보 4. 끝내기");
                Console.WriteLine("=================================");

                string mychoice = Console.ReadLine();
                int mychoiceInt = int.Parse(mychoice);
                SRP myChoiceSRP = (SRP)mychoiceInt;

                // 1 가위 2 바위 3 보
                Random rand = new Random();
                int comChoiceInt = rand.Next(1, 4);
                SRP comChoice = (SRP)comChoiceInt;
                switch (myChoiceSRP)
                {
                    // 가위
                    case SRP.SCISSORSSS:
                        Console.WriteLine($"컴퓨터 : {comChoice} 나 : {myChoiceSRP}");
                        GetResult(myChoiceSRP, comChoice);
                        break;
                    //바위
                    case SRP.ROCK:
                        Console.WriteLine($"컴퓨터 : {comChoice} 나 : {myChoiceSRP} ");
                        GetResult(myChoiceSRP, comChoice);
                        break;
                    //보
                    case SRP.PAPER:
                        Console.WriteLine($"컴퓨터 : {comChoice} 나 : {myChoiceSRP} ");
                        GetResult(myChoiceSRP, comChoice);
                        break;
                    default:
                        Console.WriteLine("잘 못 된 입력");
                        isBool = false;
                        break;
                }
            }
            void GetResult(SRP my, SRP com)
            {
                int myInt = (int)my;
                int comInt = (int)com;

                // 가위,바위,보
                // 1 > 2 > 3
                if (my == com)
                {
                    Console.WriteLine("무승부");
                }
                else if (my == SRP.ROCK)
                {
                    if (com == SRP.SCISSORSSS)
                        Console.WriteLine("승리");
                    else if (com == SRP.PAPER)
                        Console.WriteLine("패배");
                }
                else if (my == SRP.SCISSORSSS)
                {
                    if (com == SRP.PAPER)
                        Console.WriteLine("승리");
                    else if (com == SRP.ROCK)
                        Console.WriteLine("패배");
                }
                else if (my == SRP.PAPER)
                {
                    if (com == SRP.ROCK)
                        Console.WriteLine("승리");
                    else if (com == SRP.SCISSORSSS)
                        Console.WriteLine("패배");
                }

            }
        }
    }
