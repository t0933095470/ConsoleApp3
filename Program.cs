// Relational and logical operator

internal class Program
{
    private static void Main(string[] args)
    {
        // Declare variables
        float a = 230.243f;
        float b = 120.23f;

        // Deploy some relational operations
        bool check_1 = a > b;
        bool check_2 = a < b;
        bool check_3 = a == b;
        bool check_4 = a != b;
        bool check_5 = a <= b;
        bool check_6 = a >= b;

        // Print out results
        Console.WriteLine("a is 230f and b is 120f");
        Console.WriteLine("a > b: " + check_1);
        Console.WriteLine("a < b: " + check_2);
        Console.WriteLine("a == b: " + check_3);
        Console.WriteLine("a != b: " + check_4);
        Console.WriteLine("a <= b: " + check_5);
        Console.WriteLine("a >= b: " + check_6);

        // Deploy some logical operations
        bool check_7 = true && true;
        bool check_8 = true && false;
        bool check_9 = true || false;
        bool check_10 = false || false;
        bool check_11 = !(false);
        bool check_12 = !(true);

        // Print out results
        Console.WriteLine("true && true:" + check_7);
        Console.WriteLine("true && false: " + check_8);
        Console.WriteLine("true || false: " + check_9);
        Console.WriteLine("false || false: " + check_10);
        Console.WriteLine("!(false): " + check_11);
        Console.WriteLine("!(true): " + check_12);
    }
}