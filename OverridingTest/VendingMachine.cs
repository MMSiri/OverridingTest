using System;
using System.Collections.Generic;
using System.Text;

namespace OverridingTest
{
    class VendingMachine
    {
        public virtual string Item { get; }

        protected virtual bool CheckAmount(decimal money)
        {
            return false;
        }

        public string Dispense(decimal money)
        {
            if (CheckAmount(money)) return Item;
            else return "Please enter the correct amount";
        }
    }
}
