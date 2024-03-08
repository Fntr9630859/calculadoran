using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculadora
{
    public partial class form1 : Form
    {
        double nant = 0;
        char tecant, opAnt = 'n';
        public form1()
        {
            InitializeComponent();
        }

        private void btnn0_Click(object sender, EventArgs e)
        {
            if (dysplay.Text == "0" || tecant == 'o')
            {
                dysplay.Text = "0";
            }
            else
            {
                dysplay.Text = dysplay.Text + "0";
            }
            tecant = 'n';
        }
        private void btnn1_Click(object sender, EventArgs e)
        {
            if (dysplay.Text == "0" || tecant == 'o')
            {
                dysplay.Text = "1";
            }
            else
            {
                dysplay.Text = dysplay.Text + "1";
            }
            tecant = 'n';
        }
        private void btnn2_Click(object sender, EventArgs e)
        {
            if (dysplay.Text == "0" || tecant == 'o')
            {
                dysplay.Text = "2";
            }
            else
            {
                dysplay.Text = dysplay.Text + "2";
            }
            tecant = 'n';
        }
        private void btnn3_Click(object sender, EventArgs e)
        {
            if (dysplay.Text == "0" || tecant == 'o')
            {
                dysplay.Text = "3";
            }
            else
            {
                dysplay.Text = dysplay.Text + "3";
            }
            tecant = 'n';
        }
        private void btnn4_Click(object sender, EventArgs e)
        {
            if (dysplay.Text == "0" || tecant == 'o')
            {
                dysplay.Text = "4";
            }
            else
            {
                dysplay.Text = dysplay.Text + "4";
            }
            tecant = 'n';
        }
        private void btnn5_Click(object sender, EventArgs e)
        {
            if (dysplay.Text == "0" || tecant == 'o')
            {
                dysplay.Text = "5";
            }
            else
            {
                dysplay.Text = dysplay.Text + "5";
            }
            tecant = 'n';
        }
        private void btnn6_Click(object sender, EventArgs e)
        {
            if (dysplay.Text == "0" || tecant == 'o')
            {
                dysplay.Text = "6";
            }
            else
            {
                dysplay.Text = dysplay.Text + "6";
            }
            tecant = 'n';
        }
        private void btnn7_Click(object sender, EventArgs e)
        {
            if (dysplay.Text == "0" || tecant == 'o')
            {
                dysplay.Text = "7";
            }
            else
            {
                dysplay.Text = dysplay.Text + "7";
            }
            tecant = 'n';
        }
        private void btnn8_Click(object sender, EventArgs e)
        {
            if (dysplay.Text == "0" || tecant == 'o')
            {
                dysplay.Text = "8";
            }
            else
            {
                dysplay.Text = dysplay.Text + "8";
            }
            tecant = 'n';
        }
        private void btnn9_Click(object sender, EventArgs e)
        {
            if (dysplay.Text == "0" || tecant == 'o')
            {
                dysplay.Text = "9";
            }
            else
            {
                dysplay.Text = dysplay.Text + "9";
            }
            tecant = 'n';
        }
        private void btnmas_Click(object sender, EventArgs e)
        {
            tecant = 'o';
            btnpunto.Enabled = true;

            if (opAnt == 'n')
            {
                nant = Convert.ToDouble(dysplay.Text);
            }
            else
            {
                dysplay.Text = Convert.ToString(operaciones());
                nant = Convert.ToDouble(dysplay.Text);
            }
            opAnt = '+';
        }
        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (tecant == 'o')
            {
                dysplay.Text = "0";
            }
            dysplay.Text = dysplay.Text + ".";
            btnpunto.Enabled = false;
            tecant = 'n';
        }
        private void btnrealizar_Click(object sender, EventArgs e)
        {
            tecant = 'o';
            btnpunto.Enabled = true;

            if (opAnt == 'n')
            {
                nant = Convert.ToDouble(dysplay.Text);
            }
            else
            {
                dysplay.Text = Convert.ToString(operaciones());
                nant = Convert.ToDouble(dysplay.Text);
            }
            opAnt = 'n';
            tecant = 'o';
            nant = 0;
        }
        private void btnres_Click(object sender, EventArgs e)
        {
            tecant = 'o';
            btnpunto.Enabled = true;

            if (opAnt == 'n')
            {
                nant = Convert.ToDouble(dysplay.Text);
            }
            else
            {
                dysplay.Text = Convert.ToString(operaciones());
                nant = Convert.ToDouble(dysplay.Text);
            }
            opAnt = '-';
        }
        private void btndiv_Click(object sender, EventArgs e)
        {
            tecant = 'o';
            btnpunto.Enabled = true;

            if (opAnt == 'n')
            {
                nant = Convert.ToDouble(dysplay.Text);
            }
            else
            {
                dysplay.Text = Convert.ToString(operaciones());
                nant = Convert.ToDouble(dysplay.Text);
            }
            opAnt = '/';
        }
        private void btnmul_Click(object sender, EventArgs e)
        {
            tecant = 'o';
            btnpunto.Enabled = true;

            if (opAnt == 'n')
            {
                nant = Convert.ToDouble(dysplay.Text);
            }
            else
            {
                dysplay.Text = Convert.ToString(operaciones());
                nant = Convert.ToDouble(dysplay.Text);
            }
            opAnt = '*';
        }
        private void btnborrar_Click(object sender, EventArgs e)
        {
            opAnt = 'n';
            nant = 0;
            tecant = 'n';
            dysplay.Text = "0";
            btnpunto.Enabled = true;
        }

        private double operaciones()
        {
            double res = 0;
            switch (opAnt)
            {
                case '+':
                    res = nant + Convert.ToDouble(dysplay.Text);
                    break;
                case '-':
                    res = nant - Convert.ToDouble(dysplay.Text);
                    break;
                case '*':
                    res = nant * Convert.ToDouble(dysplay.Text);
                    break;
                case '/':
                    res = nant / Convert.ToDouble(dysplay.Text);
                    break;
            }
            return res;
        }
    }
}
