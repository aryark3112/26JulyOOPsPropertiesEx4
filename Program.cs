using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine("Enter Id");
            customer.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Customer Details");
            Console.WriteLine("ID: "+customer.Id+"\n Name: "+customer.Name);
            Console.ReadKey();

        }
    }
}
