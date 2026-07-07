using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTASKS.src
{
    // BankAccount class with a private balance field and methods to get, input, and withdraw balance
    internal class BankAccount
    {
        private double balance;

        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Balance cannot be negative.");
                }
                else
                {
                    balance = value;
                }
            }
        }
        public double GetBalance()
        {
            return balance;
        }
        public void InputBalance(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Amount cannot be negative.");
            }
            else
            {
                Balance += amount;
            }
        }
        public void WithdrawBalance(double amount)
        {
            if (Balance < 0)
            {
                Console.WriteLine("Balance cannot be negative.");

            }
            else if (amount > Balance)// if the amount to withdraw is bigger than the balance, print an error message
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                Balance -= amount;
            }
        }
    }
 }
