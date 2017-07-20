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
            int petFeed;
            int petDrink;
            int petSleep;
            int petActivity;
            int createPets = 0;
            int meetPets;
            int petAge = 0;
            string adoptionDate = DateTime.Now.ToString();
            int adoptionMinute = DateTime.Now.Minute;
            int expiredTime = DateTime.Now.Minute - adoptionMinute; 
            string petName = "";
            string petType = "";
            bool exitProgram = true;
            string isHungry = "No";
            string isThirsty = "No";
            string isSleepy = "No";
            string isBored = "No";
            bool meetAnotherPet = true;
            List<string> petNames = new List<string>(numPets);
            List<string> petTypes = new List<string>() { "Cat", "Dog", "Ferrett", "Parrot", "Goldfish", "Hamster", "Snake", "Ultimate Red Eyes Black Dragon", "Godizalla", "King Kong"};
            List<string> results = new List<string>();
            Dictionary<string, string> nameType = new Dictionary<string, string>();
            VirtualPet mainPet = new VirtualPet(petName, petType, 0, 0, 0, 0);
            PetInformation mainPet1 = new PetInformation(petName, petType, petAge,isHungry, isThirsty, isSleepy, isBored, adoptionDate);
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
                        Console.Write("\n\nFive pets are a recipe for disaster");
                        break;
                    default:
                        break;
                }

                Console.Write("\n\n\nWe need to choose names for your new {0} pets\n", numPets);

                for (int i = 0; i < numPets; i++)
                {
                    Console.Write("\n\nPlease enter pet name number {0}: ", i+1);
                    string tempName = Console.ReadLine().ToUpper();
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
                    Console.WriteLine("Congradulation you have a {0} named {1}!\n\n", pair.Key, pair.Value);
                }

                Console.WriteLine("Alright the time has come to meet your new virtual pets.\n\n");
                Console.WriteLine("Which pet would you like to meet first?\n\n");

                
                int ctr = 0;
                do
                {
                    Console.WriteLine("Please type the pets name or exit to quit.\n\n");

                    int k = 1;
                    foreach (KeyValuePair<string, string> pair in nameType)
                    {

                        Console.WriteLine("{0}. {1} {2}\n\n", k++, pair.Key, pair.Value);
                    }

                    string meetPetStr = Console.ReadLine().ToUpper();

                    Console.WriteLine(meetPetStr);


                    if (meetPetStr == "EXIT")
                    {
                        ExitMethod(meetPetStr);
                    }
                    foreach (KeyValuePair<string, string> count in nameType)
                    {
                        if (count.Value == meetPetStr)
                        {
                            petType = count.Key;
                            petName = count.Value;

                            switch (petType)
                            {
                                case "Cat":
                                    VirtualPet VTPCat = new VirtualPet(petName, petType, 0, 0, 0, 0);
                                    petAge = GetAge();
                                    isHungry = IsHungry(expiredTime);
                                    Console.WriteLine(isHungry);
                                    PetInformation PTCat = new PetInformation(petName, petType, petAge, isHungry, isThirsty, isSleepy, isBored, adoptionDate);
                                    PTCat.GetPetInformation();
                                    Console.WriteLine("cat");
                                    break;
                                case "Dog":
                                    VirtualPet VTPDog = new VirtualPet(petName, petType, 0, 0, 0, 0);
                                    petAge = GetAge();
                                    isHungry = IsHungry(expiredTime);
                                    Console.WriteLine(isHungry);
                                    PetInformation PTDog = new PetInformation(petName, petType, petAge, isHungry, isThirsty, isSleepy, isBored, adoptionDate);
                                    PTDog.GetPetInformation();
                                    Console.WriteLine("dog");
                                    break;
                                case "Ferrett":
                                    VirtualPet VTPFerrett = new VirtualPet(petName, petType, 0, 0, 0, 0);
                                    petAge = GetAge();
                                    isHungry = IsHungry(expiredTime);
                                    Console.WriteLine(isHungry);
                                    PetInformation PTFerrett = new PetInformation(petName, petType, petAge, isHungry, isThirsty, isSleepy, isBored, adoptionDate);
                                    PTFerrett.GetPetInformation();
                                    Console.WriteLine("Ferrett");
                                    break;
                                case "Parrot":
                                    VirtualPet VTPParrot = new VirtualPet(petName, petType, 0, 0, 0, 0);
                                    petAge = GetAge();
                                    isHungry = IsHungry(expiredTime);
                                    Console.WriteLine(isHungry);
                                    PetInformation PTParrot = new PetInformation(petName, petType, petAge, isHungry, isThirsty, isSleepy, isBored, adoptionDate);                                   
                                    PTParrot.GetPetInformation();
                                    Console.WriteLine("parrot");
                                    break;
                                case "Goldfish":
                                    VirtualPet VTPGoldfish = new VirtualPet(petName, petType, 0, 0, 0, 0);
                                    petAge = GetAge();
                                    isHungry = IsHungry(expiredTime);
                                    Console.WriteLine(isHungry);
                                    PetInformation PTGoldfish = new PetInformation(petName, petType, petAge, isHungry, isThirsty, isSleepy, isBored, adoptionDate);
                                    PTGoldfish.GetPetInformation();
                                    Console.WriteLine("goldfish");
                                    break;
                                case "Hamster":
                                    VirtualPet VTPHamster = new VirtualPet(petName, petType, 0, 0, 0, 0);
                                    petAge = GetAge();
                                    isHungry = IsHungry(expiredTime);
                                    Console.WriteLine(isHungry);
                                    PetInformation PTHamster = new PetInformation(petName, petType, petAge, isHungry, isThirsty, isSleepy, isBored, adoptionDate);
                                    PTHamster.GetPetInformation();
                                    Console.WriteLine("ham");
                                    break;
                                case "Snake":
                                    VirtualPet VTPSnake = new VirtualPet(petName, petType, 0, 0, 0, 0);
                                    petAge = GetAge();
                                    isHungry = IsHungry(expiredTime);
                                    Console.WriteLine(isHungry);
                                    PetInformation PTSnake = new PetInformation(petName, petType, petAge, isHungry, isThirsty, isSleepy, isBored, adoptionDate);
                                    PTSnake.GetPetInformation();
                                    Console.WriteLine("snake");
                                    break;
                                case "Ultimate Red Eyes Black Dragon":
                                    VirtualPet VTPUREBD = new VirtualPet(petName, petType, 0, 0, 0, 0);
                                    petAge = GetAge();
                                    isHungry = IsHungry(expiredTime);
                                    Console.WriteLine(isHungry);
                                    PetInformation PTUREBD = new PetInformation(petName, petType, petAge, isHungry, isThirsty, isSleepy, isBored, adoptionDate);
                                    PTUREBD.GetPetInformation();
                                    Console.WriteLine("dragon");
                                    break;
                                case "Godizalla":
                                    VirtualPet VTPGodizalla = new VirtualPet(petName, petType, 0, 0, 0, 0);
                                    petAge = GetAge();
                                    isHungry = IsHungry(expiredTime);
                                    Console.WriteLine(isHungry);
                                    PetInformation PTGodzilla = new PetInformation(petName, petType, petAge, isHungry, isThirsty, isSleepy, isBored, adoptionDate);
                                    PTGodzilla.GetPetInformation();
                                    Console.WriteLine("godizalla");
                                    break;
                                case "King Kong":
                                    VirtualPet VTPKingKong = new VirtualPet(petName, petType, 0, 0, 0, 0);
                                    petAge = GetAge();
                                    isHungry = IsHungry(expiredTime);
                                    Console.WriteLine(isHungry);
                                    PetInformation PTKingKong = new PetInformation(petName, petType, petAge, isHungry, isThirsty, isSleepy, isBored, adoptionDate);
                                    PTKingKong.GetPetInformation();
                                    Console.WriteLine("KK");
                                    break;
                                default:
                                    Console.WriteLine("The pet doesnt exist");
                                    break;

                            }

                        }
                        
                    }
                    ctr++;
                    Console.WriteLine(ctr);

                    if (ctr == numPets)
                    {
                        meetAnotherPet = false;
                    }else
                    {
                        Console.WriteLine("Would you like to meet another virtual pet?");
                        Console.WriteLine("Type exit to quit or hit any key to continue");
                        string meetAnotherPetStr = Console.ReadLine().ToUpper();
                        if (meetAnotherPetStr == "EXIT")
                        {
                        meetAnotherPet = false;
                        }
                        
                    }
                    

                    
                } while (meetAnotherPet == true && ctr < numPets);

                
                exitProgram = true;

            }
        }

        public static string IsHungry(int expiredTime )
        {
            string isHungry;
            if(expiredTime < 1 )
            {
                isHungry = "is not";
                Console.WriteLine(isHungry);
            }else
            {
                isHungry = "is";
                Console.WriteLine(isHungry);
            }
            Console.WriteLine(isHungry);

            return isHungry;
        }
        public static int GetAge()
        {
            int min = 1;
            int max = 5;
            int petAge = 0;
            Random petAgeRnd = new Random();
            petAge = petAgeRnd.Next(min, max);
            return petAge;
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
