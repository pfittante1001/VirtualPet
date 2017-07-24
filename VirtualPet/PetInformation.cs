using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class PetInformation
    {
        protected string petName;
        protected string petType;
        protected int petAge;
        protected string isHungry;
        protected string isThirsty;
        protected string isSleepy;
        protected string isBored;
        protected string adoptionDate;
        protected int expiredTime;
        protected int[] nameType;


        public string PetName { get; set; }
        public string PetType { get; set; }
        public int PetAge { get; set; }
        public int ExpiredTime { get; set; }


        public PetInformation()
        {
            //default constructor
        }

        public PetInformation(string petName, string petType, int petAge, string isHungry, string isThirsty, string isSleepy, string isBored, string adoptionDate, int expiredTime, int[] nameType)
        {
            this.petName = petName;
            this.petType = petType;
            this.petAge = petAge;
            this.isHungry = isHungry;
            this.isThirsty = isThirsty;
            this.isSleepy = isSleepy;
            this.isBored = isBored;
            this.adoptionDate = adoptionDate;
            this.expiredTime = expiredTime;
            this.nameType = nameType;

        }

        public string GetPetName()
        {
            return petName;
        }
        public string GetPetType()
        {
            return petType;
        }
        public int GetPetAge()
        {
            return petAge;
        }
        public string IsHungry()
        {
            isHungry = PetIsHungry(expiredTime);
            return isHungry;
        }
        public string IsThirsty()
        {
            isThirsty = PetIsThirsty(expiredTime);
            return isThirsty;
        }
        public string IsSleepy()
        {
            isSleepy = PetIsSleepy(expiredTime);
            return isSleepy;
        }
        public string IsBored()
        {
            isBored = PetIsBored(expiredTime);
            return isBored;
        }
        public string GetAdoptionDate()
        {
            return adoptionDate;
        }

        public int GetExpiredTime()
        {
            return expiredTime;
        }

        public static string PetIsBored(int expiredTime)
        {
            string isBored;
            Console.WriteLine("test {0} ", expiredTime);
            if (expiredTime < 5)
            {
                isBored = "is not";
            }
            else
            {
                isBored = "is";
                Console.WriteLine(isBored);
            }
            Console.WriteLine(isBored);

            return isBored;
        }
        public static string PetIsSleepy(int expiredTime)
        {
            string isSleepy;
            if (expiredTime < 8)
            {
                isSleepy = "is not";
                Console.WriteLine(isSleepy);
            }
            else
            {
                isSleepy = "is";
                Console.WriteLine(isSleepy);
            }
            Console.WriteLine(isSleepy);

            return isSleepy;
        }
        public static string PetIsThirsty(int expiredTime)
        {
            string isThirsty;
            if (expiredTime < 2)
            {
                isThirsty = "is not";
                Console.WriteLine(isThirsty);
            }
            else
            {
                isThirsty = "is";
                Console.WriteLine(isThirsty);
            }
            Console.WriteLine(isThirsty);

            return isThirsty;
        }
        public static string PetIsHungry(int expiredTime)
        {
            string isHungry;
            if (expiredTime < 6)
            {
                isHungry = "is not";
                Console.WriteLine(isHungry);
            }
            else
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


        public void GetPetInformation()
        {
            ;
            ;
            ;
            GetPetAge();
            
            IsThirsty();
            
            Console.WriteLine();
            Console.WriteLine("\n\n***************************************************************\n\n");
            Console.WriteLine("              Your Pet Information");
            Console.WriteLine("Your pets name is {0} and {0} is a beautiful loving {1} year old {2}.\n\n", petName, petAge, petType);
            Console.WriteLine("I was adopted on {0}\n\n", adoptionDate);
            Console.WriteLine("Here is your pets current status:\n\n\n");
            Console.WriteLine("\n\n***************************************************************\n\n");
            Console.WriteLine("{0} {1} hungry.", petName, isHungry);
            Console.WriteLine("{0} {1} thirsty.", petName, isThirsty);
            Console.WriteLine("{0} {1} sleepy.", petName, isSleepy);
            Console.WriteLine("{0} {1} hungry.", petName, isBored);
            Console.WriteLine("\n\n***************************************************************\n\n");

        }

        public void GetCareForPet()
        {
            bool careForAnotherPet = true;
            int ctr1 = 0;

            Console.WriteLine("It is now time to take care of your pets.\n\n");

            do
            {
                Console.WriteLine("Please type the pets name you would like to take care of or exit to quit.\n\n");

                int k = 1;
                foreach (KeyValuePair<string, string> pair in nameType)
                {

                    Console.WriteLine("{0}. {1} {2}\n\n", k++, pair.Key, pair.Value);
                }

                string careForPetStr = Console.ReadLine().ToUpper();

                Console.WriteLine(careForPetStr);

                foreach (KeyValuePair<string, string> count in nameType)
                {
                    if (count.Value == careForPetStr)
                    {
                        petType = count.Key;
                        petName = count.Value;

                        switch (petType)
                        {
                            case "Cat":

                                IsBored();
                                IsHungry();
                                IsSleepy();
                                IsBored();
                                GetPetInformation();
                                break;
                            case "Dog":
                                IsBored();
                                IsHungry();
                                IsSleepy();
                                IsBored();
                                GetPetInformation();
                                break;
                            case "Ferrett":
                                IsBored();
                                IsHungry();
                                IsSleepy();
                                IsBored();
                                GetPetInformation();
                                break;
                            case "Parrot":
                                IsBored();
                                IsHungry();
                                IsSleepy();
                                IsBored();
                                GetPetInformation();
                                break;
                            case "Goldfish":
                                IsBored();
                                IsHungry();
                                IsSleepy();
                                IsBored();
                                GetPetInformation();
                                break;
                            case "Hamster":
                                IsBored();
                                IsHungry();
                                IsSleepy();
                                IsBored();
                                GetPetInformation();
                                break;
                            case "Snake":
                                IsBored();
                                IsHungry();
                                IsSleepy();
                                IsBored();
                                GetPetInformation();
                                break;
                            case "Ultimate Red Eyes Black Dragon":
                                IsBored();
                                IsHungry();
                                IsSleepy();
                                IsBored();
                                GetPetInformation();
                                break;
                            case "Godizalla":
                                IsBored();
                                IsHungry();
                                IsSleepy();
                                IsBored();
                                GetPetInformation();
                                break;
                            case "King Kong":
                                IsBored();
                                IsHungry();
                                IsSleepy();
                                IsBored();
                                GetPetInformation();
                                break;
                            default:
                                Console.WriteLine("The pet doesnt exist");
                                break;

                        }

                    }

                }
                ctr1++;
               if (ctr1 == numPets)
                {
                    careForAnotherPet = false;
                }
                else
                {
                    Console.WriteLine("Would you like to meet another virtual pet?");
                    Console.WriteLine("Type exit to quit or hit any key to continue");
                    string careForAnotherPetStr = Console.ReadLine().ToUpper();
                    if (careForAnotherPetStr == "EXIT")
                    {
                        careForAnotherPet = false;
                    }

                }
            } while (careForAnotherPet == true && ctr1 < numPets);
        }

        
    }
}
