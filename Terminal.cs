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
        }

        public void ShowMainMenu()
        {
            Console.WriteLine("1: För att se kontonr");
            Console.WriteLine("2: För att göra en insättning på ett konto");
            Console.WriteLine("3: För att göra ett uttag på ett konto");
            Console.WriteLine("4: Skriv ut en lista på alla kontonr och saldon");
            Console.WriteLine("5: Visa saldo för specifikt konto");
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
                    break;
                case 3:
                    WithdrawMenu();
                    break;
                case 4:
                    bank.ShowAllBankAccountsAndBalances();
                    ShowMainMenu();
                    break;
                case 5:
                    //Visa saldo för specifikt konto
                    break;
                

            }

        }

        public void DepositMenu()
        {
            bank.ShowAllBankAccounts();
            Console.WriteLine("Vilket kontonr vill du göra en insättning till? ");
            int userChoiceAccountNmbr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hur mycket vill du sätta in?");
            int userChoiceDeposit = Convert.ToInt32(Console.ReadLine());
            bank.DepositToAccount(userChoiceAccountNmbr, userChoiceDeposit);
            ShowMainMenu();

        }

        public void WithdrawMenu()
        {
            bank.ShowAllBankAccounts();
            Console.WriteLine("Vilket kontonr vill du göra ett uttag från? ");
            int userChoiceAccountNmbr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hur mycket vill du ta ut?");
            int userChoiceDeposit = Convert.ToInt32(Console.ReadLine());
            bank.WithdrawFromAccount(userChoiceAccountNmbr, userChoiceDeposit);
            ShowMainMenu();
        }
        

 
    }
}
