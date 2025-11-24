namespace Homwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"{i}는 짝수 입니다.");
                else
                    Console.WriteLine($"{i}은 홀수 입니다.");
            }
        }
    }
}
