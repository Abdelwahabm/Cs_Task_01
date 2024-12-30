namespace task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Large, Small;
            double Cost ;

            Console.WriteLine("Welcome to our Laundry");

            Console.Write("Please Enter Number of Large Carpets: ");
            Large = Convert.ToInt32 ( Console.ReadLine() );

            Console.Write("Please Enter Number of Small Carpets: ");
            Small = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Price for One Large Carpet: $35 ");
            Console.WriteLine("Price for One Small Carpet: $25 ");

            Cost = (Large * 35) + (Small * 25);
            Console.WriteLine($"Cost: ${Cost}");
            Console.WriteLine("Tax: $6.6");

            Cost = Cost + 6.6;
            Console.WriteLine($"Total Cost: ${Cost}");
            Console.WriteLine("This estimate is valid for 30 days ");
            Console.WriteLine("Thank you ");
        }
    }
}
