using System;
using System.Collections.Generic;
using System.Text;
using Pokemon_Beep.Other;

namespace Pokemon_Beep.Player
{
    /// <summary>
    /// This class will be used for item storage.
    /// </summary>
    [Serializable]
    class Inventory
    {
        private IDictionary<int, int> invItems = new Dictionary<int, int>();
        public Inventory()
        {
            for (int i = 0; i < (int)Enum.Count.Items; i++)
            {
                //This is initialising a new inventory. Will put every item with a value of 0
                invItems.Add(i, 0);
            }
        }
        public Inventory(IDictionary<int, int> invItems)
        {
            this.invItems = invItems;
        }
        public void addItem(int ID)
        {
            //Add +1 to the item
            if (invItems.ContainsKey(ID))
                invItems[ID] += 1;
        }
        public void removeItem(int ID)
        {
            //remove -1 to the item
            if (invItems[ID] > 0)
                invItems[ID] -= 1;
            //Prevent an item to be -1
            else
                invItems[ID] = 0;
        }
        public void useItem(int ID)
        {

        }
        public IDictionary<int, int> getValues()
        {  return invItems;  }
    }
}
