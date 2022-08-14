using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Windows_Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        vector<string> masS = new vector<string>();
        vector<string> masS1;
        private void button1_Click(object sender, EventArgs e)
        {            
        }
        private void button2_Click(object sender, EventArgs e)
        {          
        }
        private void button3_Click(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {   
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (masS.Length != 0)
                masS.clear();
            int n = int.Parse(textBox1.Text);
            masS = Utilities<string>.RandomString(n);
            masS1 = Utilities<string>.Copy(masS);
            textBox2.Text = masS.masToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            QuickSort<string> sortQuick = new QuickSort<string>();
            masS1 = Utilities<string>.Copy(masS);
            vector<string> sorted = Utilities<string>.SortVar(masS1, sortQuick);
            textBox3.Text = sorted.masToString();
            textBox5.Text = sortQuick.shift1.ToString();
            textBox7.Text = sortQuick.comparison1.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            BinarySort<string> sortBin = new BinarySort<string>();
            masS1 = Utilities<string>.Copy(masS);
            vector<string> sorted = Utilities<string>.SortVar(masS1, sortBin);
            textBox4.Text = sorted.masToString();
            textBox6.Text = sortBin.shift.ToString();
            textBox8.Text = sortBin.comparison.ToString();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
