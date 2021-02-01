using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form3 : Form
    {
        long num;
        double evalu;
        double[] value = new double[100];
        string[] operation = new string[100];
        bool op_pressed = false;
        int i = 0;
        public Form3()
        {
            InitializeComponent();
        }
        long decimalToBinary(long num)
        {
            long remender, binary = 0, i = 1;
            while (num > 0)
            {
                remender = num % 2;
                num = num / 2;
                binary = binary + (remender * i);
                i = i * 10;
            }
            return binary;
        }

        long reverse(long num)
        {
            long rev = 0;
            while (num != 0)
            {
                rev *= 10;
                rev += num % 10;
                num = num / 10;
            }
            return rev;

        }
        double cube(long num)
        {

            double result;
            result = num * num * num;
            return result;
        }

        double Square(long num)
        {

            double result;
            result = num * num;
            return result;
        }
        bool CheckEvenOrOdd(double num)
        {
            if (num % 2 == 0)
                return true;
            return false;
        }
        bool prime(long num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }

            }
            return true;
        }
        long Factorial(long num)
        {
            long fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }

            return fact;
        }
        bool perfect(double num)
        {
            long sum = 0;
            for (int i = 0; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == num)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            button27.Enabled = false;
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
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button28.Enabled = true;


        }

        private void operator_click(object sender, EventArgs e)
        {
            Button c = (Button)sender;
            textBox1.ForeColor = Color.White;
            operation[i] = c.Text;
            op_pressed = true;
            equation2.Text = equation2.Text + " " + value[i] + " " + operation[i];
            i++;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            equation2.Text = " ";
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

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            for (int k = 0; k <= i; k++)
            {
                value[i] = 0;

            }
            i = 0;
            equation2.Text = " ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            enable();
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

        private void button_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || (op_pressed == true))
            {
                textBox1.Clear();
            }
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
            textBox1.ForeColor = Color.White;
            if (textBox1.Text == ".")
            {
                textBox1.Text = "0.";
            }
            value[i] = double.Parse(textBox1.Text);

            op_pressed = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            long num;
            num = long.Parse(textBox1.Text);
            textBox1.ForeColor = Color.White;
            if (prime(num))
            {
                textBox1.Text = System.Convert.ToString("Prime");
            }
            else
            {
                textBox1.Text = System.Convert.ToString("Not Prime");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            long number = long.Parse(textBox1.Text);
            long fact;
            textBox1.ForeColor = Color.White;
            fact = Factorial(number);
            textBox1.Text = System.Convert.ToString(fact);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            long num = long.Parse(textBox1.Text);
            long bin;
            textBox1.ForeColor = Color.White;
            bin = decimalToBinary(num);
            textBox1.Text = System.Convert.ToString(bin);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double num;
            bool res;
            textBox1.ForeColor = Color.White;
            num = double.Parse(textBox1.Text);
            res = CheckEvenOrOdd(num);
            if (res == true)
            {
                textBox1.Text = System.Convert.ToString("Even Number");
            }
            else
            {
                textBox1.Text = System.Convert.ToString("Odd Number");

            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            long number;
            textBox1.ForeColor = Color.White;
            double squar_result;
            number = long.Parse(textBox1.Text);
            squar_result = Square(number);
            textBox1.Text = System.Convert.ToString(squar_result);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            long number;
            textBox1.ForeColor = Color.White;
            double cube_result;
            number = long.Parse(textBox1.Text);
            cube_result = cube(number);
            textBox1.Text = System.Convert.ToString(cube_result);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            long num = long.Parse(textBox1.Text);
            long rev;
            textBox1.ForeColor = Color.White;
            rev = reverse(num);
            textBox1.Text = System.Convert.ToString(rev);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double num;
            bool res;
            textBox1.ForeColor = Color.White;
            num = double.Parse(textBox1.Text);
            res = perfect(num);
            if (res == true)
            {
                textBox1.Text = System.Convert.ToString("Number is Perfect");
            }
            else
            {
                textBox1.Text = System.Convert.ToString("Number is Not Perfect");
            }
        }
    }
}
