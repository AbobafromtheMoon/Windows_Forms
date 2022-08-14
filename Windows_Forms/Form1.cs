using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        vector<int> masI = new vector<int>();
        vector<int> masI1;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (masI.Length != 0)
                masI.clear();

            int n = int.Parse(textBox1.Text);
            int min = int.Parse(textBox2.Text);
            int max = int.Parse(textBox3.Text);

            masI = Utilities<int>.RandomInt(n, min, max);
            textBox4.Text = masI.masToString();

        }
        private void button4_Click(object sender, EventArgs e)
        {
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            QuickSort<int> sortQuick = new QuickSort<int>();
            masI1 = Utilities<int>.Copy(masI);
            vector<int> sorted = Utilities<int>.SortVar(masI1, sortQuick);
            textBox5.Text = sorted.masToString();
            textBox6.Text = sortQuick.shift1.ToString();
            textBox8.Text = sortQuick.comparison1.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            BinarySort<int> sortBin = new BinarySort<int>();
            masI1 = Utilities<int>.Copy(masI);
            vector<int> sorted = Utilities<int>.SortVar(masI1, sortBin);
            textBox7.Text = sorted.masToString();
            textBox10.Text = sortBin.shift.ToString();
            textBox9.Text = sortBin.comparison.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}