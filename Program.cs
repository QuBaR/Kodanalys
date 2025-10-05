using System;
using System.Collections.Generic;

namespace Kodanalys
{
    class Program // ändrade klassnamn från "program" till "Program" för att följa C# konventioner
    {
        static string[] celestialWhispers = new string[10];
        static List<string> users = new List<string>(); // ändrade från array till List för bättre hantering av användare

        static void Main(string[] args)
        {
            bool isRunning = true; // lade till en flagga för att kontrollera loopen
            while (isRunning)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till användare");
                Console.WriteLine("2. Visa alla användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");

                string? choice = Console.ReadLine(); // lade till null-conditional operator för att undvika potentiella null-referensfel

                switch (choice)// lade till switch-sats för bättre struktur
                {
                    case "1":
                        Console.Write("Ange namn: ");
                        string? name = Console.ReadLine();

                        users.Add(name); // lade till användaren till listan
                        break;

                    case "2":
                        Console.WriteLine("Användare:");
                        foreach (var user in users)// itererar genom listan för att visa alla användare
                        {
                            Console.WriteLine(user);
                        }
                        break;

                    case "3":
                        Console.Write("Ange namn att ta bort: ");
                        string? nameToRemove = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(nameToRemove))
                        {
                            if (users.Remove(nameToRemove))// försöker ta bort användaren och kollar om det lyckades
                            {
                                Console.WriteLine("Användaren togs bort.");
                            }
                            else
                            {
                                Console.WriteLine("Användaren hittades inte.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Namnet kan inte vara tomt.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Ange namn att söka: ");
                        string? nameToSearch = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(nameToSearch))
                        {
                            if (users.Contains(nameToSearch))
                            {
                                Console.WriteLine("Användaren finns i listan.");
                            }
                            else
                            {
                                Console.WriteLine("Användaren hittades inte.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Namnet kan inte vara tomt.");
                        }
                        break;

                    case "5":
                        isRunning = false;// sätter flaggan till false för att avsluta loopen
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val.");
                        break;
                }
                Console.WriteLine();//Lade till en tom rad för bättre läsbarhet i konsolen
            }
        }
    }
}




























