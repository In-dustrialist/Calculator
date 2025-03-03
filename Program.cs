using Calculator;

CalculatorClass calc = new CalculatorClass();

Console.WriteLine("Enter first number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Addition: {calc.Additional(num1, num2)}");
Console.WriteLine($"Subtraction: {calc.Subtraction(num1, num2)}");
Console.WriteLine($"Multiplication: {calc.Miltiplication(num1, num2)}");

try
{
    Console.WriteLine($"Division: {calc.Division(num1, num2)}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}