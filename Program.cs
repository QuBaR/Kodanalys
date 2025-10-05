using System;

namespace Kodanalys
{
    class Program
    {
        static string[] userArray = new string[10];
        static int maxUsers = 0;

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

                if (menuChoice == "1")
                {
                    Console.Write("Ange namn: ");
                    string newUser = Console.ReadLine();
                    if (maxUsers < 10)
                    {
                        userArray[maxUsers] = newUser;
                        maxUsers++;
                    }
                    else
                    {
                        Console.WriteLine("Listan är full!");
                    }
                }
                else if (menuChoice == "2")
                {
                    Console.WriteLine("Användare:");
                    for (int i = 0; i < maxUsers; i++)
                    {
                        Console.WriteLine(userArray[i]);
                    }
                }
                else if (menuChoice == "3")
                {
                    Console.Write("Ange namn att ta bort: ");
                    string userToRemove = Console.ReadLine();
                    int userArrayIndex = -1;
                    for (int i = 0; i < maxUsers; i++)
                    {
                        if (userArray[i] == userToRemove)
                        {
                            userArrayIndex = i;
                            break;
                        }
                    }

                    if (userArrayIndex != -1)
                    {
                        for (int i = userArrayIndex; i < maxUsers - 1; i++)
                        {
                            userArray[i] = userArray[i + 1];
                        }
                        maxUsers--;
                    }
                    else
                    {
                        Console.WriteLine("Användaren hittades inte.");
                    }
                }
                else if (menuChoice == "4")
                {
                    Console.Write("Ange namn att söka: ");
                    string search = Console.ReadLine();
                    bool userFound = false;
                    for (int i = 0; i < maxUsers; i++)
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
                }
                else if (menuChoice == "5")
                {
                    programActive = false;
                }
                else
                {
                    Console.WriteLine("Ogiltigt val.");
                }
                Console.WriteLine();
            }
        }
    }
}
