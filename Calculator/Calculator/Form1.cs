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
        string operation = "";
        double result_value = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

        private void operation_performed(object sender, EventArgs e)
        {
            
            

            Button btn = (Button)sender;
            btn.Text = operation;
            result_value = double.Parse(textBox1.Text);
            label1.Text = result_value + operation;
        }

        private void ce_clicked(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void c_clicked(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void equal_clicked(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    textBox1.Text = (result_value + double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }
    }
}
