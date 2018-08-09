using System;

namespace FullNames
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //ask user for first name
                Console.Write("Please enter your first name: ");
                string firstName = Console.ReadLine();

                //ask user for last name
                Console.Write("Please enter your last name: ");
                string lastName = Console.ReadLine();

                //prints result, using FullName method
                
                string name = FullName(firstName, lastName);
                Console.Write($"Hello,  {name}");
                Console.ReadLine();     
            }
        }

        // a string method which allows for two string inputs 
        private static string FullName(string firstName, string lastName)
        {
            // creates a new value that combines first and last name
            string name = firstName + " " + lastName + "!";

            //returns values 
            return name;

        }

               
            }

       
        }
    


    

