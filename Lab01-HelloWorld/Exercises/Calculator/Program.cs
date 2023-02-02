
// create a function to perform the calculation
static void Calculation()
{
    // 1. Ask the user for the first number
    Console.Write("Enter the first number\n> ");
    var firstNumber = Console.ReadLine();

// 2. Ask the user for the second number
    Console.Write("Enter the second number\n> ");
    var secondNumber = Console.ReadLine();

// 3. Ask the user for the operation to perform
    Console.Write("Enter the operation to perform\n> ");
    var operation = Console.ReadLine();

// 4. Perform the operation
    double result = 0;
    switch (operation)
    {
        case "+":
            result = double.Parse(firstNumber!) + double.Parse(secondNumber!);
            break;
        case "-":
            result = double.Parse(firstNumber!) - double.Parse(secondNumber!);
            break;
        case "*":
            result = double.Parse(firstNumber!) * double.Parse(secondNumber!);
            break;
        case "/":
            result = double.Parse(firstNumber!) / double.Parse(secondNumber!);
            break;
        default:
            Console.WriteLine("Unknown operation '{0}'", operation);
            break;
    }

// 5. Display the result
    Console.WriteLine("The result is {0}", result);

// 6. Ask the user if they want to perform another calculation
    Console.Write("Do you want to perform another calculation? (y/n) > ");
    var answer = Console.ReadLine();
    if (answer == "y")
    {
        // 7. If yes, go back to step 1
        Calculation();
    }
    else
    {
        // 8. If no, exit
        Console.WriteLine("Goodbye!");
    }
}

Calculation();