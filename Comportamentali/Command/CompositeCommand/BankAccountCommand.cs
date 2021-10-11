using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Comportamentali.Command.CompositeCommand
{
    public class BankAccountCommand : Command
    {
        private BankAccount account;
        private Action action;
        private int amount;
        private static bool Succeeded;

        public BankAccountCommand(BankAccount account, Action action, int amount)
        {
            this.account = account;
            this.action = action;
            this.amount = amount;
        }

        public enum Action
        { 
            Deposit,Withdraw 
        }

        public override void Call()
        {
            switch (action)
            {
                case Action.Deposit:
                    account.Deposit(amount);
                    break;
                case Action.Withdraw:
                   Succeeded= account.Withdraw(amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public override void Undo()
        {
            if (!Succeeded) return;
            switch (action)
            {
                case Action.Deposit:
                     account.Withdraw(amount);
                    break;
                case Action.Withdraw:
                    account.Deposit(amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
