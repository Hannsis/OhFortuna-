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
            SpelIntro();
            int pix = 500;


            bool keepPlaying = true;

            Console.WriteLine($"You have {pix}");



            while (keepPlaying)
            {
                Console.WriteLine("\nHow much pix are you willing to gamble?(minimum 50)");
                int pixGambled = int.Parse(Console.ReadLine());
                while (true)
                {
                    Console.WriteLine();
                    if (pixGambled >= 50 && pixGambled <= pix)
                    {
                        keepPlaying = true;
                        break;
                    }
                    else
                        Console.WriteLine("Fel input");//Hur breakar jag ut loopen????
                    break;

                }

                Random random = new Random();//generate random number
                List<int> Dice = new();
                Dice.Add(random.Next(1, 7));
                Dice.Add(random.Next(1, 7));
                Dice.Add(random.Next(1, 7));

                Console.WriteLine("\nPick your lucky number and roll the dice.");
                int luckyNumber = int.Parse(Console.ReadLine());
                Console.WriteLine($"\r\nThe dice shows: {Dice[0]}, {Dice[1]} and {Dice[2]}");//vill ha nya randoms

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
            static void SpelIntro()
            {
                Console.WriteLine("Welcome to Pay'N'Play, the place where you get rich or die trying!");
                Console.WriteLine("Your total Pixx is 500, and you must gamble at least 50 per turn");
                Console.WriteLine("            o If one of the dice shows your lucky number you get DOUBLE the pix\r\n            o At two dice TRIPPLE the pix\r\n            o If all three dice show your lucky number, FOUR times the pix");


            }

            static void RollDice()
            {

                Random random = new Random();//generate random number
                int diceRoll = (random.Next(1, 7));

            }

            static void PixCounter()
            {
                /*
                  - 50 för varje gång man spelar

                 */
            }
        }
    }
}