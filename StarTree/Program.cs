namespace StarTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 별만들기1
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i >= j)
                        Console.Write("*");
                }
                Console.WriteLine();
            }

            // 별만들기2
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
