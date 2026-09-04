using System;
using System.Collections.Generic;

namespace PracticePrograms;

public class Hangman
{
    public static void GameMain()
    {
        Console.Clear();
        const bool debug = true;
        var selectedWord = WordBankSelect(debug);
        LifePrint(0, 5);
        WordGuessPrint(selectedWord, debug);
    }
    public static void LifePrint(int curLife, int maxLife)
    {
        const string lifeUnused = "-";
        const string lifeUsed = "X";
        Console.Write("[");
        var i = 0;
        while (i<maxLife)
        {
            if (i<curLife)
            {
                Console.Write(lifeUsed);
            } else
            {
                Console.Write(lifeUnused);
            }
            i++;
        }
        Console.WriteLine("]");
    }
    public static string WordBankSelect(bool debug)
    {
        string[] wordBank = ["Grief", "Angelicide", "Vehemence", "Kocmoc Unleashed", "Heliopolis", "Raw Concrete", "Exasperation", "Society", "Thinking Space 2", "Amethyst", "Flamewall", "Tidal Wave", "Green Bullet", "Orbit", "Antarctic Lights", "Nullscapes", "Quanteuse Processing", "Boobawamba", "The Bloop", "Every End", "Penumbral", "Silent Clubstep", "Ashley Wave Trials", "Ultra Paracosm", "Andromeda", "Killstealer", "Subsuming Vortex", "Anathema", "Avernus", "Acheron", "Spectre", "Menace", "Abyss of Aarkness", "Defeated Circles", "Tunnel of Despair", "Kyouki", "Based After Based", "The Lightning Rod", "Slaughterhouse"];
        Random rnd = new();
        var wordBankLength = wordBank.Length - 1;
        var randomNum = rnd.Next(0, wordBankLength);
        var selectedWord = wordBank[randomNum];
        if (debug)
        {
            Console.WriteLine(randomNum + ", " + wordBankLength + ", " + selectedWord);
        }
        return selectedWord;
    }
    public static void WordGuessPrint(string word, bool debug)
    {
        var wordLength = word.GetNormalizedLength();
        if (debug)
        {
            Console.WriteLine(wordLength);
        }
        //Console.WriteLine("");
        var letters = word.ToLower().ToCharArray();
        var i = 0;
        var letterDisplay = new List<string>();
        while (i < wordLength)
        {
            letterDisplay.Add("-");
            i++;
        }
        Console.WriteLine(string.Join("", letterDisplay));
        Console.WriteLine("Letter to guess?");
        Console.WriteLine("");
        var guess = Console.ReadLine();
        if (letters.Contains<char>(guess[0]))
        {
            //
        }
    }
}