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
                Console.Write("Hello, ");
                FullName(firstName, lastName);
                Console.ReadLine();     
            }
        }

        // a string method which allows for two string inputs 
        private static string FullName(string firstName, string lastName)
        {
            // creates a new value that combines first and last name
            string name = firstName + " " + lastName + "!";
            Console.WriteLine(name);

            //returns values 
            return name;

        }

            /* Here is the alternative way I did it at first.
             * I thought this was more condensed, but it didn't create a new value,
             * and I couldn't make it a 'private static string', just 'private staic void'
             * because I couldn't figure out how to return what was in the Console.WriteLine. 
             * It worked, but I was nervous that I didn't correctly complete the 
             * assignment and I didn't want to loose any points (like in the dreaded raffle).
             * So if you could please advise why this way is wrong, or how to "return" 
             * something using this:
              

                Console.WriteLine(String.Format("{0} {1}!", firstName, lastName));

            */
                
               
            }

       
        }
    


    

