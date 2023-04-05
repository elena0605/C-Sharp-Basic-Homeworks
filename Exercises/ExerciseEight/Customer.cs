using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Five
{
    public class Customer
    {
        public Customer(string firstName, string lastName, int balance) {
             
            FirstName = firstName;

            LastName = lastName;

            Card = new Card(balance);
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Card Card { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - Card Number: {Card.CardNumber}   PIN: {Card.GetPin()}");
        }

    }
}
