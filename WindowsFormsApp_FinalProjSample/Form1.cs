using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_FinalProjSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            string name = textBoxItemName.Text.ToString();
            int amount = Int32.Parse(textBoxItemAmount.Text);
            ShoppingItem newItem = new ShoppingItem(name, amount);
            listBox1.Items.Add(newItem.getDescription());
        }
    }
}
