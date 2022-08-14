using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        vector<double> masD = new vector<double>();
        vector<double> masD1;

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (masD.Length != 0)
                masD.clear();

            int n = int.Parse(textBox1.Text);
            int min = int.Parse(textBox2.Text);
            int max = int.Parse(textBox3.Text);

            masD = Utilities<double>.RandomDouble(n, min, max);
            masD1 = Utilities<double>.Copy(masD);
            textBox4.Text = masD.masToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            QuickSort<double> sortQuick = new QuickSort<double>();
            masD1 = Utilities<double>.Copy(masD);
            vector<double> sorted = Utilities<double>.SortVar(masD1, sortQuick);
            textBox9.Text = sorted.masToString();
            textBox6.Text = sortQuick.shift1.ToString();
            textBox8.Text = sortQuick.comparison1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BinarySort<double> sortBin = new BinarySort<double>();
            masD1 = Utilities<double>.Copy(masD);
            vector<double> sorted = Utilities<double>.SortVar(masD1, sortBin);
            textBox10.Text = sorted.masToString();
            textBox7.Text = sortBin.shift.ToString();
            textBox5.Text = sortBin.comparison.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
