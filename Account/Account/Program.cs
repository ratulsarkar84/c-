using System;

namespace Account
{
    public class Account
    {
        String accName;
        String acid;
        int balance;
        public String AccName
        {
            set { accName = value; }
            get { return accName; }

        }
        public String AcId
        {
            set { acid = value; }
            get { return acid; }
            
        }
        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Account Name:"+ accName);
            Console.WriteLine("Account Id:"+acid);
            Console.WriteLine("Balance:"+balance);
        }
        public void Deposit(int amount)
        {
            if(amount>=0)
            {
                Console.WriteLine("Previous Amount : " + balance);
                Console.WriteLine("Your Deposit : " + amount+"$");
                balance = balance + amount;
                Console.WriteLine("Current Balance " + balance + " $");

            }
            else
            {
                Console.WriteLine("You Have No Sufficient Balance");
            }
        }
        public void Withdraw(int amount)
        {
            if(amount>0 && amount<balance)
            {
                Console.WriteLine("Previous Amount : " + balance);
                Console.WriteLine("You withdraw " + amount + " $");
                balance = balance - amount;
                Console.WriteLine("Current Balance " + balance + " $");
            }
            else
            {
                if(amount < 0)
                {
                    Console.WriteLine("Invalid Balance");
                }
                else if(amount>balance)
                {
                    Console.WriteLine("You Have not Enough $");
                }
            }
        }




    }
    class Program
    {
        static void Main(string[] args)
        {
            Account A = new Account();
            A.AccName = "RIMON";
            A.AcId = "147-5666551-96";
            A.Balance = 500000000;
            A.Deposit (10000);
            A.Withdraw(6000);
            A.ShowInfo();
        }
    }
}
