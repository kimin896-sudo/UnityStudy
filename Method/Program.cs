namespace Method
{
    internal class Program
    {
        static int Test(int num1)
        {
            num1++;
            return num1;
        }

        static void Main(string[] args)
        {


            Console.WriteLine($"{Test(10)}");
        }
    }
}
