using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = "";
            string contact = "";
            string address = "";
            string item = "";
            int quantity;
            int price = 0;

            name = nameTextBox.Text;
            contact = contactTextBox.Text;
            address = addressTextBox.Text;
            item = itemComboBox.Text;
            quantity = int.Parse(quantityTextBox.Text);

            if(itemComboBox.Text == "Black-120")
            {
                price = quantity * 120;
            }
            else if(itemComboBox.Text =="Cold-100")
            {
                price = quantity * 100;
            }
            else if (itemComboBox.Text == "Hot-90")
            {
                price = quantity * 90;
            }
            else if (itemComboBox.Text == "Regular-80")
            {
                price = quantity * 80;
            }

            displayRichTextBox.AppendText("Name: "+name + "\nContact: " + contact + "\nAdress: " + address + "\nItem: " + item + "\nQuantity: " + quantity + "\nPrice: " + Convert.ToString(price));

        }
    }
}
