using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSpaceGame
{
    class Planets
    {
        public static double x1;
        public static double y1;        
        

        public static void Earth(int credits, double time, double currentLocation)
        {           
            bool onEarth = true;
            x1 = 0;
            y1 = 0;

            string keyMain = "good";
            // On planet loop
            do
            {
                // main menu
                Console.Clear();
                Console.WriteLine("Welcome to EARTH!!");
                Console.WriteLine();
                Console.WriteLine("What would you like to do?: ");
                Console.WriteLine("1. Buy: ");
                Console.WriteLine("2. Sell: ");
                Console.WriteLine("3. Travel: ");
                Console.WriteLine("4. Exit");
                keyMain = Console.ReadLine();

                // picked options from main menu
                if (keyMain == "1")
                {
                    Console.Clear();
                    Console.WriteLine("What trade items would you like to buy?");
                    Console.WriteLine("1. Food, price 2,000");
                    Console.WriteLine("2. Research, price 3,000");
                    Console.WriteLine("3. Animals, price 4,000");
                    Console.WriteLine("4. Water, sale price 5,000");
                    Console.WriteLine("5. Fuel, price 6,000");
                    Console.WriteLine("6. Check Current inventory");
                    string keyBuy = Console.ReadLine();

                    // Buy menu
                    // TODO - add credit change and inventory change with buy menus
                    switch (keyBuy)
                    {
                        case "1":
                        case "food":
                        case "Food":
                            Console.WriteLine("You bought food!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "2":
                        case "research":
                        case "Research":
                            Console.WriteLine("You bought research!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "3":
                        case "animals":
                        case "Animals":
                            Console.WriteLine("You bought animals!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "4":
                        case "water":
                        case "Water":
                            Console.WriteLine("You bought water!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "5":
                        case "fuel":
                        case "Fuel":
                            Console.WriteLine("You bought fuel!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "6":
                        case "inventory":
                            Console.Clear();
                            Console.WriteLine("Current inventory: "); // TODO - add inventory checks
                            Console.WriteLine("Press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        default:
                            break;

                    }
                }
                else if (keyMain == "2")
                {
                    Console.Clear();
                    Console.WriteLine("What trade items would you like to Sell?");
                    Console.WriteLine("1. Food, price 1,000");
                    Console.WriteLine("2. Research, price 2,000");
                    Console.WriteLine("3. Animals, price 3,000");
                    Console.WriteLine("4. Water, sale price 4,000");
                    Console.WriteLine("5. Fuel, price 5,000");
                    Console.WriteLine("6. Check Current inventory");
                    string keySell = Console.ReadLine();

                    // Sell menu
                    // TODO - add credit change and inventory change with sell menus
                    switch (keySell)
                    {
                        case "1":
                        case "food":
                        case "Food":
                            Console.WriteLine("You Sold food!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "2":
                        case "research":
                        case "Research":
                            Console.WriteLine("You Sold research!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "3":
                        case "animals":
                        case "Animals":
                            Console.WriteLine("You Sold animals!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "4":
                        case "water":
                        case "Water":
                            Console.WriteLine("You Sold water!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "5":
                        case "fuel":
                        case "Fuel":
                            Console.WriteLine("You Sold fuel!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "6":
                        case "inventory":
                            Console.Clear();
                            Console.WriteLine("Current inventory: "); // TODO - add inventory checks
                            Console.WriteLine("Press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        default:
                            break;

                    }
                }
                else if (keyMain == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Where would you like to go?");
                    Console.WriteLine("1. EARTH, Distance: You are here");  // TODO - add distance to earth from current location
                    Console.WriteLine("2. Alpha Centauri, Distance: --"); //TODO - add distance to alpha centauri using current location + distance to location
                    Console.WriteLine("3. TRAPPIST-1, Distance: --"); //TODO - add distance to TRAPPIST-1 using current location + distance to location
                    Console.WriteLine("4. Main Menu");
                    string keyTravel = Console.ReadLine();

                    if (keyTravel == "1")
                    {
                        Console.WriteLine("You are already here!");
                        Console.WriteLine("Press Enter to return to Main Menu");
                        Console.ReadLine();
                    }
                    else if (keyTravel == "2")
                    {
                        Console.WriteLine("Are you sure you want to travel to Alpha Centauri?");
                        Console.WriteLine("Yes/No");
                        string travelConf = Console.ReadLine();

                        if ((travelConf == "Yes") || (travelConf == "yes")) // Set up travel to alpha centauri
                        {

                        }
                        else if ((travelConf == "no") || (travelConf == "No"))
                        {
                            Console.WriteLine("Press Enter to return to Main Menu!");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("you didnt make a valid entry. Press Enter to return to Main Menu");
                            Console.ReadLine();
                        }
                    }
                    else if (keyTravel == "3")
                    {
                        Console.WriteLine("Are you sure you want to travel to TRAPPIST-1?");
                        Console.WriteLine("Yes/No");
                        string travelConf = Console.ReadLine();

                        if ((travelConf == "Yes") || (travelConf == "yes")) // Set up travel to TRAPPIST-1
                        {

                        }
                        else if ((travelConf == "no") || (travelConf == "No"))
                        {
                            Console.WriteLine("Press Enter to return to Main Menu!");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("you didnt make a valid entry. Press Enter to return to Main Menu");
                            Console.ReadLine();
                        }

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please make a valid entry");
                    }
                }
                else if (keyMain == "4")
                {
                    Console.WriteLine("GoodBye!");
                    System.Threading.Thread.Sleep(1000);
                    break;
                }
                else
                {
                    Console.WriteLine("Please Make a valid entry. Press Enter to continue");
                    Console.ReadLine();
                }
            } while ((onEarth == true) || (keyMain == "4"));         
        }
        public static void AlphaCentauri(int credits, double time, double currentLocation)
        {
            x1 = 0;
            y1 = 4.367;
            bool onAlphaCentauri = true;

            // On planet loop
            do
            {
                // main menu
                Console.Clear();
                Console.WriteLine("Welcome to Alpha Centauri!!");
                Console.WriteLine();
                Console.WriteLine("What would you like to do?: ");
                Console.WriteLine("1. Buy: ");
                Console.WriteLine("2. Sell: ");
                Console.WriteLine("3. Travel: ");
                Console.WriteLine("4. Exit");
                string keyMain = Console.ReadLine();

                // picked options from main menu
                if (keyMain == "1")
                {
                    Console.Clear();
                    Console.WriteLine("What trade items would you like to buy?");
                    Console.WriteLine("1. Food, price 2,500");
                    Console.WriteLine("2. Research, price 3,500");
                    Console.WriteLine("3. Animals, price 4,500");
                    Console.WriteLine("4. Water, sale price 4,000");
                    Console.WriteLine("5. Fuel, price 8,000");
                    Console.WriteLine("6. Check Current inventory");
                    string keyBuy = Console.ReadLine();

                    // Buy menu
                    // TODO - add credit change and inventory change with buy menus
                    switch (keyBuy)
                    {
                        case "1":
                        case "food":
                        case "Food":
                            Console.WriteLine("You bought food!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "2":
                        case "research":
                        case "Research":
                            Console.WriteLine("You bought research!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "3":
                        case "animals":
                        case "Animals":
                            Console.WriteLine("You bought animals!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "4":
                        case "water":
                        case "Water":
                            Console.WriteLine("You bought water!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "5":
                        case "fuel":
                        case "Fuel":
                            Console.WriteLine("You bought fuel!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "6":
                        case "inventory":
                            Console.Clear();
                            Console.WriteLine("Current inventory: "); // TODO - add inventory checks
                            Console.WriteLine("Press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        default:
                            break;

                    }
                }
                else if (keyMain == "2")
                {
                    Console.Clear();
                    Console.WriteLine("What trade items would you like to Sell?");
                    Console.WriteLine("1. Food, price 2,500");
                    Console.WriteLine("2. Research, price 2,500");
                    Console.WriteLine("3. Animals, price 4,500");
                    Console.WriteLine("4. Water, sale price 4,000");
                    Console.WriteLine("5. Fuel, price 7,500");
                    Console.WriteLine("6. Check Current inventory");
                    string keySell = Console.ReadLine();

                    // Sell menu
                    // TODO - add credit change and inventory change with sell menus
                    switch (keySell)
                    {
                        case "1":
                        case "food":
                        case "Food":
                            Console.WriteLine("You Sold food!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "2":
                        case "research":
                        case "Research":
                            Console.WriteLine("You Sold research!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "3":
                        case "animals":
                        case "Animals":
                            Console.WriteLine("You Sold animals!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "4":
                        case "water":
                        case "Water":
                            Console.WriteLine("You Sold water!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "5":
                        case "fuel":
                        case "Fuel":
                            Console.WriteLine("You Sold fuel!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "6":
                        case "inventory":
                            Console.Clear();
                            Console.WriteLine("Current inventory: "); // TODO - add inventory checks
                            Console.WriteLine("Press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        default:
                            break;

                    }
                }
                else if (keyMain == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Where would you like to go?");
                    Console.WriteLine("1. EARTH, Distance: --");  // TODO - add distance to earth from current location
                    Console.WriteLine("2. Alpha Centauri, Distance: You are here"); //TODO - add distance to alpha centauri using current location + distance to location
                    Console.WriteLine("3. TRAPPIST-1, Distance: --"); //TODO - add distance to TRAPPIST-1 using current location + distance to location
                    Console.WriteLine("4. Main Menu");
                    string keyTravel = Console.ReadLine();

                    if (keyTravel == "1")
                    {
                        Console.WriteLine("Are you sure you want to travel to Earth?");
                        Console.WriteLine("Yes/No");
                        string travelConf = Console.ReadLine();

                        if ((travelConf == "Yes") || (travelConf == "yes")) // Set up travel to Earth
                        {

                        }
                        else if ((travelConf == "no") || (travelConf == "No"))
                        {
                            Console.WriteLine("Press Enter to return to Main Menu!");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("you didnt make a valid entry. Press Enter to return to Main Menu");
                            Console.ReadLine();
                        }
                    }
                    else if (keyTravel == "2")
                    {
                        Console.WriteLine("You are already here!");
                        Console.WriteLine("Press Enter to return to Main Menu");
                        Console.ReadLine();
                    }
                    else if (keyTravel == "3")
                    {
                        Console.WriteLine("Are you sure you want to travel to TRAPPIST-1?");
                        Console.WriteLine("Yes/No");
                        string travelConf = Console.ReadLine();

                        if ((travelConf == "Yes") || (travelConf == "yes")) // Set up travel to TRAPPIST-1
                        {

                        }
                        else if ((travelConf == "no") || (travelConf == "No"))
                        {
                            Console.WriteLine("Press Enter to return to Main Menu!");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("you didnt make a valid entry. Press Enter to return to Main Menu");
                            Console.ReadLine();
                        }

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please make a valid entry");
                    }
                }
            } while (onAlphaCentauri == true);
        }
        public static void Trappist(int credits, double time, double currentLocation)
        {
            x1 = 1.0;
            y1 = 3.50;
            bool onTrappist = true;

            // On planet loop
            do
            {
                // main menu
                Console.Clear();
                Console.WriteLine("Welcome to TRAPPIST-1!!");
                Console.WriteLine();
                Console.WriteLine("What would you like to do?: ");
                Console.WriteLine("1. Buy: ");
                Console.WriteLine("2. Sell: ");
                Console.WriteLine("3. Travel: ");
                Console.WriteLine("4. Exit");
                string keyMain = Console.ReadLine();

                // picked options from main menu
                if (keyMain == "1")
                {
                    Console.Clear();
                    Console.WriteLine("What trade items would you like to buy?");
                    Console.WriteLine("1. Food, price 2,500");
                    Console.WriteLine("2. Research, price 3,500");
                    Console.WriteLine("3. Animals, price 6,500");
                    Console.WriteLine("4. Water, sale price 8,000");
                    Console.WriteLine("5. Fuel, price 2,000");
                    Console.WriteLine("6. Check Current inventory");
                    string keyBuy = Console.ReadLine();

                    // Buy menu
                    // TODO - add credit change and inventory change with buy menus
                    switch (keyBuy)
                    {
                        case "1":
                        case "food":
                        case "Food":
                            Console.WriteLine("You bought food!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "2":
                        case "research":
                        case "Research":
                            Console.WriteLine("You bought research!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "3":
                        case "animals":
                        case "Animals":
                            Console.WriteLine("You bought animals!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "4":
                        case "water":
                        case "Water":
                            Console.WriteLine("You bought water!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "5":
                        case "fuel":
                        case "Fuel":
                            Console.WriteLine("You bought fuel!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "6":
                        case "inventory":
                            Console.Clear();
                            Console.WriteLine("Current inventory: "); // TODO - add inventory checks
                            Console.WriteLine("Press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        default:
                            break;

                    }
                }
                else if (keyMain == "2")
                {
                    Console.Clear();
                    Console.WriteLine("What trade items would you like to Sell?");
                    Console.WriteLine("1. Food, price 1,500");
                    Console.WriteLine("2. Research, price 2,500");
                    Console.WriteLine("3. Animals, price 5,500");
                    Console.WriteLine("4. Water, sale price 7,000");
                    Console.WriteLine("5. Fuel, price 1,500");
                    Console.WriteLine("6. Check Current inventory");
                    string keySell = Console.ReadLine();

                    // Sell menu
                    // TODO - add credit change and inventory change with sell menus
                    switch (keySell)
                    {
                        case "1":
                        case "food":
                        case "Food":
                            Console.WriteLine("You Sold food!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "2":
                        case "research":
                        case "Research":
                            Console.WriteLine("You Sold research!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "3":
                        case "animals":
                        case "Animals":
                            Console.WriteLine("You Sold animals!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "4":
                        case "water":
                        case "Water":
                            Console.WriteLine("You Sold water!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "5":
                        case "fuel":
                        case "Fuel":
                            Console.WriteLine("You Sold fuel!");
                            Console.WriteLine("press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        case "6":
                        case "inventory":
                            Console.Clear();
                            Console.WriteLine("Current inventory: "); // TODO - add inventory checks
                            Console.WriteLine("Press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        default:
                            break;

                    }
                }
                else if (keyMain == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Where would you like to go?");
                    Console.WriteLine("1. EARTH, Distance: --");  // TODO - add distance to earth from current location
                    Console.WriteLine("2. Alpha Centauri, Distance: --"); //TODO - add distance to alpha centauri using current location + distance to location
                    Console.WriteLine("3. TRAPPIST-1, Distance: You are already here!"); //TODO - add distance to TRAPPIST-1 using current location + distance to location
                    Console.WriteLine("4. Main Menu");
                    string keyTravel = Console.ReadLine();

                    if (keyTravel == "1")
                    {
                        Console.WriteLine("Are you sure you want to travel to Earth?");
                        Console.WriteLine("Yes/No");
                        string travelConf = Console.ReadLine();

                        if ((travelConf == "Yes") || (travelConf == "yes")) // Set up travel to earth
                        {

                        }
                        else if ((travelConf == "no") || (travelConf == "No"))
                        {
                            Console.WriteLine("Press Enter to return to Main Menu!");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("you didnt make a valid entry. Press Enter to return to Main Menu");
                            Console.ReadLine();
                        }
                    }
                    else if (keyTravel == "2")
                    {
                        Console.WriteLine("Are you sure you want to travel to Alpha Centauri?");
                        Console.WriteLine("Yes/No");
                        string travelConf = Console.ReadLine();

                        if ((travelConf == "Yes") || (travelConf == "yes")) // Set up travel to alpha centauri
                        {

                        }
                        else if ((travelConf == "no") || (travelConf == "No"))
                        {
                            Console.WriteLine("Press Enter to return to Main Menu!");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("you didnt make a valid entry. Press Enter to return to Main Menu");
                            Console.ReadLine();
                        }
                    }
                    else if (keyTravel == "3")
                    {
                        Console.WriteLine("You are already here!");
                        Console.WriteLine("Press Enter to return to Main Menu");
                        Console.ReadLine();

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please make a valid entry");
                    }
                }
            } while (onTrappist == true);
        }
    }
}
