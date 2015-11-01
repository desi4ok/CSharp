using System;

    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Desislava";
            string secondName = "Valentinova";
            string thirdName = "Goleva";
            int balance = 5;
            string bankName = "Softuni";
            string iBan = "SU00 0000 0000 0000 0000 0000";
            string firstCardNum = "0000 0000 0000 1111";
            string secondCardNum = "0000 0000 0000 2222";
            string thirdCardNum = "0000 0000 0000 3333";
            Console.WriteLine("Name: " + firstName + secondName + thirdName);
            Console.WriteLine("Bank: " + bankName);
            Console.WriteLine("account balance: " + balance + " лв.");
            Console.WriteLine("IBAN: " + iBan);
            Console.WriteLine("Credit card numbers: " + firstCardNum + ", " + secondCardNum + ", " + thirdCardNum);
        }
    }

