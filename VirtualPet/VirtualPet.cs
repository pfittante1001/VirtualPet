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

        //properties
        public int PetFeed { get; set; }
        public int PetDrink { get; set; }
        public int PetSleep { get; set; }
        public int PetActivity { get; set; }

        //constructors

        public VirtualPet()
        {
            //default constructor
        }

        public VirtualPet(int feed, int drink, int sleep, int activity)
        {
            this.petFeed = feed;
            this.petDrink = drink;
            this.petSleep = sleep;
            this.petActivity = activity;
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
    }
}
