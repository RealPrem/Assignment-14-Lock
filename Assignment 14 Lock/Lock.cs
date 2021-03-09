using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_14_Lock
{
    class Lock
    {
        protected bool Locked;
        protected string Combination = "999";

        public Lock()
        {
            Locked = false;
        }

        public bool IsLocked()
        {
            return Locked;
        }
        public void CloseLock()
        {
            Locked = true;
        }
        public virtual void OpenLock()
        {
            Locked = false;
        }
    }
}
