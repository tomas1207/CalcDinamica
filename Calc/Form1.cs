using System;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        int n1, n2;
        string sinalMain;
        public Form1()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            label1.Text += btn.Text;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            n2 = int.Parse(label1.Text);
            Calcula calcula = new Calcula();
            label1.Text = calcula.makeaccoutns(n1, n2, sinalMain).ToString();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            var sinal = sender as Button;
            sinalMain = sinal.Text;
            n1 = int.Parse(label1.Text);
            label1.Text = "";
        }
    }
}
