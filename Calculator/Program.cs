namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1;
                double num2;
                double result;

                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                Console.Write("Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter secund number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t% : Modulus");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter your option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = {result}");
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = {result}");
                        break;
                    case "%":
                        result = num1 % num2;
                        Console.WriteLine($"Your result: {num1} % {num2} = {result}");
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
                Console.Write("Would you like to continue? (y = yes, n = no): ");
            } while ((Console.ReadLine() ?? string.Empty).ToLower() == "y");

            Console.WriteLine("Bye");
        }
    }
}