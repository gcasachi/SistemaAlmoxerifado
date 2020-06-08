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
    public partial class FornecedorForm : Form {
        public FornecedorForm() {
            InitializeComponent();
        }

        private void FornecedorForm_Load(object sender, EventArgs e) {
            CAMADAS.BLL.Fornecedor bllFornecedor = new CAMADAS.BLL.Fornecedor();
            dgvFornecedor.DataSource = "";
            dgvFornecedor.DataSource = bllFornecedor.Select();
            habilitaControles(false);

        }

        public void habilitaControles(bool status) {
            txtNome.Enabled = status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;
            btnNovo.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
        }

        public void limpaControles() {
            lblID.Text = "";
            txtNome.Text = "";
        }

        private void btnNovo_Click(object sender, EventArgs e) {
            limpaControles();
            habilitaControles(true);

            lblID.Text = "-1";
            txtNome.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            if (lblID.Text != "") {
                habilitaControles(true);
                txtNome.Focus();
            }
            else {
                MessageBox.Show("Não há fornecedor selecionado para editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            limpaControles();
            habilitaControles(false);
        }

        private void btnRemover_Click(object sender, EventArgs e) {
            CAMADAS.BLL.Fornecedor bllFornecedor = new CAMADAS.BLL.Fornecedor();

            string msg = "Não há dados selecionado para remover";
            string titBox = "Erro";                

            if (lblID.Text != "") {
                msg = "Deseja Remover o Fornecedor: " + txtNome.Text + "?";
                titBox = "Remover";
                DialogResult resposta = MessageBox.Show(msg, titBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (resposta == DialogResult.Yes) {
                    int id = Convert.ToInt32(lblID.Text);
                    bllFornecedor.Delete(id);
                }
            }
            else {
                MessageBox.Show(msg, titBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            limpaControles();
            dgvFornecedor.DataSource = bllFornecedor.Select();
        }

        private void btnGravar_Click(object sender, EventArgs e) {
            CAMADAS.BLL.Fornecedor bllFornecedor = new CAMADAS.BLL.Fornecedor();
            string msg = "";
            string titMsg = "";
            if (lblID.Text == "-1") {
                msg = "Deseja Inserir novo Fornecedor?";
                titMsg = "Inserir";
            }
            else {
                msg = "Deseja Alterar o Fornecedor?";
                titMsg = "Atualizar";
            }

            DialogResult resposta = MessageBox.Show(msg, titMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resposta == DialogResult.Yes) {
                CAMADAS.MODEL.Fornecedor fornecedor = new CAMADAS.MODEL.Fornecedor();
                fornecedor.id = Convert.ToInt32(lblID.Text);
                fornecedor.nome = txtNome.Text;

                if (lblID.Text == "-1") {
                    bllFornecedor.Insert(fornecedor);
                }
                else {
                    bllFornecedor.Update(fornecedor);
                }
            }

            limpaControles();
            habilitaControles(false);
            dgvFornecedor.DataSource = bllFornecedor.Select();
        }

        private void dgvFornecedor_DoubleClick(object sender, EventArgs e) {
            lblID.Text = dgvFornecedor.SelectedRows[0].Cells["id"].Value.ToString();
            txtNome.Text = dgvFornecedor.SelectedRows[0].Cells["nome"].Value.ToString();
        }
    }
}
