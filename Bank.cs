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
            int i = 1;
            foreach (Account account in AccountList)
            {

                Console.WriteLine($"Konto nummer {i}\nKontonr: {account.AccountNumber}\n{account.AccountBalance}");
                i++;
            }
        }

        public void ShowAllBankAccounts()
        {
            int i = 1;
            foreach (Account account in AccountList)
            {

                Console.WriteLine($"Konto nummer {i}\nKontonr: {account.AccountNumber}");
                i++;
            }
        }

        public List<Account> RetrieveAccountList()
        {
            return AccountList;
        }

        public int? RetrieveSpecificAccount() 
        {
            int userChoiceAccountNmbr = Convert.ToInt32(Console.ReadLine());
            foreach (Account account in AccountList)
            {
                if (account.AccountNumber == userChoiceAccountNmbr)
                {
                    int chosenAccount = account.AccountNumber;
                    return chosenAccount;
                }
            }

            Console.WriteLine("Välj ett legit kontonr");
            return null;

        }

    }
}
