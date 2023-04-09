namespace FibonaccciNumber;
class Fibonacci
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of Fibonacci terms: ");
        int numTerms = int.Parse(Console.ReadLine());

        int a = 0, b = 1, c = 0;

        Console.WriteLine("{0} {1}", a, b);

        for( int i = 3; i <= numTerms; i++)
        {
            c = a + b;
            Console.WriteLine(" {0}", c);
            a = b;
            b = c;
        }
        Console.WriteLine();
    }
}

