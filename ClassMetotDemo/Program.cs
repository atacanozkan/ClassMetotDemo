using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Atacan";
            customer1.Surname = "Özkan";

            Customer customer2 = new Customer();
            customer2.Id = 1;
            customer2.Name = "Ali";
            customer2.Surname = "Özkan";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.Update(customer1);
            customerManager.Monitor(customer2);
        }
    }
}
