namespace Cumulative
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            
            int result = 0;
            for (int i = 1; i <= 10; i++)
            {
                result += i;
            }
            Console.WriteLine($"{result}");
        }


    }
}
