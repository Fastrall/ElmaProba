using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calc;

namespace WFCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            var calc = new Calculator();

            var x = Convert.ToDouble(tbX.Text);

            var y = Convert.ToDouble(tbY.Text);

            var oper = cbOperation.SelectedItem.ToString();

            var typeCalc = typeof(Calculator);

            var method = typeCalc.GetMethod(oper);

            var result = method.Invoke(calc, new object[] {x, y});

            lblResult.Text = string.Format("Result {0}({1}, {2}) = {3}", oper, x, y, result);
        }
    }
}
