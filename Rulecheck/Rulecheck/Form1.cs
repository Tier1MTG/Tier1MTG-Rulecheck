using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rulecheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] blockset;
        string single = "";
        string[] cmprice = new string[2];
        int value = -0;
        string valueModifier = "";


        private void _cmprice_TextUpdate(object sender, EventArgs e)
        {
            switch(_cmprice.Text)
            {
                case "Cheapest Seller":
                    Console.WriteLine(_cmprice.Text);
                    break;

                case "Most Expensive Seller":
                    Console.WriteLine(_cmprice.Text);
                    break;

                case "Trend Price":
                    Console.WriteLine(_cmprice.Text);
                    break;

                case "Follow Seller":
                    Console.WriteLine(_cmprice.Text);
                    break;

                default:
                    Console.WriteLine("a");
                    break;
            }
        }

        private void _value_TextChanged(object sender, EventArgs e)
        {

            value = -0;

            int number;

            bool success = Int32.TryParse(_value.Text, out number);

            if(success)
            {
                value = number;
                Console.WriteLine(value);
            }

        }

        private void _valueModifier_TextUpdate(object sender, EventArgs e)
        {

        }

    }
}
