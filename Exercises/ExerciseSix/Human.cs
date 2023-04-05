using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSix
{
   public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }

        public void GetPersonDetails ()
        {
            Console.WriteLine($"Your Full name is: {char.ToUpper(FirstName[0]) + FirstName.Substring(1)} {char.ToUpper(LastName[0]) + LastName.Substring(1)}, and you are {Age} years old");
        }
    }
}
