using System;
using System.Windows.Forms;
using Vector.Logic;

namespace VectorWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = txtV1x;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculo_Click(object sender, EventArgs e)
        {
            var vec1 = new Vector.Logic.Vector(new double[] { Convert.ToDouble(txtV1x.Text), Convert.ToDouble(txtV1y.Text) });
            var vec2 = new Vector.Logic.Vector(new double[] { Convert.ToDouble(txtV2x.Text), Convert.ToDouble(txtV2y.Text) });

            var suma = vec1.Suma(vec2);
            SumaRes.Text = $"({suma.nVec[0]}, {suma.nVec[1]})";

            var resta = vec1.Resta(vec2);
            RestaRes.Text = $"({resta.nVec[0]}, {resta.nVec[1]})";

            var mult = vec1.Mult(vec2);
            MultRes.Text = $"({mult.nVec[0]}, {mult.nVec[1]})";

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txtV1x.Clear();
            txtV1y.Clear();
            txtV2x.Clear();
            txtV2y.Clear();
            txtV1x.Focus();
        }

        private void txtV1x_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtV1x_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void txtV1y_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void txtV2x_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void txtV2y_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtV2y_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}