using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    class ATM
    {
        Dictionary<int, int> affordableBanknotes;
        int quantityLimit = 0;
        int currentAmount = 0;
        int numberOfBills = 0;

        public ATM(Dictionary<int,int> banknotes, int limit)
        {
            affordableBanknotes = banknotes;
            quantityLimit = limit;
            foreach(var item in affordableBanknotes)
            {
                currentAmount += item.Key * item.Value;
                numberOfBills += item.Value;
            }
        }


    }
}
