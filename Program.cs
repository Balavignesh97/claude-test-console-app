Console.WriteLine("==============================");
Console.WriteLine("   Claude Test Console App    ");
Console.WriteLine("==============================");
Console.WriteLine();

bool running = true;

while (running)
{
    Console.WriteLine("Select an option:");
    Console.WriteLine("  1. Greet");
    Console.WriteLine("  2. Calculator");
    Console.WriteLine("  3. Reverse a string");
    Console.WriteLine("  4. Exit");
    Console.Write("> ");

    string? choice = Console.ReadLine();
    Console.WriteLine();

    switch (choice)
    {
        case "1":
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to the test app.");
            break;

        case "2":
            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double a)) { Console.WriteLine("Invalid number."); break; }
            Console.Write("Enter operator (+, -, *, /): ");
            string? op = Console.ReadLine();
            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double b)) { Console.WriteLine("Invalid number."); break; }

            double result = op switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" when b != 0 => a / b,
                "/" => double.NaN,
                _ => double.NaN
            };

            Console.WriteLine(double.IsNaN(result)
                ? "Invalid operation or division by zero."
                : $"Result: {a} {op} {b} = {result}");
            break;

        case "3":
            Console.Write("Enter a string to reverse: ");
            string? input = Console.ReadLine() ?? "";
            Console.WriteLine($"Reversed: {new string(input.Reverse().ToArray())}");
            break;

        case "4":
            running = false;
            Console.WriteLine("Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid option. Please choose 1-4.");
            break;
    }

    Console.WriteLine();
}
