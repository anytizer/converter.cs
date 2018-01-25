using anytizer.converter.numbers.values;
using System;
using System.Windows.Forms;

namespace anytizer.converter.numbers.gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(textBox1.Text);
            label1.Text = value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
