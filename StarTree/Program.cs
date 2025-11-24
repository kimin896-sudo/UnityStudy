namespace StarTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    if (i >= j)
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j >= i)
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
