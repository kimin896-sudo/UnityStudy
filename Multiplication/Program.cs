namespace Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 9; i++)
            {
                Console.WriteLine($"{i}단");
                for (int j = 2; j <= 9; j++)
                {
                    Console.WriteLine($"{i} * {j}  = {i * j}");
                }
                Console.WriteLine();
            }
        }
    }
}
