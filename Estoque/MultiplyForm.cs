using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    public partial class MultiplyForm : Form
    {
        public MultiplyForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            label1.Text = "clique para acessar";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToInt32(txtNumber1.Text);
            var number2 = Convert.ToInt32(txtNumber2.Text);
            var result = number1 * number2;
            label1.Text = result.ToString();
        }
    }
}
