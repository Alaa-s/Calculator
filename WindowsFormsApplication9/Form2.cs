using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form2 : Form
    {
        double evalu;
        double[] value = new double[100];
        string[] operation = new string[100];
        bool op_pressed = false;
        int i = 0;
        public Form2()
        {
            InitializeComponent();
        }
        public void disable()
        {
            textBox1.Enabled = false;
            button13.Show();
            button14.Hide();
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            
            button28.Enabled = false;

        }
        public void enable()
        {

            textBox1.Enabled = true;
            button14.Show();
            button13.Hide();
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button28.Enabled = true;
           
           
        }
        private void button_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || (op_pressed == true))
            {
                textBox1.Clear();
            }
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text ;
            textBox1.ForeColor = Color.White;
            if (textBox1.Text == ".")
            {
                textBox1.Text = "0.";
            }
            value[i] = double.Parse(textBox1.Text);

            op_pressed = false;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button c = (Button)sender;
            operation[i] = c.Text;
            op_pressed = true;
            equation.Text = equation.Text + " " + value[i] + " " + operation[i];
            i++;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            equation.Text = " ";
            evalu = 0;
            for (int j = i - 1; j >= 0; j--)
            {
                switch (operation[j])
                {
                    case "+":
                        {
                            evalu = (value[j] + value[j + 1]);
                            value[j] = evalu;
                            break;
                        }
                    case "-":
                        {
                            evalu = (value[j] - value[j + 1]);
                            value[j] = evalu;

                            break;

                        }
                    case "*":
                        {
                            evalu = (value[j] * value[j + 1]);
                            value[j] = evalu;
                            break;
                        }
                    case "/":
                        {
                            evalu = (value[j] / value[j + 1]);
                            value[j] = evalu;
                            break;
                        }
                    default:
                        {
                            break;
                        }


                }
            }
            textBox1.Text = evalu.ToString();
            op_pressed = true;
            for (int k = 0; k <= i; k++)
            {
                value[i] = 0;

            }
            i = 0;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || (op_pressed == true))
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + evalu.ToString();
            textBox1.ForeColor = Color.White;
            value[i] = double.Parse(textBox1.Text);

            op_pressed = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            for (int k = 0; k <= i; k++)
            {
                value[i] = 0;

            }
            i = 0;
            equation.Text = " ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            enable();
        }
    }
}
