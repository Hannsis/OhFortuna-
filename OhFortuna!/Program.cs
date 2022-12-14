

using System;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace OhFortuna_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool keepPlaying = true;

            string inputVal = "";
            while (inputVal != "3")
            {
                Menu();

                inputVal = (Console.ReadLine());

                switch (inputVal)
                {
                    case "1":

                        SpelIntro();
                        break;

                    case "2":

                        keepPlaying = Gameplay();
                        break;

                    case "3":
                        Console.WriteLine("Thank you for playing!");
                        break;

                    default:
                        Console.WriteLine("Wrong input value.");
                        break;
                }

            }


            static void SpelIntro()
            {
                Console.WriteLine("Welcome to Pay'N'Play, the place where you get rich or die trying!");
                Console.WriteLine("Your total Pix is 500, and you must gamble at least 50 per turn");
                Console.WriteLine("            o If one of the dice shows your lucky number you get DOUBLE the pix\r\n            o At two dice TRIPPLE the pix\r\n            o If all three dice show your lucky number, FOUR times the pix");
                Console.WriteLine("Good luck\n\n");

            }

            static void Menu()
            {
                Console.WriteLine("Chose one of the following: ");
                Console.WriteLine("1. How to play!");
                Console.WriteLine("2. Pay'N'PLAY");
                Console.WriteLine("3. Quit the game (only for cowards)");

            }

            static int RandomGen(int luckyNumber, int match)
            {
                Random random = new Random();

                List<int> Dice = new();
                Dice.Add(random.Next(1, 7));
                Dice.Add(random.Next(1, 7));
                Dice.Add(random.Next(1, 7));
                Console.WriteLine($"\r\nThe dice shows: {Dice[0]}, {Dice[1]} and {Dice[2]}");

                for (int i = 0; i < Dice.Count; i++)
                {
                    if (Dice[i] == luckyNumber)
                        match++;
                }
                return match;

            }

            static int LuckyNumber(int luckyNumber, bool keepPlaying)
            {
                while (true)
                {
                    Console.WriteLine("\nPick your lucky number and roll the dice.");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out luckyNumber))
                    {
                        Console.WriteLine();
                        if (luckyNumber >= 1 && luckyNumber <= 6)
                        {
                            keepPlaying = true;
                            break;
                        }
                        else
                            Console.WriteLine("This is a dice silly, it only rolls between 1 and 6.");
                    }


                }
                return (luckyNumber);
            }

            static bool Gameplay()
            {
                bool keepPlaying;
                int pix = 500;
                Console.WriteLine($"You have {pix}");

                keepPlaying = true;

                while (keepPlaying)
                {
                    int pixGambled = 0;
                    while (true)
                    {
                        Console.WriteLine("\nHow much pix are you willing to gamble?(minimum 50)");
                        string input = Console.ReadLine();

                        if (int.TryParse(input, out pixGambled))
                        {
                            Console.WriteLine();
                            if (pixGambled >= 50 && pixGambled <= pix)
                            {
                                keepPlaying = true;
                                break;
                            }
                            else
                                Console.WriteLine("Please try again!");
                        }

                    }

                    int match = 0;
                    int luckyNumber = 0;
                    luckyNumber = LuckyNumber(luckyNumber, keepPlaying);
                    match = RandomGen(luckyNumber, match);

                    pix -= pixGambled;

                    if (match == 3)
                    {

                        Console.WriteLine($"You got {match} of the dice right");
                        pix += (pixGambled * 4);
                        Console.WriteLine($"You won FOUR times the money, you now have: {pix}");

                    }
                    else if (match == 2)
                    {
                        Console.WriteLine($"You got {match} of the dice right");
                        pix += (pixGambled * 3);
                    }
                    else if (match == 1)
                    {
                        Console.WriteLine($"You got {match} of the dice right");
                        pix += (pixGambled * 2);
                    }
                    else
                        Console.WriteLine($"You got {match} of the dice right");



                    Console.WriteLine($"You have {pix} left");

                    if (pix < 50)
                    {
                        Console.WriteLine("Sorry, you don't have enough to gamble with.");

                        break;
                    }
                    Console.WriteLine("Do you wish to play again? Y/N");

                    string responses = Console.ReadLine();
                    responses = responses.ToUpper();
                    Console.WriteLine(responses);

                    if (responses == ("Y"))
                    {
                        Console.Clear();
                        Console.WriteLine($"You have {pix} left");
                        continue;

                    }
                    else
                    {
                        keepPlaying = false;
                        Console.Clear();
                        break;
                    }

                }

                return keepPlaying;
            }
        }
    }
}