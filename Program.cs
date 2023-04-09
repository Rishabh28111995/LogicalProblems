namespace ReverseNumber;
class Program
{
    static void Main(string[] args)
    {
        int num;
        int reversedNum = 0;
        Console.WriteLine("Enter a number: ");
        num = int.Parse(Console.ReadLine());

        while (num > 0)
        { 
            int digit = num % 10;
           reversedNum = reversedNum * 10 + digit;

            num /= 10;
        }
        Console.WriteLine("Reversed number is: " + reversedNum);
    }
}

