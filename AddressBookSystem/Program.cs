﻿using System;
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
            Person.AddPerson();
            Person.ListPeople();
            Console.ReadLine();
         }
    }
}
