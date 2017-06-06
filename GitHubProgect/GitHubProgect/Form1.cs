using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubProgect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void S_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(Num1.Value);
            int n2 = Convert.ToInt16(Num2.Value);
            int rezult = Processing.Summa(n1, n2);
            Rez.Text = rezult.ToString();
        }

        private void R_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(Num1.Value);
            int n2 = Convert.ToInt16(Num2.Value);
            int rezult = Processing.Minus(n1, n2);
            Rez.Text = rezult.ToString();
        }

        private void U_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(Num1.Value);
            int n2 = Convert.ToInt16(Num2.Value);
            int rezult = Processing.Umnogit(n1, n2);
            Rez.Text = rezult.ToString();
        }

        private void D_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(Num1.Value);
            int n2 = Convert.ToInt16(Num2.Value);
            double rezult = Processing.Delit(n1, n2);
            if (rezult != 0)
            {
                Rez.Text = rezult.ToString();
            }
            else
            {
                MessageBox.Show("Делить а 0 нельзя!", "Деление на 0", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
