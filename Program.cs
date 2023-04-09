namespace PowerNumber;
class Program
{
    static void Main(string[] args)
    {
        int num = 28;
        int sum = 0;

        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }

        if (sum == num)
        {
            Console.WriteLine(num + " is Perfect number.");
        }
        else
        {
            Console.WriteLine(num + " is not Perfect number.");
        }
    }
}

