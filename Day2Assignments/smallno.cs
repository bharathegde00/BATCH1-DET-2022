namespace Day2Assignments

{
    internal class smallno
    {
        public static void Num(int a, int b, out int result)
        {
            if (a > b)
            {
                result = b;
            }
            else
            {
                result = a;
            }
        }
        public static void Main()
        {
            int a, b;
            Console.WriteLine("Enter First Number");


            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second Number");

            b = int.Parse(Console.ReadLine());


            Num(a, b, out int result);
            Console.WriteLine($"The smaller number is {result}");
        }




    }
}
