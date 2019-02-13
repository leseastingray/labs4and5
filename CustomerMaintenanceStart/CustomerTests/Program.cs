using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMaintenanceClasses;

namespace CustomerTests
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestCustomerMembers()
            TestCustomerConstructors();
            TestCustomerPropertyGetters();
            TestCustomerPropertySetters();
            TestCustomerMethods();

            // TestCustomerAll()

            Console.WriteLine();
            Console.ReadLine();
        }


        static void TestCustomerConstructors()
        {
            Customer c1 = new Customer();
            Customer c2 = new Customer("Jake", "this is a test customer", "jkam@dog.net");

            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Default constructor. Expecting default values. " + c1.GetDisplayText());
            Console.WriteLine("Overloaded constructor. Expecting Jake this is a test customer, jkam@dog.net"
                    + c2.GetDisplayText());
            Console.WriteLine();
        }

        static void TestCustomerPropertyGetters()
        {
            Customer c1 = new Customer("Jake", "this is a test customer", "jkam@dog.net");

            Console.WriteLine("Testing getters");
            Console.WriteLine("First name. Expecting Jake. " + c1.FirstName);
            Console.WriteLine("Last name. Expecting this is a test customer. " + c1.LastName);
            Console.WriteLine("Email. Expecting jkam@dog.net. " + c1.Email);
            Console.WriteLine();
        }

        static void TestCustomerPropertySetters()
        {
            Customer c1 = new Customer("Jake", "this is a test customer", "jkam@dog.net");

            Console.WriteLine("Testing setters");
            c1.FirstName = "Jeff";
            c1.LastName = "Last";
            c1.Email = "jlast@dog.net";
            Console.WriteLine("Expecting Jeff Last, jlast@dog.net " + c1.GetDisplayText());
            Console.WriteLine();
        }

        static void TestCustomerMethods()
        {
            Customer c1 = new Customer("Jake", "this is a test customer", "jkam@dog.net");

            Console.WriteLine("Testing GetDisplayText");
            Console.WriteLine("Expecting Jake this is a test customer, jkam@dog.net " + c1.GetDisplayText());
            Console.WriteLine();
        }

        static void TestCustomerAll()
        {
            TestCustomerConstructors();
            TestCustomerPropertyGetters();
            TestCustomerPropertySetters();
            TestCustomerMethods();
            Console.WriteLine();
        }
    }
}
