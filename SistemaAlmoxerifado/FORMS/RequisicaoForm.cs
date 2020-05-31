using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAlmoxerifado.FORMS {
    public partial class RequisicaoForm : Form {
        public RequisicaoForm() {
            InitializeComponent();
        }

        private void RequisicaoForm_Load(object sender, EventArgs e) {
            txtNomeProduto.Enabled = false;
            txtIDProduto.Enabled = false;
            txtQuantidadeProduto.Enabled = false;
            txtData.Enabled = false;

            CAMADAS.BLL.Setor bllSetor = new CAMADAS.BLL.Setor();
            cbSetor.DisplayMember = "nome";
            cbSetor.ValueMember = "id";
            cbSetor.DataSource = bllSetor.Select();

            CAMADAS.BLL.Almoxarifado bllAlmoxarifado = new CAMADAS.BLL.Almoxarifado();
            dgvRequisicaoItens.DataSource = "";
            dgvRequisicaoItens.DataSource = bllAlmoxarifado.Select();

            habilitaControles(false);
        }

        public void habilitaControles(bool status) {
            cbSetor.Enabled = status;
            txtIDSetor.Enabled = status;
            txtQuantidadeRequisitada.Enabled = status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;
            btnNovo.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
        }

        public void limpaControles() {
            lblID.Text = "";
            cbSetor.Text = "";
            txtIDSetor.Text = "";
            txtNomeProduto.Text = "";
            txtIDProduto.Text = "";
            txtQuantidadeProduto.Text = "";
            txtQuantidadeRequisitada.Text = "";
            txtData.Text = "";
        }

        private void cbSetor_SelectedIndexChanged(object sender, EventArgs e) {
            txtIDSetor.Text = cbSetor.SelectedValue.ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e) {
            habilitaControles(true);
            limpaControles();

            lblID.Text = "-1";
            cbSetor.Focus();
            txtData.Text = DateTime.Now.ToString();
        }

        private void dgvRequisicaoItens_DoubleClick(object sender, EventArgs e) {
            txtIDProduto.Text = dgvRequisicaoItens.SelectedRows[0].Cells["id"].Value.ToString();
            txtNomeProduto.Text = dgvRequisicaoItens.SelectedRows[0].Cells["nome"].Value.ToString();
            txtQuantidadeProduto.Text = dgvRequisicaoItens.SelectedRows[0].Cells["quantidade"].Value.ToString();
        }
    }
}
