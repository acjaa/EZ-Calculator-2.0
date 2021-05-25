using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = " ";
            if (String.IsNullOrEmpty(textBox1.Text)) //prevents empty boxes
            {
                label2.Text = "You need to enter some numbers";
            }
            else if (String.IsNullOrEmpty(textBox2.Text)) //prevents empty boxes
            {
                label2.Text = "You need to enter some numbers";
            }
            else
            {
                int num1, num2, sum;                      //Initalizes value names  
                num1 = Convert.ToInt32(textBox1.Text);    // Converts textbox data into numeric value and applys to num1
                num2 = Convert.ToInt32(textBox2.Text);    // Converts textbox data into numeric value and applys to num2

                sum = num1 + num2; // Adds num1 + num2 and applys it to the value "sum"

                label1.Text = Convert.ToString(sum); // Sets the display label to the outcome of the entered values
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = " ";
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                label2.Text = "You need to enter some numbers";
            }
            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                label2.Text = "You need to enter some numbers";
            }
            else
            {
                int num1, num2, sum;
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);

                sum = num1 - num2;  // subtracts the two values from one another and applys it to the "Sum" value

                label1.Text = Convert.ToString(sum);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = " ";
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                label2.Text = "You need to enter some numbers";
            }
            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                label2.Text = "You need to enter some numbers";
            }
            else
            {
                int num1, num2, sum;
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);

                if (num1 == 0)
                {
                    label2.Text = "You can't Devide by 0!"; // Prevents the user from dividing by 0 and breaking the program
                }
                else if (num2 == 0)
                {
                    label2.Text = "You can't Devide by 0!"; // Prevents the user from dividing by 0 and breaking the program
                }
                else
                {
                    sum = num1 / num2; // Divides the values and applys to "Sum"

                    label1.Text = Convert.ToString(sum);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = " ";
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                label2.Text = "You need to enter some numbers";
            }
            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                label2.Text = "You need to enter some numbers";
            }
            else
            {
                int num1, num2, sum;
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);

                sum = num1 * num2;

                label1.Text = Convert.ToString(sum);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }
    }
}
