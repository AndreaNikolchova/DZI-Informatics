using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._4._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static List<int> numbers = new List<int>();
        public static int count = 1;
        public static int N;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            Count.Enabled = false;
            N = int.Parse(Count.Text);
            for (int i = 0; i < 100; i++)
            {
                numbers.Add(i + 1);
            }
            textBox1.Text = numbers[numbers.Count / 2 - 1].ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                numbers.RemoveRange(0, numbers.Count / 2 - 1);
                Print();
                return;
            }
            YouWon();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                numbers.RemoveRange(numbers.Count / 2, numbers.Count / 2);
                Print();
                return;
            }
            YouWon();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (count != int.Parse(Count.Text) + 1)
            {
                IWon();
                return;
            }
            YouWon();
        }
        private bool Check() => count != N;
        private void YouWon()
        {
            label4.Text = "Ти спечели";
            textBox1.Enabled = true;
            Count.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            textBox1.Text = String.Empty;
            Count.Text = String.Empty;
            numbers.Clear();
        }
        private void IWon()
        {
            label4.Text = "Аз спечелих";
            textBox1.Enabled = true;
            Count.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            textBox1.Text = String.Empty;
            Count.Text = String.Empty;
            numbers.Clear();
        }
        private void Print()
        {
            textBox1.Text = numbers[numbers.Count / 2].ToString();
            count++;
        }
    }
}

