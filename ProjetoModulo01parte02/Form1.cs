using System;
using System.Windows.Forms;

namespace ProjetoModulo01parte02
{
    public partial class FrmCadPessoas : Form
    {
        public FrmCadPessoas()
        {
            InitializeComponent();
        }

        private void frmCadPessoas_Load(object sender, EventArgs e)
        {
            Text = "Novo Tiítulo";
        }

        private void frmCadPessoas_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmCadPessoas_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnChamaOutroForm_Click(object sender, EventArgs e)
        {
            FrmCadVeiculos form = new FrmCadVeiculos();
            form.strPlaca = TxtboxPlaca.Text.Trim();
            form.Text = "Cadastro de veículos";
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new System.Drawing.Point(200, 200);
            form.ShowDialog();
            txtResposta.Text = form.txtReposta.Text;

   
        }
    }
}
