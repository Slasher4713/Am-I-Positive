using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Am_I_Positive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(integerInput.Text);

            if (number >= 0)
            {
                integerOutput.Text = $"{number} is a positive number";
            }
            else
            {
                integerOutput.Text = $"{number} is a negative number";
            }

            if (number %7 == 0)
            {
                divisibleOutput.Text = $"{number} is divisible by 7";
            }
            else
            {
                divisibleOutput.Text = $"{number} is NOT divisible by 7";
            }
        }
    }
}
