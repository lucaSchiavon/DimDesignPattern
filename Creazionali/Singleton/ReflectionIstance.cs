using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Creazionali.Singleton
{
    using System;
    using System.Reflection;

    class Addition
    {
        //public Addition(int a)
        //{
        //    Console.WriteLine("Constructor called, a={0}", a);
        //}
        public Addition()
        {
            Console.WriteLine("Constructor called");
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    
}
