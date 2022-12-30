using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1_ClassMetotDemo
{
    public class CustomerManager
    {
        public void Display()
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                Username = "ysnesra",
                Password = "123123",
                NameSurname = "Esra Yaşın",
                Gender = true,
            };
            Customer customer2 = new Customer()
            {
                Id = 2,
                Username = "tfnismail",
                Password = "123456",
                NameSurname = "İsmail Mutlu",
                Gender = false,
            };
            Customer customer3 = new Customer()
            {
                Id = 3,
                Username = "Ayşektl",
                Password = "111222",
                NameSurname = "Ayşe Kutlu",
                Gender = true,
            };

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (Customer cst in customers)
            {
                new Customer(cst);    /*****Constructırı çağırırız******/
            }
            Console.WriteLine("Müşteriler listelendi");
        }

        public void Add(Customer cstm)
        {
            Console.WriteLine("Müşteri eklendi: " + cstm.NameSurname);
        }
        public void Update(Customer cstm)
        {
            Console.WriteLine(cstm.NameSurname + " Müşterisi güncellendi");
        }
        public void Delete(Customer cstm)
        {
            Console.WriteLine(cstm.NameSurname + " Müşterisi silindi");
        }
    }
}
