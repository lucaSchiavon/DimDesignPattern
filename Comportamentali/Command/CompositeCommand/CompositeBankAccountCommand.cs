using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternDimitri.Comportamentali.Command.CompositeCommand
{
    public class CompositeBankAccountCommand: List<BankAccountCommand>,ICommand
    {
       
        public virtual void Call()
        {
            ForEach(cmd => cmd.Call());
        }

        public virtual void Undo()
        {
            IEnumerable<BankAccountCommand> LstReverse = this;
            foreach (var cmd in (IEnumerable<BankAccountCommand>)this)
            {
                cmd.Undo();
            }
        }
    }
}
