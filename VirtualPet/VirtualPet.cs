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
        protected int expiredTime;
        

        //properties
        public int PetFeed { get; set; }
        public int PetDrink { get; set; }
        public int PetSleep { get; set; }
        public int PetActivity { get; set; }
        public string PetType { get; set; }
        public string PetName { get; set; }
        public int ExpiredTime { get; set; }

        //constructors

        public VirtualPet()
        {
            //default constructor
        }

        public VirtualPet(string petName, string petType, int feed, int drink, int sleep, int activity, int expiredTime)
        {
            this.petName = petName;
            this.petType = petType;
            this.petFeed = feed;
            this.petDrink = drink;
            this.petSleep = sleep;
            this.petActivity = activity;
            this.expiredTime = expiredTime;
           
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
            expiredTime = DateTime.Now.Minute;

            return expiredTime;
        }

        public virtual int GetWater()
        {
            expiredTime = DateTime.Now.Minute;

            return petDrink;
        }

        public virtual int GetSleep()
        {
            expiredTime = DateTime.Now.Minute;

            return petSleep;
        }

        public virtual int GetActivity()
        {
            expiredTime = DateTime.Now.Minute;

            return petActivity;
        }

        public virtual int GetExpiredTime()
        {

            return expiredTime;
        }

        public virtual void petstatus()
        {
            bool exit = false;
            while (exit == false)
            {

                Console.WriteLine();
                Console.WriteLine("\n\n***************************************************************\n\n");
                Console.WriteLine("              Care for your pet");
                Console.WriteLine("Choose an action from below to care for {0}:\n\n\n", petName);
                Console.WriteLine("\n\n***************************************************************\n\n");
                Console.WriteLine("Type feed to give {0} something to eat.", petName);
                Console.WriteLine("Type drink to give {0} something to drink.", petName);
                Console.WriteLine("Type sleep to put {0} to sleep.", petName);
                Console.WriteLine("Type walk to take {0} for a walk.", petName);
                Console.WriteLine("\n\n***************************************************************\n\n");
                string petCare = Console.ReadLine().ToUpper();
            
                switch (petCare)
                {
                    case "FEED":
                        GetFood();
                        exit = true;
                        break;
                    case "DRINK":
                        GetWater();
                        exit = true;
                        break;
                    case "SLEEP":
                        GetSleep();
                        exit = true;
                        break;
                    case "WALK":
                        GetActivity();
                        exit = true;
                        break;
                }
            } 

        }
    
    }
}
