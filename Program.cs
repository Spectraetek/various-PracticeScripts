using System;

namespace PracticePrograms;

public class ScriptLauncher
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Choose program to run, 1 = Calc.cs, 2 = Hangman.cs (wip): ");
        int answerChoice = Convert.ToInt32(Console.ReadLine());
        switch (answerChoice)
        {
            default : 
                Console.WriteLine("Invalid, exiting");
                break;
            case 1 : 
                Calculator.CalcMain();
                break;
            case 2 : 
                Hangman.GameMain();
                break;
        }
    }
}