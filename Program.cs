using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basgrupp5_Fall2
{
    class Program
    {
        public static List<Person> People = new List<Person>();
        static void Menu()
        {
            Console.WriteLine("___________________________________________ \n");
            Console.WriteLine("Var vänlig att ange en siffra för kommando: \n1 - Lägg till \n2 - Lista \n3 - Redigera \n4 - Radera \n5 - Sök");
        }
        static void Edit()
        {
            Console.WriteLine("___________________________________________ \n");
            Console.WriteLine("Vad vill du redigera? \na - Förnamn\nb - Efternamn\nc - Hemnummer\nd - Jobbnummer\ne - Adress\nf - Email\n");
        }

        static void Enter()
        {
            Console.WriteLine("Tryck enter för att återvända till Menyn.");
        }

        static void Search()
        {
            Console.WriteLine("___________________________________________ \n");
            Console.WriteLine("Vad vill du söka efter? \na - Förnamn\nb - Efternamn\nc - Hemnummer\nd - Jobbnummer\ne - Adress\nf - Email\n");
        }
        private static void AddPerson()
        {
            Person person = new Person();

            Console.Write("Skriv in förnamn: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Skriv in efternamn: ");
            person.LastName = Console.ReadLine();

            Console.Write("Skriv in telefonnummer hem: ");
            person.PhoneNumber1 = Console.ReadLine();

            Console.WriteLine("Skriv in telefonnummer jobb: ");
            person.PhoneNumber2 = Console.ReadLine();

            Console.Write("Skriv in adress: ");
            person.Address = Console.ReadLine();

            Console.Write("Skriv in e-mail: ");
            person.Email = Console.ReadLine();


            People.Add(person);
        }
        private static void PrintPerson(Person person)
        {

            Console.WriteLine("Förnamn: " + person.FirstName);
            Console.WriteLine("Efternamn: " + person.LastName);
            Console.WriteLine("Telefonnummer Hem: " + person.PhoneNumber1);
            Console.WriteLine("Telefonnummer Jobb: " + person.PhoneNumber2);
            Console.WriteLine("Adress: " + person.Address);
            Console.WriteLine("E-mail: " + person.Email);
        }
        private static void ListPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Din kontaktlista är tom.");
                Enter();
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Här är en lista över kontakterna i din kontaktlista:\n");
            foreach (var person in People)
            {
                PrintPerson(person);
                Console.WriteLine("\n");
            }
            Enter();
            Console.ReadKey();


        }
        private static void EditPerson()
        {
            Console.WriteLine("Skriv in förnamnet på personen du vill redigera.");
            string Name = Console.ReadLine();
            Person person = People.FirstOrDefault(x => x.FirstName.ToLower() == Name.ToLower());

            if (person == null)
            {
                Console.WriteLine("Personen du angav finns inte med i kontaktlistan.");
                Enter();
                Console.ReadKey();
                return;
            }
            PrintPerson(person);
            Edit();
            var command = "";
            while (command != "exit")
            {
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "a":
                        person.EditFirst();
                        Console.WriteLine("\n Redigera förnamn: ");
                        person.FirstName = Console.ReadLine();
                        PrintPerson(person);
                        Enter();
                        Console.ReadKey();
                        break;
                    case "b":
                        person.EditFirst2();
                        Console.WriteLine("\n Redigera efternamn: ");
                        person.LastName = Console.ReadLine();
                        PrintPerson(person);
                        Enter();
                        Console.ReadKey();
                        break;
                    case "c":
                        person.EditFirst3();
                        Console.WriteLine("\n Redigera hemnummer: ");
                        person.PhoneNumber1 = Console.ReadLine();
                        PrintPerson(person);
                        Enter();
                        Console.ReadKey();
                        break;
                    case "d":
                        person.EditFirst4();
                        Console.WriteLine("\n Redigera jobbnummer: ");
                        person.PhoneNumber2 = Console.ReadLine();
                        PrintPerson(person);
                        Enter();
                        Console.ReadKey();
                        break;
                    case "e":
                        person.EditFirst5();
                        Console.WriteLine("\n Redigera adress: ");
                        person.Address = Console.ReadLine();
                        PrintPerson(person);
                        Enter();
                        Console.ReadKey();
                        break;
                    case "f":
                        person.EditFirst6();
                        Console.WriteLine("\n Redigera email: ");
                        person.Email = Console.ReadLine();
                        PrintPerson(person);
                        Enter();
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Felaktig inmatning, försök igen\n");
                        Enter();
                        Console.ReadKey();
                        break;

                }
                return;
            }

        }
        private static void RemovePerson()
        {
            Console.WriteLine("Skriv in förnamnnet på personen du vill radera.");
            string Name = Console.ReadLine();
            Person person = People.FirstOrDefault(x => x.FirstName.ToLower() == Name.ToLower());

            if (person == null)
            {
                Console.WriteLine("Personen du angav finns inte med i kontaktlistan.");
                Enter();
                Console.ReadKey();
                return;
            }

            PrintPerson(person);
            Console.WriteLine("Är du säker på att du vill radera den här kontakten från din kontaktlista? (J/N)");


            if (Console.ReadKey().Key == ConsoleKey.J)
            {
                People.Remove(person);
                Console.WriteLine("\nKontakten har raderats.");
                Enter();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nKontakten har inte raderats.");
                Enter();
                Console.ReadKey();
            }
        }
        private static void SearchPerson()
        {
            string command = "";
            while (command != "exit")
            {
                

                Search();
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "a":
                        Console.WriteLine("Skriv in förnamnet på kontakten du vill hitta.");
                        string Name = Console.ReadLine();
                        Person person = People.FirstOrDefault(x => x.FirstName.ToLower() == Name.ToLower());

                        if (person == null)
                        {
                            Console.WriteLine("Förnamnet du angav finns inte med i kontaktlistan.");
                            Enter();
                            Console.ReadKey();
                            return;
                        }

                        PrintPerson(person);                        
                        Enter();
                        Console.ReadKey();

                        break;
                    case "b":
                        Console.WriteLine("Skriv in efternamnet på kontakten du vill hitta.");
                        string lastName = Console.ReadLine();
                        Person person2 = People.FirstOrDefault(x => x.LastName.ToLower() == lastName.ToLower());

                        if (person2 == null)
                        {
                            Console.WriteLine("Efternamnet du angav finns inte med i kontaktlistan.");
                            Enter();
                            Console.ReadKey();
                            return;
                        }

                        PrintPerson(person2);                        
                        Enter();
                        Console.ReadKey();


                        break;
                    case "c":
                        Console.WriteLine("Skriv in Telefonnumret (Hem) tillhörande kontakten du vill hitta.");
                        string phoneNumber1 = Console.ReadLine();
                        Person person4 = People.FirstOrDefault(x => x.PhoneNumber1.ToLower() == phoneNumber1.ToLower());

                        if (person4 == null)
                        {
                            Console.WriteLine("Telefonnumret du angav finns inte med i kontaktlistan.");
                            Enter();
                            Console.ReadKey();
                            return;
                        }

                        PrintPerson(person4);                        
                        Enter();
                        Console.ReadKey();


                        break;
                    case "d":
                        Console.WriteLine("Skriv in Telefonnumret (Jobb) tillhörande kontakten du vill hitta.");
                        string phoneNumber2 = Console.ReadLine();
                        Person person5 = People.FirstOrDefault(x => x.PhoneNumber2.ToLower() == phoneNumber2.ToLower());

                        if (person5 == null)
                        {
                            Console.WriteLine("Telefonnumret du angav finns inte med i kontaktlistan.");
                            Enter();
                            Console.ReadKey();
                            return;
                        }

                        PrintPerson(person5);                        
                        Enter();
                        Console.ReadKey();


                        break;
                    case "e":
                        Console.WriteLine("Skriv in adressen tillhörande kontakten du vill hitta.");
                        string Address = Console.ReadLine();
                        Person person3 = People.FirstOrDefault(x => x.Address.ToLower() == Address.ToLower());

                        if (person3 == null)
                        {
                            Console.WriteLine("Adressen du angav finns inte med i kontaktlistan.");
                            Enter();
                            Console.ReadKey();
                            return;
                        }

                        PrintPerson(person3);                        
                        Enter();
                        Console.ReadKey();


                        break;
                    case "f":
                        Console.WriteLine("Skriv in E-mail-adressen tillhörande kontakten du vill hitta.");
                        string email = Console.ReadLine();
                        Person person6 = People.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());

                        if (person6 == null)
                        {
                            Console.WriteLine("E-mail-adressen du angav finns inte med i kontaktlistan.");
                            Enter();
                            Console.ReadKey();
                            return;
                        }

                        PrintPerson(person6);                        
                        Enter();
                        Console.ReadKey();

                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Felaktig inmatning, försök igen\n");
                        Enter();
                        Console.ReadKey();
                        break;

                }
                return;
            }

        }
        static void Main(string[] args)
        {
            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Menu();
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        ListPeople();
                        break;
                    case "3":
                        EditPerson();
                        break;
                    case "4":
                        RemovePerson();
                        break;
                    case "5":
                        SearchPerson();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Felaktig inmatning, försök igen\n");
                        Enter();
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}