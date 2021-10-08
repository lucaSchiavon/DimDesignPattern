using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Comportamentali.Command
{
    public interface ICommand
    {
        void Call();
        void Undo();
    }
}
