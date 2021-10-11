using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            customer1.Id = 111;
            customer1.Name = "Ali";
            customer1.Lastname = "Yilmaz";
            customer1.Jobs = "Doktor";

            Customer customer2 = new Customer();

            customer2.Id = 112;
            customer2.Name = "Veli";
            customer2.Lastname = "Yıldız";
            customer2.Jobs = "Mühendis";

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            Console.WriteLine("***************");
            customerManager.List(customer2);
            Console.WriteLine("***************");
            customerManager.Delete(customer1);
            Console.WriteLine("***************");
        }
    }
}
