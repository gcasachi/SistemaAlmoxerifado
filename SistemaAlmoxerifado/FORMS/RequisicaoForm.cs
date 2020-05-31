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

            CAMADAS.BLL.Almoxarifado bllAlmoxarifado = new CAMADAS.BLL.Almoxarifado();
            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = bllAlmoxarifado.Select();

            CAMADAS.BLL.Requisicao bllRequisicao = new CAMADAS.BLL.Requisicao();
            dgvRequisicoes.DataSource = "";
            dgvRequisicoes.DataSource = bllRequisicao.Select();

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
            CAMADAS.BLL.Setor bllSetor = new CAMADAS.BLL.Setor();
            cbSetor.DisplayMember = "nome";
            cbSetor.ValueMember = "id";
            cbSetor.DataSource = bllSetor.Select();

            habilitaControles(true);
            limpaControles();

            lblID.Text = "-1";
            cbSetor.Focus();
            txtData.Text = DateTime.Now.ToString();
        }

        private void dgvRequisicaoItens_DoubleClick(object sender, EventArgs e) {
            txtIDProduto.Text = dgvProdutos.SelectedRows[0].Cells["id"].Value.ToString();
            txtNomeProduto.Text = dgvProdutos.SelectedRows[0].Cells["nome"].Value.ToString();
            txtQuantidadeProduto.Text = dgvProdutos.SelectedRows[0].Cells["quantidade"].Value.ToString();
        }

        private void btnGravar_Click(object sender, EventArgs e) {
            int quantidadeRequisitada = Convert.ToInt32(txtQuantidadeRequisitada.Text);
            int quantidadeEstoque = Convert.ToInt32(txtQuantidadeProduto.Text);

            string mensagem = "";
            string tituloMensagem = "";

            if (quantidadeRequisitada <= quantidadeEstoque) {
                CAMADAS.BLL.Requisicao bllRequisicao = new CAMADAS.BLL.Requisicao();

                if (lblID.Text == "-1") {
                    mensagem = "Deseja criar uma nova requisição?";
                    tituloMensagem = "Criar Requisição";
                }
                else {
                    mensagem = "Deseja alterar a requisição?";
                    tituloMensagem = "Atualizar";
                }

                DialogResult resposta = MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (resposta == DialogResult.Yes) {
                    CAMADAS.MODEL.Requisicao requisicao = new CAMADAS.MODEL.Requisicao();

                    requisicao.id = Convert.ToInt32(lblID.Text);
                    requisicao.setorID = Convert.ToInt32(txtIDSetor.Text);
                    requisicao.produtoID = Convert.ToInt32(txtIDProduto.Text);
                    requisicao.quantidade = Convert.ToInt32(txtQuantidadeRequisitada.Text);
                    requisicao.data = DateTime.Now;

                    CAMADAS.MODEL.Almoxarifado almoxarifado = new CAMADAS.MODEL.Almoxarifado();
                    almoxarifado.id = Convert.ToInt32(txtIDProduto.Text);
                    almoxarifado.quantidade = quantidadeEstoque - quantidadeRequisitada;

                    CAMADAS.BLL.Almoxarifado bllAtualizaEstoqueItem = new CAMADAS.BLL.Almoxarifado();
                    bllAtualizaEstoqueItem.Update(almoxarifado);

                    if (lblID.Text == "-1") {
                        bllRequisicao.Insert(requisicao);
                    }
                    else {
                        bllRequisicao.Update(requisicao);
                    }
                }

                limpaControles();
                habilitaControles(false);

                dgvProdutos.DataSource = "";
                dgvProdutos.DataSource = new CAMADAS.BLL.Almoxarifado().Select();
                dgvRequisicoes.DataSource = "";
                dgvRequisicoes.DataSource = bllRequisicao.Select();
            }

            else {
                mensagem = "A quantidade requisitada excede o estoque!";
                tituloMensagem = "Erro";

                MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRequisicoes_DoubleClick(object sender, EventArgs e) {
            lblID.Text = dgvRequisicoes.SelectedRows[0].Cells["id"].Value.ToString();
            txtIDSetor.Text = dgvRequisicoes.SelectedRows[0].Cells["setorID"].Value.ToString();
            txtIDProduto.Text = dgvRequisicoes.SelectedRows[0].Cells["produtoID"].Value.ToString();
            txtQuantidadeRequisitada.Text = dgvRequisicoes.SelectedRows[0].Cells["quantidade"].Value.ToString();
            txtData.Text = dgvRequisicoes.SelectedRows[0].Cells["data"].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            if (lblID.Text != "") {
                habilitaControles(true);
                txtQuantidadeRequisitada.Focus();
            }
            else {
                MessageBox.Show("Não há dados para Editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e) {
            CAMADAS.BLL.Requisicao bllRequisicao = new CAMADAS.BLL.Requisicao();

            string mensagem = "Não há dados selecionado para remover";
            string tituloMensagem = "Remover";

            if (lblID.Text != "") {
                mensagem = "Deseja remover a Requisição: " + lblID.Text + "?";
                DialogResult resposta = MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (resposta == DialogResult.Yes) {
                    CAMADAS.MODEL.Almoxarifado almoxarifado = new CAMADAS.MODEL.Almoxarifado();
                    almoxarifado.id = Convert.ToInt32(txtIDProduto.Text);

                    int quantidadeEstoque = new CAMADAS.BLL.Almoxarifado().SelectByID(almoxarifado.id);
                    int quantidadeRequisitada = Convert.ToInt32(txtQuantidadeRequisitada.Text);

                    almoxarifado.quantidade = quantidadeEstoque + quantidadeRequisitada;

                    CAMADAS.BLL.Almoxarifado bllAtualizaEstoqueItem = new CAMADAS.BLL.Almoxarifado();
                    bllAtualizaEstoqueItem.Update(almoxarifado);

                    int idRemocao = Convert.ToInt32(lblID.Text);
                    bllRequisicao.Delete(idRemocao);
                }
            }
            else {
                MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            limpaControles();

            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = new CAMADAS.BLL.Almoxarifado().Select();
            dgvRequisicoes.DataSource = "";
            dgvRequisicoes.DataSource = bllRequisicao.Select();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            limpaControles();
            habilitaControles(false);
        }

        private void btnVoltar_Click(object sender, EventArgs e) {
            this.Dispose();
        }
    }
}
