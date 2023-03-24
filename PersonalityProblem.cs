using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentCSharp
{
    internal class PersonalityProblem
    {
        

        public enum ZodiacSign
        {
            Capricorn,Aquarius,Pisces,Aries,Taurus,Gemini,Cancer,Leo,Virgo,Libra,Scorpio,Sagittarius
        }
        
        Dictionary<string, int> month = new Dictionary<string,int>();

        public static void Main(string[] args)
        {
            FindPersonality();
            string birth_mon;
            int birth_date;
        }

        public static void FindPersonality()
        {
            string question1 = "1. Who are you?\na) Introvet\nb) Extrovet\nc)Adoptable";
            string question2 = "2. How do you spend your free time?\na) Alone \nb) With Someone\nc)Dependence";
            string question3 = "3. What you do to relaxed your self?\na) For a Walk\nb) Trip\nc)Based On Time";

            Console.WriteLine("Welcome!! To Find your Personality");
            Console.WriteLine("Answer the MCQ based question to identity your self.");

            string userChoice1, userChoice2, userChoice3;

            userChoice1 = CallQuestion(question1);
            if (userChoice1.Equals(""))
            {
                Console.WriteLine("No option choosen!!");
                userChoice1 = CallQuestion(question1);
            }
            userChoice2 = CallQuestion(question2);
            if (userChoice2.Equals(""))
            {
                Console.WriteLine("No option choosen!!");
                userChoice2 = CallQuestion(question2);
            }
            userChoice3 = CallQuestion(question3);
            if (userChoice3.Equals(""))
            {
                Console.WriteLine("No option choosen!!");
                userChoice3 = CallQuestion(question3);
            }

            if(userChoice1.Equals("a") &&  userChoice2.Equals("a") && userChoice3.Equals("a"))
                Console.WriteLine("Your Introvet person who likes to alone");
            else if(userChoice1.Equals("b") &&  userChoice2.Equals("b") && userChoice3 == "b")
                Console.WriteLine("Your Extrovet person who likes to explore");
            else
                Console.WriteLine("Your adoptive person");
        }

        public static string CallQuestion(string question) 
        {
            string userInput;
            Console.WriteLine(question);
            Console.Write("Enter only the option letter : ");
            userInput = Console.ReadLine();
            return userInput;
        }


        public static void FindZodiac(string birth_mon, int birth_date)
        {
            Console.Write("Enter your Birth Month(First Three letters only) : ");
            birth_mon = Console.ReadLine();

            Console.Write("Enter your Birth Date: ");
            birth_date = Convert.ToInt32(Console.ReadLine());

        }

        public static void FindAge(string birth_mon, int birth_date)
        {
            Console.Write("Enter your birth year : ");
            int birth_year = Convert.ToInt32(Console.ReadLine());

            int birth_mon_int = ;

            DateTime dob = new DateTime(birth_year, 4, birth_date);
            TimeSpan age = DateTime.Now.Subtract(dob);
            int years = (int)(age.TotalDays / 365.25); 




        }

    }


}
