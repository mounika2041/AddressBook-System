using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Person
    {  
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string pin { get; set; }
        public string email { get; set; }

        public static List<Person> people = new List<Person>();

        public static void AddPerson()
        {
            Person person = new Person();
            Console.WriteLine("enter a first name:");
            person.FirstName = Console.ReadLine();
            Console.WriteLine("enter a last name:");
            person.LastName = Console.ReadLine();
            Console.WriteLine("enter a phone number:");
            person.PhoneNumber = Console.ReadLine();
            Console.WriteLine("enter a Address:");
            person.Address = Console.ReadLine();
            Console.WriteLine("enter a state name:");
            person.state = Console.ReadLine();
            Console.WriteLine("enter a city name:");
            person.city = Console.ReadLine();
            Console.WriteLine("enter a pin no:");
            person.pin = Console.ReadLine();
            Console.WriteLine("enter a email");
            person.email = Console.ReadLine();
            Console.WriteLine("--------------------------");
            people.Add(person);
        }
        private static void PrintPerson(Person person)
        {
            Console.WriteLine("first Name :" + person.FirstName);
            Console.WriteLine("last Name :" + person.LastName);
            Console.WriteLine("phone Number :" + person.PhoneNumber);
            Console.WriteLine("Address:" + person.Address);
            Console.WriteLine("state:" + person.state);
            Console.WriteLine("city :" + person.city);
            Console.WriteLine("pin no:" + person.pin);
            Console.WriteLine("email:" + person.email);
            Console.WriteLine("---------------------------------");

        }
        public static void Modify()
        {
            if (people.Count != 0)
            {
                Console.WriteLine("Enter the contact to modify:");
                string Modified = Console.ReadLine();
                foreach (var person in people)
                {
                    if (person.FirstName.ToUpper() == Modified.ToUpper())
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter the option to modify the property: ");
                            Console.WriteLine("Enter 1 to Change First name ");
                            Console.WriteLine("Enter 2 to Change Last name ");
                            Console.WriteLine("Enter 3 to Change Phone Number ");
                            Console.WriteLine("Enter 4 to Change Address ");
                            Console.WriteLine("Enter 5 to Change state");
                            Console.WriteLine("Enter 6 to Change city ");
                            Console.WriteLine("Enter 7 to Change Pincode ");
                            Console.WriteLine("Enter 8 to change email ");
                            Console.WriteLine("Enter 9 to Exit ");
                            int Check = Convert.ToInt32(Console.ReadLine());
                            switch (Check)
                            {
                                case 1:
                                    Console.WriteLine("Enter the New First Name: ");
                                    person.FirstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the New Last Name: ");
                                    person.LastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the New Phone Number: ");
                                    person.PhoneNumber = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the New Address: ");
                                    person.Address = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter the New  State: ");
                                    person.state = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter the New city: ");
                                    person.city = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.WriteLine("Enter the New Pin Code: ");
                                    person.pin = Console.ReadLine();
                                    break;
                                case 8:
                                    Console.WriteLine("Enter the New Email:");
                                    person.email = Console.ReadLine();
                                    break;
                                case 9:
                                    return;

                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine("Enter the valid name!");
                    }

                }


            }
        }

        public static void ListPeople()
        {
            if (people.Count == 0)
            {
                Console.WriteLine("your address book is empty");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("here are the modified current people in your address book:\n");
                foreach (var person in people)
                {
                    PrintPerson(person);
                }
                Console.WriteLine("\n press any key to continue");
                Console.ReadLine();
            }
        }
    }
}
