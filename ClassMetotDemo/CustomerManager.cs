using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
         public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " kişisi eklendi.");
        }
         public void List(Customer customer)
        {
            Console.WriteLine(customer.Name + " kişisinin bilgileri listelendi. ");
        }
         public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " kişisi silindi. ");
        }
    }
}
