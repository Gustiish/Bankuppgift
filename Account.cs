﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankkontoInlämningsuppgift
{
    internal class Account //För att hantera enskilda konton
    {

        private int accountBalance;
        public int AccountBalance
        {
            get { return accountBalance; }

            set
            {
                if (value >= 0)
                {
                    this.accountBalance = value;
                }
                else
                {
                    Console.WriteLine("Saldo kan inte vara mindre än noll!"); //Om det nya saldot blir under noll triggas denna. 
                }

            }
        }

        private int accountNumber;

        //Ifall jag i framtiden vill lägga till nya kontonr måste de följa reglerna. 
        public int AccountNumber 
        {
            get { return accountNumber; }
            set
            {
                if (value.ToString().Length == 6)
                {
                    accountNumber = value;
                }
                else
                {
                    Console.WriteLine("Kontonr måste innehålla 6 siffror.");
                }

            }
        }

        public Account() //En konstruktor som generar nya konton med olika kontonr
        {
            this.AccountNumber = GenerateAccountNumbers();
            this.AccountBalance = 0;
        }

        public int GenerateAccountNumbers()
        {
            var randomNumbers = new Random();
            accountNumber = randomNumbers.Next(100000, 999999);
            return accountNumber;

        }



    }
}
