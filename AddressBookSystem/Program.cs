using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
   class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("welcome to address book");
                Console.WriteLine("Enter 1  to add the details");
                Console.WriteLine("Enter 2 to modify the details");
                Console.WriteLine(" Enter 3 to Listing the details..");
                Console.WriteLine(" Enter 4 to delete the details");
                Console.WriteLine("Enter 5 to exit");
                Console.WriteLine("Enter a option");
                switch (Console.ReadLine())
                {
                    case "1":
                        Person.AddPerson();
                        Person.ListPeople();
                        break;
                    case "2":
                        Person.modify();
                        Person.ListPeople();
                        break;
                    case "3":
                        Person.ListPeople();
                        break;
                    case "4":
                        Person.Delete();
                        Person.ListPeople();
                        break;
                    default:
                        Console.WriteLine("Enter a valid option");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
