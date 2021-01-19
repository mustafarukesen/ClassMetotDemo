using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'ESEN Hotel'\n");

            Customer customerOne = new Customer();
            customerOne.ID = "19721972";
            customerOne.Name = "Dennis Ritchie";
            customerOne.PhoneNumber = "+1 958-522-37712";
            customerOne.Job = "Programmer";

            Customer customerTwo = new Customer();
            customerTwo.ID = "19691969";
            customerTwo.Name = "Ken Thompson";
            customerTwo.PhoneNumber = "+1 215-472-21132";
            customerTwo.Job = "Programmer";

            Customer[] customers = new Customer[] { customerOne, customerTwo };

            foreach (var customer in customers)
            {
                Console.WriteLine("ID: " + customer.ID + "\nName: " + customer.Name + "\nPhone: " + customer.PhoneNumber + "\nJob: " + customer.Job + "\n"  );
            }

            CustomerManager customerManage = new CustomerManager();

            customerManage.Add(customerOne);
            customerManage.Delete(customerTwo);
        }
    }
}
