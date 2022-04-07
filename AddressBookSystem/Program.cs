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
            Console.WriteLine("welcome to address book");
            Person.AddPerson();
            Person.Modify();
            Person.ListPeople();
            Console.ReadLine();
         }
    }
}
