using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Assignment_14_Lock
{
    class Combination_Lock : Lock
    {
        public Combination_Lock()
        {

        }
        public void OpenLock(string TriedCombination)
        {
            if (Combination == TriedCombination)
            {
                Locked = false;
                Delay();
                Locked = true;
            }
        }
        public void ChangeCombination(string NewCombination)
        {
            if (int.TryParse(NewCombination, out int TestCombination))
            {
                if (NewCombination.Length <= 3)
                {
                    Combination = NewCombination;
                }
                else
                {
                    Console.WriteLine("LENGTH ERROR");
                }
            }
            else
            {
                Console.WriteLine("TYPE ERROR");
            }
        }
        public void Delay()
        {
            Thread.Sleep(5000);
        }
    }
}