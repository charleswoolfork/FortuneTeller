using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWFortuneTellerapp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //declaration of ints and strings are done here for user input solicitation:

            string firstName;
            string lastName;
            int age;
            int birthMonth;
            string favoriteColor;
            int numberOfSiblings;
            string input;
            Console.WriteLine("Hello! What is your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your birth month");
            birthMonth = int.Parse(Console.ReadLine());
            //Help Menu and user input for fav color choice using ROYGBIV is done here:

            Console.WriteLine("What is your favorite color?");

            Console.WriteLine("Using ROYGBIV enter your favorite color such as Red Enter help for a list of ROYGBIV colors");
            favoriteColor = Console.ReadLine().ToLower();

            if (favoriteColor.Equals("help"))
            {

                Console.WriteLine("Your choices are: Red - Orange - Yellow - Green - Blue - Indigo - Violet.");
                Console.WriteLine("Please enter your color!");
                favoriteColor = Console.ReadLine().ToLower();
            }
           

            //if (favoriteColor == "ROYGBIV") ;
            //favoriteColor = Console.ReadLine().ToLower();

            Console.WriteLine("How many siblings do you have? if none enter 0?");
            numberOfSiblings = int.Parse(Console.ReadLine());


            //Use of modulous to determine bool return value and compute range of age to retire is done here:
            string ageToRetire;
            if (age % 2 == 0)
            {
                ageToRetire = "10 years";
            }
            else
            {
                ageToRetire = "20 years";
            }

            //Data to calculate sibling variable value and subsequent vacation home are done here:
            // if the user enters 0 for number of siblings then vacation home will be in (location)
            //or if sibling is 1 vacation home will be in (location)
            //or if sibling number is 2 vacation home will be in (location)
            //or if sibling number is 3 vacation home will be in(location)

            string vacationHome = "numberOfSiblings";
            if (numberOfSiblings == 0)

            {
                vacationHome = "Tupelo MS";
            }
            else if (numberOfSiblings == 1)
            {
                vacationHome = "Rio Brazil";
            }
            else if (numberOfSiblings == 2)
            {
                vacationHome = "London England";
            }
            else if (numberOfSiblings == 3)
            {
                vacationHome = "Bridgetown Barbados";
            }
            else if (numberOfSiblings > 3)
            {
                vacationHome = "Bruh get an apartment house!";
            }

            // The mode of transport using if else if statements are done here:

            string ROYGBIV;
            if (favoriteColor == "red")
            {
                ROYGBIV = "A foot operated scooter!";
            }
            else if (favoriteColor == "orange")
            {
                ROYGBIV = "Rollerblades!";
            }
            else if (favoriteColor == "yellow")
            {
                ROYGBIV = " a Moped!";
            }
            else if (favoriteColor == "green")
            {
                ROYGBIV = "horse and buggy!";
            }
            else if (favoriteColor == "blue")
            {
                ROYGBIV = "Bently Wraith!";
            }
            else if (favoriteColor == "indigo")
            {
                ROYGBIV = "Bugatti Veyron!";
            }
            else if (favoriteColor == "violet")
            {
                ROYGBIV = "G6 private jet!";
            }
            else
            {
                ROYGBIV = "You must Uber!";
            }
            // Money math via the user birth month is done in this section:
            // if the user has a birth month from 1-4, the amount in the bank is X;
            // if user has a birth month from 5-8 the amount in the bank is X;
            //if user has a birth month from 9-12 the amount in the bank is X;
            //if user enters amount less than 1 or greater than 12 the amount in the bank is 0.00;

            string moneyInTheBank;
            if (birthMonth <= 4)
            {
                moneyInTheBank = "$10,000,000";
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                moneyInTheBank = "$300,000,000";
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                moneyInTheBank = "$700,000,000";
            }
            else
            {
                moneyInTheBank = "$0.00";
            }

            //Concatenation and end of fortune results diplay here:
            Console.WriteLine("Congratulations" + " " + firstName + " " + lastName + " " + "You will retire in" + " " + ageToRetire + "." + "With" + " " + moneyInTheBank + " " +  "in the bank." + " " + "With a beautiful new home located in" + " " + vacationHome + "Your mode of transportation will be" + " " + ROYGBIV);
           

        }

    }
}

