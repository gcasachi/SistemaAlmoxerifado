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
    public partial class SetoresForm : Form {
        public SetoresForm() {
            InitializeComponent();
        }

        private void SetoresForm_Load(object sender, EventArgs e) {
            CAMADAS.BLL.Setor bllSetor = new CAMADAS.BLL.Setor();
            dgvSetor.DataSource = "";
            dgvSetor.DataSource = bllSetor.Select();
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
            if(lblID.Text != "") {
                habilitaControles(true);
                txtNome.Focus();
            }
            else {
                MessageBox.Show("Não há dados para Editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            limpaControles();
            habilitaControles(false);
        }

        private void btnRemover_Click(object sender, EventArgs e) {
            CAMADAS.BLL.Setor bllSetor = new CAMADAS.BLL.Setor();
            string msg = "Não há setor para remover";
            string titBox = "Remover";

            if(lblID.Text != "") {
                msg = "Deseja Remover o Setor: " + txtNome.Text;
                DialogResult resposta = MessageBox.Show(msg, titBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if(resposta == DialogResult.Yes) {
                    int id = Convert.ToInt32(lblID.Text);
                    bllSetor.Delete(id);
                }
            }
            else {
                MessageBox.Show(msg, titBox, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            limpaControles();
            dgvSetor.DataSource = "";
            dgvSetor.DataSource = bllSetor.Select();
        }

        private void btnGravar_Click(object sender, EventArgs e) {
            CAMADAS.BLL.Setor bllSetor = new CAMADAS.BLL.Setor();
            string msg = "";
            string titMsg = "";
            if(lblID.Text == "-1") {
                msg = "Deseja Inserir novo Setor?";
                titMsg = "Inserir";
            }
            else {
                msg = "Deseja Alterar o Setor?";
                titMsg = "Atualizar";
            }

            DialogResult resposta = MessageBox.Show(msg, titMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(resposta == DialogResult.Yes) {
                CAMADAS.MODEL.Setor setor = new CAMADAS.MODEL.Setor();
                setor.id = Convert.ToInt32(lblID.Text);
                setor.nome = txtNome.Text;

                if(lblID.Text == "-1") {
                    bllSetor.Insert(setor);
                }
                else {
                    bllSetor.Update(setor);
                }
            }

            limpaControles();
            habilitaControles(false);
            dgvSetor.DataSource = "";
            dgvSetor.DataSource = bllSetor.Select();
        }

        private void dgvSetor_DoubleClick(object sender, EventArgs e) {
            lblID.Text = dgvSetor.SelectedRows[0].Cells["id"].Value.ToString();
            txtNome.Text = dgvSetor.SelectedRows[0].Cells["nome"].Value.ToString();
        }
    }
}
