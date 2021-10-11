using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Comportamentali.Command.CompositeCommand
{
    public abstract class Command
    {
    public bool Success;
     public virtual void Call() { }
     public virtual void Undo() { }
    }
}
