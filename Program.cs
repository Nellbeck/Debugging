/*
 * Fredrik Nellbeck
 * Felsökning
 * Systemutveckling.NET med AI-kompitens
 * .NET23_OOP
 */

namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Case 1
            
            'Koden genererar ett fel och körs inte.'

            int number = 2;

            if (number > 3)
            {
                Console.WriteLine("Talet är större än tre")
            }
            elseif(number < 3)
            {
                Console.WriteLine("Talet är mindre än tre");
            }
            */

            int number = 2;

            if (number > 3)
            {
                Console.WriteLine("Talet är större än tre"); // Fattades ett semi-colon ';' på slutet av kodraden så jag satt dit ett.
            }
            else if (number < 3) // Inget mellanslag mellan 'else' och 'if' så jag la dit ett.
            {
                Console.WriteLine("Talet är mindre än tre");

            }

            /* Case 2
             
            Koden ska skriva ut alla siffror mellan 1 och 100 men skriver bara ut till nummer 99

            for(int i=1; i<100; i++)
            {
                 Console.WriteLine(i);
            }
            */

            for (int i = 1; i <= 100; i++) // Eftersom variablen 'i' i for-satsen inte får vara 100 så kommer den aldrig att räkna till 100. 
            {                               // Det jag ändrade 'i < 100' till 'i <= 100' så att 'i' får vara 100.
                Console.WriteLine(i);
            }

            /* Case 3
            
            Koden genererar ett fel och körs inte 

            for (int i = 1; i <= 5; i)
            {
                for (int j = 1; j <= i; j)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            */

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++) // Både variablera 'i' och 'j' ökar inget i värde då kan inte for-looperna (varken den inre eller ytre) fortsätta.
                {                            //  Det jag fick göra var att lägga till '++' så att de ökar i värde med 1.
                    Console.Write(j + " ");
                }
                Console.WriteLine();

            }


            /* Case 4

            Koden har ingen output, varför inte?

            int i = 1;
            while (i <= 5)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write();
                }

                Console.WriteLine();
                i++;
            }
            */

            int i = 1;
            while (i <= 5)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j); // Eftersom det inte finns något inom '()' så kommer inget att skrivas ut.
                }                       // Det beror på vad man vill ska skrivas ut men jag la in variabeln 'j' för att se hur långt den räknar för varje loop.

                Console.WriteLine();
                i++;
            }

            /* Case 5
            
            Eftersom i är 1 i exemplet nedan förväntar vi oss att koden inte ska göra något men nu skriver den ut "Two". 
            Varför blir det så och hur löser vi det så att det inte blir någon utskrift om i är 1?
            
            int i = 1;

            switch (i)
            {
                case 1:
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
            */

            int i = 1;

            switch (i)
            {
                case 1: // case 1 går in i case 2 eftersom det inte finns något 'break;' kommando som skiljer dem åt.
                    break; // Det jag gjorde var helt enkelt lägga in ett 'break;' kommando så bara case 1 körs och inte både 1 och 2.
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }

            /* Case 6

            Koden genererar ett fel och körs inte.

            int i = 10;

            if (i = 5)
            {
                Console.WriteLine("i är 5");
            }*/

            int i = 10;
                        // En if-sats kollar bara om vilkoren är sanna eller falska. '=' operatorn säger bara att 'i' ska vara '5' som i sig inte är ett vilkor.
            if (i == 5) // Därav kan if-satsen inte få fram om något är sant eller falskt. Vad jag gjorde va att lägga in '==' operatorn i vilkoren.
            {           // Nu kan if-satsen kolla om vilkoren är sant eller falskt och köra sitt kodblock eller inte beroende på vad den kommer fram till.
                Console.WriteLine("i är 5");
            }
        }
    }
}