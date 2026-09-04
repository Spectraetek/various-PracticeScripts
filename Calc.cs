using System;

namespace PracticePrograms;

public class Calculator
{   
    public static float CalculatorFunction()
    {
        Console.Write("Num1: ");
        float num1 = (float)Convert.ToDouble(Console.ReadLine());
        Console.Write("Operator (+, -, *, /, %): ");
        string? mathFunction = Console.ReadLine();
        Console.Write("Num2: ");
        float num2 = (float)Convert.ToDouble(Console.ReadLine());
        float result = float.NaN;
        switch (mathFunction)
        {
            default:
                Console.WriteLine("Invalid Operator");
                break;
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                result = num1 / num2;
                break;
            case "%":
                result = num1 % num2;
                break;
        }
        switch (result)
        {
            default:
                Console.WriteLine(result);
                break;
            case float.NaN:
                Console.WriteLine("Invalid Result: Result is not real, or cannot be represented by a float");
                break;
        }

        return result;
    }
    public static void CalcMain()
    {
        Console.Clear();
        bool repeat = true;
        while (repeat)
        {
            bool isValid = false;
            repeat = true;
            CalculatorFunction();
            Console.WriteLine("Another?");
            while (!isValid)
            {
                var temp1 = Console.ReadLine();
                if (temp1 == null)
                {
                    Console.WriteLine("INVALID: Cannot use Null value, type Y/Yes or N/No");
                    isValid = false;
                }
                else if (temp1.GetType() != typeof(string))
                {
                    Console.WriteLine("INVALID: Value must be a string, type Y/Yes or N/No");
                    isValid = false;
                }
                else if (temp1 == "")
                {
                    Console.WriteLine("INVALID: Cannot use empty string, type Y/Yes or N/No");
                    isValid = false;
                }
                else
                {
                    temp1 = temp1.ToLower();
                    isValid = true;
                    switch (temp1)
                    {
                        default:
                            Console.WriteLine("Invalid, exiting");
                            repeat = false;
                            break;
                        case "y" or "yes":
                            repeat = true;
                            break;
                        case "n" or "no":
                            repeat = false;
                            break;
                    }
                }
            }
        }
    }
}