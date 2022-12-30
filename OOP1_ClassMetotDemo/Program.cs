using System;

namespace OOP1_ClassMetotDemo
{
    public class Program
    {
        //Customer Class => propertyleri ,Constructor oluşturuldu
        //CustomerManager => Customer CRUD işlemleri (metotlar) oluşturuldu
        //Veritabanından gelmediği için simüle edildiği için müşteriler oluşturulup dizide tutuldu

        static void Main(string[] args)
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
                Console.WriteLine(cst.NameSurname);
            }


            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer3);
            customerManager.Add(new Customer()
            {
                Id = 4,
                Username = "Zeyno",
                Password = "101010",
                NameSurname = "Zeynep Eski",
                Gender = true,
            });

            customerManager.Delete(customer1);
            customerManager.Update(customer2);
            customerManager.Display();

        }
    }
}
