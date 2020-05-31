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
    public partial class AlmoxarifadoForm : Form {
        public AlmoxarifadoForm() {
            InitializeComponent();
        }

        private void AlmoxarifadoForm_Load(object sender, EventArgs e) {
            CAMADAS.BLL.Fornecedor bllFornecedor = new CAMADAS.BLL.Fornecedor();
            cbFornecedor.DisplayMember = "nome";
            cbFornecedor.ValueMember = "id";
            cbFornecedor.DataSource = bllFornecedor.Select();

            CAMADAS.BLL.Almoxarifado bllAlmo = new CAMADAS.BLL.Almoxarifado();
            dgvItens.DataSource = "";
            dgvItens.DataSource = bllAlmo.Select();

            habilitaControles(false);

        }

        public void habilitaControles(bool status) {
            cbFornecedor.Enabled = status;
            txtFornecedor.Enabled = status;
            txtItem.Enabled = status;
            txtQuantidade.Enabled = status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;
            btnNovo.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
        }

        public void limpaControles() {
            lblID.Text = "";
            txtFornecedor.Text = "";
            txtItem.Text = "";
            txtQuantidade.Text = "";
        }

        private void btnNovo_Click(object sender, EventArgs e) {
            habilitaControles(true);
            limpaControles();

            lblID.Text = "-1";
            cbFornecedor.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            if (lblID.Text != "") {
                habilitaControles(true);
                cbFornecedor.Focus();
            }
            else {
                MessageBox.Show("Não há dados para Editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            limpaControles();
            habilitaControles(false);
        }

        private void btnGravar_Click(object sender, EventArgs e) {
            CAMADAS.BLL.Almoxarifado bllAlmo = new CAMADAS.BLL.Almoxarifado();
            string msg = "";
            string titMsg = "";
            if (lblID.Text == "-1") {
                msg = "Deseja Inserir novo Item?";
                titMsg = "Inserir";
            }
            else {
                msg = "Deseja Alterar o Item?";
                titMsg = "Atualizar";
            }

            DialogResult resposta = MessageBox.Show(msg, titMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resposta == DialogResult.Yes) {
                CAMADAS.MODEL.Almoxarifado almoxarifado = new CAMADAS.MODEL.Almoxarifado();
                almoxarifado.idProduto = Convert.ToInt32(lblID.Text);
                almoxarifado.fornecedorID = Convert.ToInt32(txtFornecedor.Text);
                almoxarifado.nome = txtItem.Text;
                almoxarifado.quantidade = Convert.ToInt32(txtQuantidade.Text);

                if (lblID.Text == "-1") {
                    bllAlmo.Insert(almoxarifado);
                }
                else {
                    bllAlmo.Update(almoxarifado);
                }
            }

            limpaControles();
            habilitaControles(false);
            dgvItens.DataSource = "";
            dgvItens.DataSource = bllAlmo.Select();
        }

        private void cbFornecedor_SelectedIndexChanged(object sender, EventArgs e) {
            txtFornecedor.Text = cbFornecedor.SelectedValue.ToString();
        }

        private void txtFornecedor_Leave(object sender, EventArgs e) {
            try {
                if(txtFornecedor.Text != "") {
                    cbFornecedor.SelectedValue = Convert.ToInt32(txtFornecedor.Text);
                }
            }
            catch {
                MessageBox.Show("Cliente Invalido");
                cbFornecedor.Focus();
            }
        }

        private void cbFornecedor_Leave(object sender, EventArgs e) {
            try {
                cbFornecedor_SelectedIndexChanged(null, null);
            }
            catch {
                MessageBox.Show("Informe um Cliente");
                cbFornecedor.Focus();
            }
            
        }

        private void dgvItens_DoubleClick(object sender, EventArgs e) {
            lblID.Text = dgvItens.SelectedRows[0].Cells["idProduto"].Value.ToString();
            cbFornecedor.SelectedValue = Convert.ToInt32(dgvItens.SelectedRows[0].Cells["fornecedorID"].Value.ToString());
            txtFornecedor.Text = dgvItens.SelectedRows[0].Cells["fornecedorID"].Value.ToString();
            txtItem.Text = dgvItens.SelectedRows[0].Cells["nome"].Value.ToString();
            txtQuantidade.Text = dgvItens.SelectedRows[0].Cells["quantidade"].Value.ToString();

        }
    }
}
