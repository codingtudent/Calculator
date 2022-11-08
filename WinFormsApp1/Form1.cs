/*
 * Plexus Calculator Solution
 * Author: Mit Patel
 * 
 * Copyright 2022
 * 
*/

using System.Windows.Forms;
using System.Data;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListBox listBox1 = new ListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {   
            textBox1.Clear();
        }
        private void ButtonComputer_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = new DataTable().Compute(textBox1.Text, null).ToString();
                listBox1.Items.Add(textBox1.Text);
            }
            catch
            {
                textBox1.Text = "error";
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}