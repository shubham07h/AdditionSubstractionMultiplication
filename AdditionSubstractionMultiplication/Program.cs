// See https://aka.ms/new-console-template for more information
Console.WriteLine("Addition!");
namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;
            Console.Write("Enter First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            sum = num1 + num2;
            Console.Write("Sum of Both Numbers = " +sum);
            Console.ReadLine();
        }
    }
}
