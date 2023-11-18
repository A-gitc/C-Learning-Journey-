namespace Day_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that takes a number from the user then print yes
            //if that number can be divided by 3 and 4 otherwise print no.

            Console.Write("Enter a number to check if the number divisible by 3 and 4: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine((num % 3 == 0 && num % 4 == 0) ? "Yes" : "No");
        }
    }
}
