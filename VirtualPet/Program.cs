using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //global variables

            int numPets = 0;
            int tempParse;
            bool exitProgram = true;
            List<string> petNames = new List<string>(numPets);
            List<string> petTypes = new List<string>() { "Cat", "Dog", "Ferrett", "Parrot", "Goldfish", "Hamster", "Snake", "Ultimate Red Eyes Black Dragon", "Godizalla", "King Kong"};
            List<string> results = new List<string>();
            Dictionary<string, string> nameType = new Dictionary<string, string>();
            Console.WriteLine("Welcome to Virtual Pet! ");
            Console.WriteLine("\n\n\nWould you like to meet your virtual pet? ");
            Console.Write("\n\nPlease press the enter key to continue, or type exit to quit: ");
            string playGame = Console.ReadLine().ToUpper();

            if(playGame == "EXIT")
            {
                Console.WriteLine("Not everyone is meant to have a pet, so you made a good choice");
                Console.WriteLine("Thanks for visiting");
                System.Environment.Exit(0);

            }else
            {
                exitProgram = false;
            }

            while (exitProgram == false)
            {

                Console.WriteLine("\n\nNow that you have made a commitment to own a pet");
                Console.WriteLine("\n\nLets get started!");
                Console.Write("\n\nHow many pets would you like to own? You must choose between 1 - 5 pets. ");
                string numPetsStr = Console.ReadLine().ToUpper();
                while (int.TryParse(numPetsStr, out tempParse) == false)
                {
                    Console.Write("\n\nPlease enter a valid number or exit to quit: ");
                    numPetsStr = Console.ReadLine().ToUpper();

                    ExitMethod(numPetsStr);

                    if (int.TryParse(numPetsStr, out tempParse) == true)
                    {
                        numPets = tempParse;
                    }
                }
                numPets = int.Parse(numPetsStr);

                while (numPets < 1 || numPets > 5)
                {
                    Console.Write("\n\nPlease enter number between 1 - 5 or exit to quit: ");
                    numPetsStr = Console.ReadLine().ToUpper();

                    ExitMethod(numPetsStr);

                    if (int.TryParse(numPetsStr, out tempParse) == true)
                    {
                        numPets = tempParse;
                    }
                }
                numPets = int.Parse(numPetsStr);

                switch (numPets)
                {
                    case 1:
                        Console.Write("\n\nOne pet is a great number.");
                        break;
                    case 2:
                        Console.Write("\n\nTwo pets can be a challenge.");
                        break;
                    case 3:
                        Console.Write("\n\nCaring for three pets can be a daunting task.");
                        break;
                    case 4:
                        Console.Write("\n\nOwning four pets is a full time job");
                        break;
                    case 5:
                        Console.Write("\n\nFive pets are a recipie for disaster");
                        break;
                    default:
                        break;
                }

                Console.Write("\n\n\nWe need to choose names for your new {0} pets\n", numPets);

                for (int i = 0; i < numPets; i++)
                {
                    Console.Write("\n\nPlease enter pet name number {0}: ", i+1);
                    string tempName = Console.ReadLine();
                    petNames.Add(tempName);
                }

                Console.Write("\n\nNow that we know how many pets you chose and we have some names.");
                Console.Write("\n\nI will now pick {0} random types of animals for you.", numPets);

                Random petTypeRan = new Random();

                int myRandomIndex = 0;
                for (int i = 0; i < numPets; i++)
                {
                   
                    myRandomIndex = petTypeRan.Next(petTypes.Count);
                                   
                    while (results.Contains(petTypes[myRandomIndex]) == true)
                    {
                        myRandomIndex = petTypeRan.Next(petTypes.Count);
                    }
                    results.Add(petTypes[myRandomIndex]);
                    nameType.Add(key: results[i], value: petNames[i]);
                }

                foreach (KeyValuePair<string, string> pair in nameType)
                {
                    Console.WriteLine("Congradulation you have a {0} named {1}!", pair.Key, pair.Value);
                }

                //foreach (var key in nameType.Keys.ToList())
                //{
                //    nameType[key] = "";
                //}

                exitProgram = true;

            }
        }

        public static void ExitMethod(string exitPro)
        {
            if (exitPro == "EXIT")
            {
                Console.Clear();
                Console.WriteLine("Thank you for using The Third National Bank of Uganda Online Banking Portal");
                Console.WriteLine("kwaheri");
                System.Environment.Exit(1);
            }
        }
    }
}
