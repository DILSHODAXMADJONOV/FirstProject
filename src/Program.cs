namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("son : ");
            var number = Convert.ToInt32(Console.ReadLine());

            var ones = number % 10;
            var tens = number / 10 % 10;
            var hundreds = number / 100 % 10;
            var result = tens * 100 + hundreds * 10 + ones;

            Console.WriteLine(result);
        }
    }
}
