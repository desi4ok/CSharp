using System;

    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();

            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();

            Console.Write("Phone number: ");
            int phoneNumber = int.Parse(Console.ReadLine());

            Console.Write("Fax number: ");
            int faxNumber = int.Parse(Console.ReadLine());

            Console.Write("Web site: ");
            string webSite = Console.ReadLine();

            Console.Write("Manager first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Manager last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Manager age: ");
            byte age = byte.Parse(Console.ReadLine());

            Console.Write("Manager phone: ");
            int managerPhone = int.Parse(Console.ReadLine());

            Console.WriteLine(@"
            Company name:       {0} 
            Company address:    {1} 
            Phone number:       {2} 
            Fax number:         {3} 
            Web site            {4} 
            Manager first name: {5} 
            Manager last name:  {6} 
            Manager age:        {7} 
            Manager phone:      {8}", companyName, companyAddress, phoneNumber, faxNumber, webSite, firstName, lastName, age, managerPhone);
        }
    }
