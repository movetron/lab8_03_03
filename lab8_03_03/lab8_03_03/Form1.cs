using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8_03_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public long Factorial(int n)
        {
            long p = 1;
            for (int i = 1; i <= n; i++)
                p = p * i;
            return p;
        }
        private void txtFactorial_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int numb;
            if (int.TryParse(txtN.Text, out numb))
            {
                txtFactorial.Text = Factorial(numb).ToString();

            }
            else
                MessageBox.Show("Введите число");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            txtN.Text = null; txtFactorial = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
