/*

varibale som håller koll på hur mycket man har, input satsar inte fel, variable kollar på vad man satsar och lyckotalet
if satser, följ instruktioner en rad i taget - deklarera etc 
först del a, sen implentera regler efter spelet. man skriver i den ordningen man ska tänka

 */


using System;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;

namespace OhFortuna_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            bool keepPlaying = true;
           
           
            //menyval - spela eller få instruktioner
            //Eftersom loopen ska undersöka variabeln som innehåller användarensval så måste denna deklareras innan loopen.
            string inputVal = "";

            while (inputVal != "3") //all kod som man vill ska upprepas ska måste ligga i en loop.
            {
                Console.WriteLine("Välj ett av följande val: ");
                Console.WriteLine("1. Få spelets regler");
                Console.WriteLine("2. Spela spelet");
                Console.WriteLine("3. Avsluta spelet");

                inputVal = (Console.ReadLine());

                switch (inputVal)
                {
                    case "1":
                        SpelIntro();
                        break;

                    case "2":
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
                                        Console.WriteLine("Fel input");//Hur breakar jag ut loopen????
                                }

                            }

                            Random random = new Random();//generate random number
                            List<int> Dice = new();
                            Dice.Add(random.Next(1, 7));
                            Dice.Add(random.Next(1, 7));
                            Dice.Add(random.Next(1, 7));

                            int luckyNumber = 0;
                            while (true)
                            {
                                Console.WriteLine("\nPick your lucky number and roll the dice.");
                                string input = Console.ReadLine();

                                if (int.TryParse(input, out luckyNumber))
                                {
                                    Console.WriteLine();
                                    if (luckyNumber >= 1 && luckyNumber <= 7)
                                    {
                                        keepPlaying = true;
                                        break;
                                    }
                                    else
                                        Console.WriteLine("Fel input");//Hur breakar jag ut loopen????
                                }

                            }
                         
                            Console.WriteLine($"\r\nThe dice shows: {Dice[0]}, {Dice[1]} and {Dice[2]}");//vill ha nya randoms FIXAT

                            int match = 0;
                            for (int roll = 0; roll < Dice.Count; roll++)//deklarerar, kontrollerar, bearbetar (one time use).
                            {
                                if (Dice[roll] == luckyNumber)
                                    match++;
                            }

                            pix = pix - pixGambled;
                            if (match == 3)//4 ggr bet 
                            {

                                Console.WriteLine($"You got {match} of the dice right");
                                pix += (pixGambled * 4);
                                Console.WriteLine($"You won FOUR times the money, you now have: {pix}");

                            }
                            else if (match == 2)//3 ggr bet
                            {
                                Console.WriteLine($"You got {match} of the dice right");
                                pix += (pixGambled * 3);
                            }
                            else if (match == 1)//2 ggr bet
                            {
                                Console.WriteLine($"You got {match} of the dice right");
                                pix += (pixGambled * 2);
                            }
                            else
                                Console.WriteLine($"You got {match} of the dice right");

                            Console.WriteLine();


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
                                continue;
                            }
                            else
                            {
                                keepPlaying = false;
                                break;
                            }
                        }

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
                Console.WriteLine("Your total Pixx is 500, and you must gamble at least 50 per turn");
                Console.WriteLine("            o If one of the dice shows your lucky number you get DOUBLE the pix\r\n            o At two dice TRIPPLE the pix\r\n            o If all three dice show your lucky number, FOUR times the pix");
                Console.WriteLine("Good luck\n\n");
            }        
           
        }
    }
}