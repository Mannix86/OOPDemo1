using System;

namespace oopSkillsDemo1
{
    class Program
    {
        static void Main(string[] args)
        {   //declare variable
            double fuel;
            int decisionOne = 1;

            //create a new instance of the PetrolPump class, passing in arguments
            PetrolPump myPump = new PetrolPump(.75, 20000.00, 2.0, "Unleaded 98");
            Console.WriteLine("  _______________________________________________________________\n");
            Console.WriteLine("\t\t\tFUEL TO YOU");
            Console.WriteLine("\tPlease choose an option :");
            Console.WriteLine("\t1/ Fill fuel");
            Console.WriteLine("\t2/ Fill stock tank");
            Console.WriteLine("\t3/ Display stock level");
            Console.WriteLine("  _______________________________________________________________");
            bool decisionTwo = true;
            while (decisionTwo == true)            
            {
                try
                {
                    decisionOne = Convert.ToInt32(Console.ReadLine());
                    if (decisionOne == 1 || decisionOne == 2 || decisionOne == 3)
                    {
                        decisionTwo = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid choice");
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid choice");
                }
            }
            Console.Clear();
            //Allowing the user to fill a vehicle from the stock levels
            if (decisionOne == 1)
            {
                //Getting the user to enter the amount of fuel required
                Console.WriteLine("  _______________________________________________________________\n");
                Console.WriteLine("\t\t\tFUEL TO YOU");
                Console.WriteLine("\tPlease enter the quantity of fuel required in litres");
                Console.WriteLine("  _______________________________________________________________");

                bool decision = true;
                while (decision == true)
                {
                    try
                    {
                        Console.Write("Litres : ");
                        fuel = (Convert.ToDouble(Console.ReadLine()));
                        myPump.fillTankFromPump(fuel);
                        decision = false;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a numerical amount");

                    }
                }
            }
            //Allowing the user to adjust stock levels
            if (decisionOne == 2)
            {
                Console.Write("Please enter the quantity you wish to add to stock : ");
                myPump.addPetrol(Convert.ToInt32(Console.ReadLine()));
            }
            //Allowing the user to show stock levels
            if (decisionOne == 3)
            {
                Console.WriteLine("There are " + myPump.getAmount() + " Litres in the tank");
            }
            
            //adding 1000 litres as requested and displaying the amount as per task requirements
            myPump.addPetrol(1000);
            Console.WriteLine("There are " + myPump.getAmount() + " Litres in the tank");
        }
    }
}
