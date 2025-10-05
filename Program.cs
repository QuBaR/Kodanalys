using System;

namespace Kodanalys
{
    class Program
    {
        static string[] userArray = new string[10];
        static int ammountOfUsers = 0;

        static void Main(string[] args)
        {
            bool programActive = true;
            while (programActive)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till användare");
                Console.WriteLine("2. Visa alla användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");
                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Console.Write("Ange namn: ");
                        string newUser = Console.ReadLine();
                        if (ammountOfUsers < 10)
                        {
                            userArray[ammountOfUsers] = newUser;
                            ammountOfUsers++;
                        }
                        else
                        {
                            Console.WriteLine("Listan är full!");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Användare:");
                        for (int i = 0; i < ammountOfUsers; i++)
                        {
                            Console.WriteLine(userArray[i]);
                        }
                        break;

                    case "3":
                        Console.Write("Ange namn att ta bort: ");
                        string userToRemove = Console.ReadLine();
                        int userArrayIndex = -1;

                        for (int i = 0; i < ammountOfUsers; i++)
                        {
                            if (userArray[i] == userToRemove)
                            {
                                userArrayIndex = i;
                                break;
                            }
                        }

                        if (userArrayIndex != -1)
                        {
                            for (int i = userArrayIndex; i < ammountOfUsers - 1; i++)
                            {
                                userArray[i] = userArray[i + 1];
                            }
                            ammountOfUsers--;
                        }
                        else
                        {
                            Console.WriteLine("Användaren hittades inte.");
                        }
                        break;

                    case "4":
                        Console.Write("Ange namn att söka: ");
                        string search = Console.ReadLine();
                        bool userFound = false;
                        for (int i = 0; i < ammountOfUsers; i++)
                        {
                            if (userArray[i] == search)
                            {
                                userFound = true;
                                break;
                            }
                        }
                        if (userFound)
                        {
                            Console.WriteLine("Användaren finns i listan.");
                        }
                        else
                        {
                            Console.WriteLine("Användaren hittades inte.");
                        }
                        break;

                    case "5":
                        programActive = false;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
