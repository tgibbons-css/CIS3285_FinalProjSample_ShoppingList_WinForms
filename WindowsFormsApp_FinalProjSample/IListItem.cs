using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp_FinalProjSample
{
    interface IListItem
    {
        bool IsChecked();
        void markChecked();
        string getDescription();

    }
}
