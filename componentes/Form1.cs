using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace componentes
{
    public partial class frmComponentes : Form
    {
        public frmComponentes()
        {
            InitializeComponent();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNome.Text.Equals(""))
                MessageBox.Show("favor, insira um nome");

            else
            {


                if (e.KeyCode == Keys.Enter)
                {
                    cbbListarNomes.Items.Add(txtNome.Text);
                    txtNome.Clear();
                    txtNome.Focus();

                }
            }
        }

        private void ckbLivros_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLivros.Checked)
            {
                ltbListarProdutos.Items.Add("Livros");
            }
            else
            {
                ltbListarProdutos.Items.Remove(ckbLivros.Text);
            }
        }

        private void ckbComputador_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbComputador.Checked)
            {
                ltbListarProdutos.Items.Add("Computador");
            }
            else
            {
                ltbListarProdutos.Items.Remove(ckbComputador.Text);
            }
        }

        private void ckbMesa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMesa.Checked)
            {
                ltbListarProdutos.Items.Add("Mesa");
            }
            else
            {
                ltbListarProdutos.Items.Remove(ckbMesa.Text);
            }
        }

        private void ckbBanana_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBanana.Checked)
            {
                ltbListarProdutos.Items.Add("Banana");
            }
            else
            {
                ltbListarProdutos.Items.Remove(ckbBanana.Text);
            }
        }
    }
}
