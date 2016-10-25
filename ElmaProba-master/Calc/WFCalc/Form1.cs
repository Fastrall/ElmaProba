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
        private ICalculator calc { get; set; }

        public Form1()
        {
            InitializeComponent();

            calc = new Calculator();

            cbOperation.DataSource = calc.GetOperations();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            var oper = cbOperation.SelectedItem as Operation;

            if (oper == null) {return;}

            var method = typeof(Calculator).GetMethod(oper.Name);

            if (method == null)
            {
                lblResult.Text = "method not found";
                return;
            }

            var x = Convert.ToDouble(tbX.Text);

            var y = Convert.ToDouble(tbY.Text);

            var args = new object[] { x, y };

            if (oper.ParameterCount == 1) { args = new object[] { x };}

            object result;

            try { result = method.Invoke(calc, args);}

            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
                return;
            }

            lblResult.Text = string.Format("Result {0}({1}, {2}) = {3}", oper, x, y, result);
        }
    }
}