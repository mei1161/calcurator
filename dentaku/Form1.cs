using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentaku
{
    public partial class Form1 : Form
    {
        private string input_str;
        string input_str2;
        string Operator = null;
        int num1;
        int num2;
        string formula = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check_operator(button1.Text);
            make_fomula(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            check_operator(button2.Text);
            make_fomula(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            check_operator(button3.Text);
            make_fomula(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            check_operator(button4.Text);
            make_fomula(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            check_operator(button5.Text);
            make_fomula(button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            check_operator(button6.Text);
            make_fomula(button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            check_operator(button7.Text);
            make_fomula(button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            check_operator(button8.Text);
            make_fomula(button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            check_operator(button9.Text);
            make_fomula(button9.Text);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            check_operator(button0.Text);
            make_fomula(button0.Text);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            input_str = "";
            Operator = null;
            num2 = 0;
            input_str2 = "";
            num1 = 0;
            formula = null;
            textBox2.Text = null;

        }
        private void calucurate()
        {
            switch (Operator)
            {
                case "+":
                    num1 += num2;
                    break;
                case "-":
                    num1 -= num2;
                    break;
                case "*":
                    num1 *= num2;
                    break;
                case "/":
                    num1 /= num2;
                    break;
            }
            input_str = num1.ToString();
            input_str2 = "";
            Operator = null;
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if (input_str2 != null && Operator != null && int.TryParse(input_str2, out num2))
            {
                make_before_fomula();
                textBox2.Text = formula;
                calucurate();
                textBox1.Text = input_str;
            }
            assign_to_num1(button_plus.Text);
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (input_str2 != null && Operator != null && int.TryParse(input_str2, out num2))
            {
                make_before_fomula();
                textBox2.Text = formula;
                calucurate();
                textBox1.Text = input_str;
            }
            assign_to_num1(button_minus.Text);
        }

        private void button_multi_Click(object sender, EventArgs e)
        {
            if (input_str2 != null && Operator != null && int.TryParse(input_str2, out num2))
            {
                make_before_fomula();
                textBox2.Text = formula;
                calucurate();
                textBox1.Text = input_str;
            }
            assign_to_num1(button_multi.Text);
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            if (input_str2 != null && Operator != null && int.TryParse(input_str2, out num2))
            {
                make_before_fomula();
                textBox2.Text = formula;
                calucurate();
                textBox1.Text = input_str;
            }
            assign_to_num1(button_div.Text);

        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            if(int.TryParse(input_str2,out num2))
            {
                make_before_fomula();
                textBox2.Text = formula;
                calucurate();
                textBox1.Text = input_str;
            }

        }

        private void make_before_fomula()
        {
            formula = input_str + Operator + input_str2;
        }

        private void make_fomula(String num)
        {
            if (Operator == null)
            {
                input_str += num;
                textBox1.Text = input_str;
            }
            else
            { 
                input_str2 += num;
                textBox1.Text = input_str + Operator + input_str2;
            }
        }

        private void assign_to_num1(String op)
        {
            if (int.TryParse(input_str, out num1))
            {
                Operator = op;
                textBox1.Text += Operator;
            }
        }
        //条件が、上のテキストボックスに文字列がある状態で、Operatorがない状態で分岐、num1をから文字列にして、入力されている文字をnum1に代入
        private void check_operator(String num)
        {
            if(textBox2.Text != "" && Operator == null)
            {
                num1 = 0;
                input_str = "";
                textBox2.Text = "";
            }
        }
    }
}
