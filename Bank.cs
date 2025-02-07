using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankkontoInlämningsuppgift
{
    internal class Bank //För att hantera menyn och terminal
    {
        public List<Account> AccountList { get; set; } = new List<Account>();
        private Terminal bankTerminal;
        public string Namn { get; set; }

        public Bank()
        {
            LoadBankAccounts();
            this.bankTerminal = new Terminal(this);
            bankTerminal.ShowMainMenu();
        }

        public void LoadBankAccounts()
        {
            for (int i = 0; i < 10; i++)
            {
                AccountList.Add(new Account());
            }
        }

        public void ShowAllBankAccountsAndBalances()
        {
            foreach (Account account in AccountList)
            {

                Console.WriteLine($"Kontonr: {account.AccountNumber}\n{account.AccountBalance}");
            }
        }

        public void ShowAllBankAccounts()
        {
            foreach (Account account in AccountList)
            {

                Console.WriteLine($"Kontonr: {account.AccountNumber}");

            }
        }

        public List<Account> RetrieveAccountList() //Beehövs denna?
        {
            return AccountList;
        }

        public void DepositToAccount(int userChoiceAccountNmbr, int userBalanceDeposit)
        {
            if (userBalanceDeposit >= 0) 
            {
                foreach (Account account in AccountList)
                {
                    if (account.AccountNumber == userChoiceAccountNmbr)
                    {
                        int currentAccountBalance = account.AccountBalance;
                        account.AccountBalance = userBalanceDeposit + currentAccountBalance;
                        Console.WriteLine($"Du har nu satt in {account.AccountBalance} i kontonr: {account.AccountNumber}");

                    }
                }
            }
            else
            {
                Console.WriteLine("Insättning måste vara positiv");
            }
        }

        public void WithdrawFromAccount(int userChoiceAccountNmbr, int userBalanceWithdraw)
        {
            if (userBalanceWithdraw <= 0)
            {
                foreach (Account account in AccountList)
                {
                    if (account.AccountNumber == userChoiceAccountNmbr)
                    {
                        int currentAccountBalance = account.AccountBalance;
                        account.AccountBalance = userBalanceWithdraw + currentAccountBalance;
                        Console.WriteLine($"Du har nu satt in {account.AccountBalance} i kontonr: {account.AccountNumber}");

                    }
                }
            }
            else
            {
                Console.WriteLine("Uttag måste vara negativ");
            }
        }

    }
}
