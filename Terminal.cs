using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankkontoInlämningsuppgift
{
    internal class Terminal
    {
        public string Name { get; set; }
        private Bank bank;

        public Terminal(Bank bank)
        {
            this.bank = bank;
            ShowMainMenu();
        }

        public void ShowMainMenu()
        {
            Console.WriteLine("1: För att se kontonr");
            Console.WriteLine("2: För att göra en insättning på ett konto");
            Console.WriteLine("3: För att göra ett uttag på ett konto");
            Console.WriteLine("4: Skriv ut en lista på alla kontonr och saldon");
            MainMenuInput();
        }

        public void MainMenuInput()
        {
            int menuChoice = Convert.ToInt32(Console.ReadLine());
            switch (menuChoice)
            {
                case 1:
                    bank.ShowAllBankAccounts();
                    ShowMainMenu();
                    break;
                case 2:
                    DepositMenu();
                    ShowMainMenu();
                    break;
                case 3:
                    //
                    break;
                case 4:
                    bank.ShowAllBankAccountsAndBalances();
                    ShowMainMenu();
                    break;

            }

        }

        public void DepositMenu()
        {
            bank.ShowAllBankAccounts();
            Console.WriteLine("Vilket kontonr vill du göra en insättning till? ");
            int? accountNmbr = bank.RetrieveSpecificAccount();
            Console.WriteLine(accountNmbr);
            

        }
        

 
    }
}
