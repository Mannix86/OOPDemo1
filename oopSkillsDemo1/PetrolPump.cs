using System;
using System.Collections.Generic;
using System.Text;

namespace oopSkillsDemo1
{
    class PetrolPump
    {   
        //declaring variables
        protected double litrePrice;
        protected double litreAmount;
        protected double minimumQuantity;
        protected string fuelType;

        //default constructor, setting the variable to zero
        /// <summary>
        /// Default constructor, resetting the variable to no value or zero
        /// </summary>
        public PetrolPump()
        {
            litrePrice = 0;
            litreAmount = 0;
            minimumQuantity = 0;
            fuelType = "";
        }

        //overloaded constructor, taking in arguments and using these to set the values in the set methods
        /// <summary>
        /// Overloaded constructor, passing in arguments with values
        /// </summary>
        /// <param name="myLitre"></param>
        /// <param name="myAmount"></param>
        /// <param name="minOrder"></param>
        /// <param name="whatFuel"></param>
        public PetrolPump(double myLitre, double myAmount, double minOrder, string whatFuel)
        {
            addPetrol(myAmount);
            this.fuelType = whatFuel;
            this.setMinQuantity(minOrder);
            this.setPrice(myLitre);
        }
        //method to set the litre price
        /// <summary>
        /// Sets the price per litre
        /// </summary>
        /// <param name="myPrice"></param>
        public void setPrice(double myPrice)
        {
            this.litrePrice = myPrice;
        }
        //method to get the litre price
        /// <summary>
        /// Retrieves the price per litre
        /// </summary>
        /// <returns></returns>
        public double getPrice()
        {
            return this.litrePrice;
        }
        //method to get the amount in stock
        /// <summary>
        /// Retrieves the amount of litres in stock
        /// </summary>
        /// <returns></returns>
        public double getAmount()
        {
            return this.litreAmount;
        }
        //method to set the minimum order quantity
        /// <summary>
        /// Sets the minimum amount of litres that can be ordered
        /// </summary>
        /// <param name="myMin"></param>
        public void setMinQuantity(double myMin)
        {
            this.minimumQuantity = myMin;
        }
        //method to get the minimum order quantity
        /// <summary>
        /// Retrieves the minimum order quantity
        /// </summary>
        /// <returns></returns>
        public double getMin()
        {
            return this.minimumQuantity;
        }
        //mthod to get the fuel type
        /// <summary>
        /// Retrieves the type of fuel
        /// </summary>
        /// <returns></returns>
        public string getType()
        {
            return this.fuelType;
        }
        //method to add litres into the current stock level
        /// <summary>
        /// Adds the quantity of litres inputted to the current stock
        /// </summary>
        /// <param name="petrolIn"></param>
        public void addPetrol(double petrolIn)
        {
            this.litreAmount = this.litreAmount + petrolIn;
           // Console.WriteLine("Litres currently in tank : " + getAmount());
        }
        //method to fill the customers tank from the pump
        /// <summary>
        /// Takes in the value of required fuel from the user
        /// </summary>
        /// <param name="fuelRequired"></param>
        /// <returns></returns>
        public double fillTankFromPump(double fuelRequired)
        {
            //telling the customer they must order over the minimum order quantity
            if (fuelRequired <  minimumQuantity)
            {
                Console.WriteLine("You must order " + minimumQuantity + " litres or more" );
            }
            //telling the customer that there is an issue when there is not adequate stock to fulfill order
            else if (fuelRequired > litreAmount)
            {
                Console.WriteLine("We can not process your order, please contact a member of staff");
                Console.ReadKey();
                Console.Clear();
            }
            //processing the order, displaying the cost to the customer and updating the stock level
            else
            {
                Console.WriteLine("The total cost : " + fuelRequired * getPrice());
                this.litreAmount = this.litreAmount - fuelRequired;
                Console.ReadKey();
                Console.Clear();
                return fuelRequired * getPrice();
               
            }

            return fuelRequired * getPrice();
        }

    }
}
