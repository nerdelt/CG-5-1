using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();



            Console.Write("Hello, ");
            FullName(firstName, lastName);

            Console.ReadLine();

         
        }

        private static void FullName(string firstName, string lastName)
        {
            //I don't know if the message I chose created a new value, 
            //so I did this to show that I can create a new value for the method as well.
            string name = firstName + " " + lastName;
            Console.Writeline(name);

           //Console.WriteLine(String.Format("{0} {1}!", firstName, lastName));
           
            
        }

       
           }
        }
      
    

