using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HammingCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void nudX_ValueChanged(object sender, EventArgs e)
        {
            nudR1.Value = nudC1.Value = nudX1.Value;
            nudR2.Value = nudC2.Value = nudX2.Value;
            nudR3.Value = nudC3.Value = nudX3.Value;
            nudR4.Value = nudC4.Value = nudX4.Value;
            nudR5.Value = nudC5.Value = nudX5.Value;
            nudR6.Value = nudC6.Value = nudX6.Value;
            nudR7.Value = nudC7.Value = nudX7.Value;
            nudR8.Value = nudC8.Value = nudX8.Value;

            decimal E1, E2, E3, E4;
            E1 = (nudX1.Value + nudX3.Value + nudX5.Value + nudX7.Value) % 2;
            E2 = (nudX2.Value + nudX3.Value + nudX6.Value + nudX7.Value) % 2;
            E3 = (nudX4.Value + nudX5.Value + nudX6.Value + nudX7.Value) % 2;
            E4 = (nudX8.Value) % 2;

            nudR9.Value = nudC9.Value = E1;
            nudR10.Value = nudC10.Value = E2;
            nudR11.Value = nudC11.Value = E4;
            nudR12.Value = nudC12.Value = E3;
        }
        private void nudR1_ValueChanged(object sender, EventArgs e)
        {
            decimal E1, E2, E3, E4, n;
            E1 = (nudR1.Value + nudR3.Value + nudR5.Value + nudR7.Value + nudR9.Value) % 2;
            E2 = (nudR2.Value + nudR3.Value + nudR6.Value + nudR7.Value + nudR10.Value) % 2;
            E3 = (nudR4.Value + nudR5.Value + nudR6.Value + nudR7.Value + nudR12.Value) % 2;
            E4 = (nudR8.Value + nudR11.Value) % 2;

            n = E1 + 2 * E2 + 4 * E3 + 8 * E4;
            if (n == 0)
                textBox1.Text = "Ошибок нет";
            if (n > 0 && n <= 8)
                textBox1.Text = string.Format("Ошибка в разряде {0}", n);
            if (n > 8)
                textBox1.Text = "Более одной ошибки, невозможно восстановить информацию";
        }
    }
}