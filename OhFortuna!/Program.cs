namespace OhFortuna_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Spelbolaget Play’n’Pay behöver en bra algoritm för att skapa ett Fortuna-spel 
            till sina spelmaskiner.
            Så för att testa om spelet fungerar som den ska, ska vi skriva kod för det.

            Spelet använder valutan pix.
            Uppgiften:
            Spelaren startar med 500 pix
            • Spelrunda:
            o Spelaren satsar pix (minst 50 pix)
            o Spelaren väljer ett lyckotal (1-6)
            o Tre T6-tärningar kastas
            o Om en tärning visar lyckotalet får man dubbla insatsen
            o Om två tärningar visar får man tre gånger insatsen
            o Om alla tärningarna visar lyckonumret så får man fyra gånger insatsen.
            • Regler
            o Spelaren får inte satsa mer än vad denne har på banken
            o Spelaren får inte fuska och satsa negativa värden
            o Om spelarens konto understiger 50 pix avslutas spelet
            o Efter en runda får spelaren se sitt saldo och välja om denne vill köra en runda till
            */

            SpelIntro();

            int gamblersChoice = int.Parse(Console.ReadLine());

            Console.WriteLine($"\r\n The dice shows:");
            RollDice();
            RollDice();
            RollDice();

          


        }
        static void SpelIntro() 
        {
            Console.WriteLine("Welcome to Pay'N'Play, the place where you get rich or die trying!");
            Console.WriteLine("The price is at a low 50 pix per turn! Only 500Pix to enter.");
            Console.WriteLine("            o If one of the dice shows your lucky number you get dubble the Pix\r\n            o At two dice TRIPPLE the Pix\r\n            o If all three dice show your lucky number, FOUR times the Pix");
            Console.WriteLine("Pick your lucky number and roll the dice.\r\n");

           
        }
        static void RollDice() 
        {

            Random random = new Random();
            int num = random.Next(1,7);
           
            Console.WriteLine(random.Next(1,7));
            
        }
        static void PixCounter() 
        { 
        /*
          - 50 för varje gång man spelar

         */
        }
    }
}