using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Creazionali.Singleton
{
    public class Logger
    {
        private Logger()
        {
            Console.WriteLine("Creata l'istanza del Logger");
        }
        private static Lazy<Logger> instance = new Lazy<Logger>(() => new Logger());

        public static Logger Instance
        {
            get 
            {
                return instance.Value;
            }
        }
    }

   
}
