using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatternDimitri.Creazionali.Singleton
{
    //public class Cache
    //{
    //    private static readonly object singletonLock = new object();
    //    private static Cache instance;
    //    private Cache()
    //    {

    //    }
    //    public static Cache getInstance()
    //    {
    //        if (instance == null)
    //        {
    //            lock (singletonLock)
    //            {
    //                instance = new Cache();
    //            }
    //            // return Interlocked.Increment(ref s_Number);

    //        }
    //        return instance;
    //    }

    //}

    public class Cache
    {
        private Cache() { }
        public static Cache Instance { get; } = new Cache();
    }

    //public class Cache
    //{

    //}

    //public static class Globals
    //{
    //    public static Cache Cache = new Cache();

    //    public static Cache Cache2 ;
    //}


}
