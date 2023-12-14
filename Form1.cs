using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX3WF
{
    public partial class Diagonal : Form
    {
        public Diagonal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Quadrado d;
            d = new Quadrado();

            d.setDiagonal(double.Parse(txtDiagonal.Text));
            txtResultado.Text = d.CalcularArea().ToString();
        }
    }
}
