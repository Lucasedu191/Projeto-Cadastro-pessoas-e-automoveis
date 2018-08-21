using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModulo01parte02
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void btnChamaVeiculos_Click(object sender, EventArgs e)
        {
            FrmCadVeiculos form = new FrmCadVeiculos();
            form.MdiParent = this;
            form.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirCadPessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadPessoas form = new FrmCadPessoas();
            form.MdiParent = this;
            form.Show();
        }

        private void abrirCadVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadVeiculos form = new FrmCadVeiculos();
            form.MdiParent = this;
            form.Show();
        }
    }
}
