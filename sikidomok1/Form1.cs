using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sikidomok1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_szamol_Click(object sender, EventArgs e)
        {
            num_k.Value = (num_a.Value + num_b.Value) * 2;
            num_t.Value = num_a.Value * num_b.Value;
        }

        private void btn_szamol_kor_Click(object sender, EventArgs e)
        {
            decimal r = num_r.Value;

            decimal k = 2 * r * (decimal)Math.PI;
            decimal t = r * r * (decimal)Math.PI;

            num_kor_k.Value = k;
            num_kor_t.Value = t;
        }

        private void btn_har_szamol_Click(object sender, EventArgs e)
        {
            num_har_k.Value = num_har_a.Value + num_har_b.Value + num_har_c.Value;
            decimal s = num_har_k.Value / 2;
            num_har_t.Value = s * (decimal)Math.Sqrt((double)(s * (s - num_har_a.Value) * (s - num_har_b.Value) * (s * num_har_c.Value)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num_negy_k.Value = 4 * num_negy_a.Value;
            num_negy_t.Value = (decimal)Math.Pow((double)num_negy_a.Value, 2);
        }

        private void btn_hat_szamol_Click(object sender, EventArgs e)
        {
            num_hat_k.Value = 6 * num_hat_a.Value;
            num_hat_t.Value = (decimal)((2 / 3) * Math.Pow((double)num_hat_a.Value, 2) * Math.Sqrt(3));
        }
    }
}
