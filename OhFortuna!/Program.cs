/*

varibale som håller koll på hur mycket man har, input satsar inte fel, variable kollar på vad man satsar och lyckotalet
if satser, följ instruktioner en rad i taget - deklarera etc 
först del a, sen implentera regler efter spelet. man skriver i den ordningen man ska tänka

 */


using System.Collections.ObjectModel;

namespace OhFortuna_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpelIntro();
            int startingPix = 500;
            Console.WriteLine("\nHow much Pix are you willing to gamble?(minimum 50)");
            int pixGambled = int.Parse(Console.ReadLine());
            Console.WriteLine("\nPick your lucky number and roll the dice.");
            int luckyNumber = int.Parse(Console.ReadLine());

            Random random = new Random();//generate random number
            int diceRoll = (random.Next(1, 7));
            int diceRoll2 = (random.Next(1, 7));
            int diceRoll3 = (random.Next(1, 7));
            bool keepPlaying = true; 
       

            Console.WriteLine($"\r\n The dice shows: {diceRoll}, {diceRoll2} and {diceRoll3}");//vill ha nya randoms
            while (keepPlaying)
            {  
                
                if (startingPix < 50)
                {
                    Console.WriteLine("Sorry, you don't have enough to gamble with.");
                    break;
                }

            }
          
            

            

        }
        static void SpelIntro() 
        {
            Console.WriteLine("Welcome to Pay'N'Play, the place where you get rich or die trying!");
            Console.WriteLine("Your total Pixx is 500, and you must gamble at least 50 per turn");
            Console.WriteLine("            o If one of the dice shows your lucky number you get DOUBLE the Pix\r\n            o At two dice TRIPPLE the Pix\r\n            o If all three dice show your lucky number, FOUR times the Pix");
         
                       
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