using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp_FinalProjSample
{
    class ShoppingList
    {
        List<ShoppingItem> shoppingList;

        public ShoppingList()
        {
            shoppingList = new List<ShoppingItem>();
        }

        public IEnumerable<ShoppingItem> GetUnPurchased()
        {
            List<ShoppingItem> unpurchased = new List<ShoppingItem>();
            foreach (ShoppingItem item in shoppingList)
            {
                if (!item.PuchasedYN)
                {
                    unpurchased.Add(item);
                }
            }
            return unpurchased;
        }



    }
}
