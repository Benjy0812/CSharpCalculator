namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {


            /*Console.WriteLine("whats your name sir:");
            string name = Console.ReadLine();
            
            
            Console.WriteLine("how old are you:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("whats your gender ?");
            string gender = Console.ReadLine();

            Console.WriteLine("your name is:" + name);
            Console.WriteLine("your are " + age + " years old");
            Console.WriteLine("your gender is:" + gender);*/

            /*int friends = 10;

            friends = friends + 1;
            friends += 1;
            friends++;

            friends = friends - 1;
            friends -= 1;
            friends--;

            friends = friends * 2;
            friends *= 2;

            friends = friends / 2;
            friends /= 2;

            int reaminder = friends % 2;*/

            do {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.Write("------------------");
                Console.Write("Calculator Program");
                Console.Write("------------------");

                Console.WriteLine("\nEnter number 1:  ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter number 2:  ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t% : Multiply");
                Console.WriteLine("\t/ : Divide");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        break;
                    case "%":
                        result = num1 % num2;
                        Console.WriteLine($"Your result: {num1} % {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("Thats was not a valid option");
                            break;
                }
             Console.WriteLine("Would you like to continue? (Y = yes, N = No)");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye");


            /*Console.WriteLine("Whats your name:");
             string name = Console.ReadLine();
             Console.WriteLine($"Your name is {name}!");

             Console.WriteLine("How old are you?");
             int age = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine($"You are:{age} old");*/ 
        }
    }
}
