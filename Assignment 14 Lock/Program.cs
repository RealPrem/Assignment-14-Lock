using System;
using System.Threading;

namespace Assignment_14_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            Lock NewLock = new Lock();
            /*
            Console.WriteLine("LOCK STATUS: " + NewLock.IsLocked());
            NewLock.CloseLock();
            Console.WriteLine("LOCK STATUS: " + NewLock.IsLocked());
            */

            Combination_Lock C = new Combination_Lock();
            C.CloseLock();
            /*
            C.OpenLock("111");
            Console.WriteLine("LOCK STATUS: " + C.IsLocked());
            C.OpenLock("999");
            Console.WriteLine("LOCK STATUS: " + C.IsLocked());
            */

            C.ChangeCombination("123");
            C.OpenLock("123");
            Console.WriteLine("LOCK STATUS: " + C.IsLocked());
            Console.WriteLine("LOCK STATUS: " + C.IsLocked());
        }
    }
}
