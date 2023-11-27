using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_21_Delegates
{
    delegate int ArithmeticOperation(int a, int b);
    internal class Program
    {
        // Step 2: Implement static methods for arithmetic operations
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static int Divide(int a, int b)
        {
            if (b != 0)
                return a / b;
            else
            {
                Console.WriteLine("Cannot divide by zero.");
                return 0;
            }
        }
        static void Main(string[] args)
        {
            // Step 3: Create instances of the delegate for each method
            ArithmeticOperation addDelegate = new ArithmeticOperation(Add);
            ArithmeticOperation subtractDelegate = new ArithmeticOperation(Subtract);
            ArithmeticOperation multiplyDelegate = new ArithmeticOperation(Multiply);
            ArithmeticOperation divideDelegate = new ArithmeticOperation(Divide);

            // Step 4: Ask the user to input two integers
            Console.Write("Enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Step 5: Prompt the user to choose an arithmetic operation
            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            // Step 6: Based on the user's choice, call the corresponding method through the delegate and display the result
            Console.Write("Enter your choice (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (choice)
            {
                case 1:
                    result = addDelegate(num1, num2);
                    Console.WriteLine($"Result of Addition: {result}");
                    break;
                case 2:
                    result = subtractDelegate(num1, num2);
                    Console.WriteLine($"Result of Subtraction: {result}");
                    break;
                case 3:
                    result = multiplyDelegate(num1, num2);
                    Console.WriteLine($"Result of Multiplication: {result}");
                    break;
                case 4:
                    result = divideDelegate(num1, num2);
                    Console.WriteLine($"Result of Division: {result}");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
