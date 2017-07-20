using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Status
    {
        public void GetPetInformation()
        {
            Console.WriteLine();
            Console.WriteLine("\n\n***************************************************************\n\n");
            Console.WriteLine("              Your Pet Information");
            Console.WriteLine("Your pets name is {0} and {0} is a beautiful loving {1} year old {2}.\n\n", petName, petAge, petType);
            Console.WriteLine("I was adopted on {0}\n\n", adoptionDate);
            Console.WriteLine("Here is your pets current status:\n\n\n");
            Console.WriteLine("\n\n***************************************************************\n\n");
            Console.WriteLine("{0} {1} hungry.", petName, isHungry);
            //Console.WriteLine("Customer Phone:        {0}", custPhone);
            //Console.WriteLine("Customer Email:        {0}", custEmail);
            Console.WriteLine("\n\n***************************************************************\n\n");

        }
    }
}
