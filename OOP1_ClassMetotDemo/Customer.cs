using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1_ClassMetotDemo
{
    //Encapsulation

    public class Customer
    {
        public Customer()   //constructor
        {

        }
        public Customer(Customer c)   //constructor
        {
            Console.WriteLine(c.Id);
            Console.WriteLine(c.Username);
            Console.WriteLine(c.Password);
            Console.WriteLine(c.NameSurname);
            Console.WriteLine(c.Gender);
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string NameSurname { get; set; }
        public bool Gender { get; set; }

    }

}
