﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abschnitt_9_OOP_Projekt_Bankkonto
{
    internal class BankAccount
    {
        public string Number { get; private set; }
        public string Owner { get; private set; }
        public float Balance { get; private set; }

        public BankAccount(string number, string owner, float initialBalance)
        {
            Number = number;
            Owner = owner;
            Balance = initialBalance;
        }

        public void MakeDeposit(float amount)
        {
            Balance += amount;
        }

        public void MakeWithdrawal(float amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Unzureichender Saldo");
            }
        }

        public void PrintBalance()
        {
            Console.WriteLine($"Kontostand von {Owner}: {Balance}"); //{} = Interpolieren
        }
    }
}
