using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.Name} {customer.Surname} named customer added.");
        }

        public void Monitor(Customer customer)
        {
            Console.WriteLine($"{customer.Name} {customer.Surname} named customer monitored.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine($"{customer.Name} {customer.Surname} named customer deleted.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine($"{customer.Name} {customer.Surname} named customer updated.");
        }
    }
}
