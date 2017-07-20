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
        protected bool isHungry;
        protected bool isThirsty;
        protected bool isSleepy;
        protected bool isBored;
        protected int adoptionTime;

        public string PetName { get; set; }
        public string PetType { get; set; }
        public int PetAge { get; set; }

        public PetInformation()
        {
            //default constructor
        }

        public PetInformation(string petName, string petType, int petAge, bool isHungry, bool isThirsty, bool isSleepy, bool isBored, int adoptionTime)
        {
            this.petName = petName;
            this.petType = petType;
            this.petAge = petAge;
            this.isHungry = isHungry;
            this.isThirsty = isThirsty;
            this.isSleepy = isSleepy;
            this.isBored = isBored;
            this.adoptionTime = adoptionTime;
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
        public bool IsHungry()
        {
            return isHungry;
        }
        public bool IsThirsty()
        {
            return isThirsty;
        }
        public bool IsSleepy()
        {
            return isSleepy;
        }
        public bool IsBored()
        {
            return isBored;
        }
        public int GetAdoptionTime()
        {
            return adoptionTime;
        }

        public void GetPetInformation()
        {
            Console.WriteLine();
            Console.WriteLine("\n\n***************************************************************\n\n");
            Console.WriteLine("              Your Pet Information");
            Console.WriteLine("Your pets name is {0} and is a beautiful loving {1}year old {2}.\n\n", petName, petAge, petType);
            Console.WriteLine("I was adopted on {0}\n\n", adoptionTime);
            Console.WriteLine("Here is your pets current status:\n\n\n");
            Console.WriteLine("\n\n***************************************************************\n\n");
            Console.WriteLine("{0} {1} hungry.", custaddress);
            Console.WriteLine("Customer Phone:        {0}", custPhone);
            Console.WriteLine("Customer Email:        {0}", custEmail);
            Console.WriteLine("\n\n***************************************************************\n\n");

        }
    }
}
