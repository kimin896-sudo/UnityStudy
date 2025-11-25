namespace Method
{
    delegate int myDel(int a);
    internal class Program
    {
        public static int Test(int num1)
        {
            num1++;
            return num1;
        }
        public static int Test1(int num1)
        {
            num1--;
            return num1;
        }

        static void Main(string[] args)
        {
            myDel my = Test;
            myDel my1 = Test1;

            Console.WriteLine($"{my(10)}");
        }
    }
}
