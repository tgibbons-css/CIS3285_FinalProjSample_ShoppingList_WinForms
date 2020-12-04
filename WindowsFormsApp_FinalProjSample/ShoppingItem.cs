using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp_FinalProjSample
{
    class ShoppingItem : IListItem
    {
        string name;
        int amount;
        DateTime dateAddedToList;
        bool puchasedYN;

        public ShoppingItem(string name, int amount)
        {
            this.name = name;
            this.amount = amount;
            puchasedYN = false;
            dateAddedToList = DateTime.Now;
        }

        public bool PuchasedYN { get => puchasedYN; }

        public bool IsChecked()
        {
            return PuchasedYN;
        }

        public void markChecked()
        {
            puchasedYN = true;
        }

        public string getDescription()
        {
            string des = name + "(" + amount + ")";
            return des;
        }

    }
}
