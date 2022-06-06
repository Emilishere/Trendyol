using System;

namespace Trendyol
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager employeemanage = new EmployeeManager();
            employeemanage.ManageEmployee();

            string ask = string.Empty;
            int i = 0;
            int[] Products = new int[i];
            for (; i < 10;)
            {
                Product newproduct = new Product();
                Console.WriteLine("Enter Id for the Product:");
                newproduct.Id= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the price");
                newproduct.Price = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter type of product");
                newproduct.Type = Console.ReadLine();
                Console.WriteLine("Add description to the product:");
                newproduct.Description = Console.ReadLine();
                string response = string.Empty;
                Console.WriteLine("what do you have as a free item by the product");
                do
                {
                    string item = Console.ReadLine();
                    newproduct.add_Items(item);
                    Console.WriteLine("Do you want to add another one? y-yes/n-no");
                    response = Console.ReadLine();
                } while (response == "y");
                string response2 = string.Empty;
                do
                {
                    Console.WriteLine("Description of your product right now:");
                    Console.WriteLine(newproduct.Description);
                    Console.WriteLine("Do you want to do some changes? y-yes, n-no");
                    Console.WriteLine("Write description you want");
                    string item = Console.ReadLine();
                    newproduct.edit_Description(item);
                } while (response2 == "y");
                Console.WriteLine("Do you want to add more product? y-yes/n-no");
                ask = Console.ReadLine();
                if (ask=="y")
                {
                    i++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("To do shopping, first register as a customer");
            CustomerManager customermanager = new CustomerManager();
            customermanager.ManageCustomer();


            









        }
    }
}
