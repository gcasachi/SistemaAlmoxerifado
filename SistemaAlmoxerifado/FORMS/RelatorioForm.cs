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
    public partial class RelatorioForm : Form {
        public RelatorioForm() {
            InitializeComponent();
        }

        private void btnRelRequisicao_Click(object sender, EventArgs e) {
            RELATORIOS.relRequisicao.gerarReqAlmoxarifado();
        }

        private void btnRelAlmo_Click(object sender, EventArgs e) {
            RELATORIOS.relAlmoxarifado.gerarReqAlmoxarifado();
        }
    }
}
