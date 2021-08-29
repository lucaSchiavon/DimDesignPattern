using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Creazionali.Singleton
{
   public class AmministratoreDelegato
    {
        private static string nome;
        private static string codFisc;
        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        public string CodiceFiscale
        {
            get => codFisc;
            set => codFisc = value;
        }
    }
}
