using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //fields

        protected int petFeed;
        protected int petDrink;
        protected int petSleep;
        protected int petActivity;
        protected string petType;
        protected string petName;

        //properties
        public int PetFeed { get; set; }
        public int PetDrink { get; set; }
        public int PetSleep { get; set; }
        public int PetActivity { get; set; }
        public string PetType { get; set; }
        public string PetName { get; set; }

        //constructors

        public VirtualPet()
        {
            //default constructor
        }

        public VirtualPet(string petName, string petType, int feed, int drink, int sleep, int activity)
        {
            this.petName = petName;
            this.petType = petType;
            this.petFeed = feed;
            this.petDrink = drink;
            this.petSleep = sleep;
            this.petActivity = activity;
        }

        public virtual string GetPetName()
        {
            return petName;
        }

        public virtual string GetPetType()
        {
            return petType;
        }
        public virtual int GetFood()
        {
            return petFeed;
        }

        public virtual int GetWater()
        {
            return petDrink;
        }

        public virtual int GetSleep()
        {
            return petSleep;
        }

        public virtual int GetActivity()
        {
            return petActivity;
        }

        public virtual void petstatus()
        {
            Console.WriteLine("My name is {0} and I am your pet {1}.", petName, petType);
        }
    }
}
