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
        //protected int adoptionHour;
        public string PetName { get; set; }
        public string PetType { get; set; }
        public int PetAge { get; set; }

        public PetInformation()
        {
            //default constructor
        }

        public PetInformation(string petName, string petType, int petAge, string isHungry, string isThirsty, string isSleepy, string isBored, string adoptionDate)
        {
            this.petName = petName;
            this.petType = petType;
            this.petAge = petAge;
            this.isHungry = isHungry;
            this.isThirsty = isThirsty;
            this.isSleepy = isSleepy;
            this.isBored = isBored;
            this.adoptionDate = adoptionDate;
            //this.adoptionHour = adoptionHour;
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
            return isHungry;
        }
        public string IsThirsty()
        {
            return isThirsty;
        }
        public string IsSleepy()
        {
            return isSleepy;
        }
        public string IsBored()
        {
            return isBored;
        }
        public string GetAdoptionDate()
        {
            return adoptionDate;
        }

        //public int GetAdoptionHour()
        //{
        //    return adoptionHour;
        //}

        public void GetPetInformation()
        {
            Console.WriteLine();
            Console.WriteLine("\n\n***************************************************************\n\n");
            Console.WriteLine("              Your Pet Information");
            Console.WriteLine("Your pets name is {0} and {0} is a beautiful loving {1} year old {2}.\n\n", petName, petAge, petType);
            Console.WriteLine("I was adopted on {0}\n\n", adoptionDate);
            Console.WriteLine("Here is your pets current status:\n\n\n");
            Console.WriteLine("\n\n***************************************************************\n\n");
            Console.WriteLine("{0} {1} hungry.",petName, isHungry);
            //Console.WriteLine("Customer Phone:        {0}", custPhone);
            //Console.WriteLine("Customer Email:        {0}", custEmail);
            Console.WriteLine("\n\n***************************************************************\n\n");

        }
    }
}
