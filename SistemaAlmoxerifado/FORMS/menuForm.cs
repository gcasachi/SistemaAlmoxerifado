using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SistemaAlmoxerifado.FORMS {
    public partial class MenuForm : Form {

        /*Para Mover a tela com o Mouse*/
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        /**********/

        public MenuForm() {
            InitializeComponent();         
    }

        private void btnFechar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Maximized;

            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
            btnRestaurar.Enabled = true;
            btnMaximizar.Enabled = false;        

        }

        private void btnRestaurar_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
            btnRestaurar.Enabled = false;
            btnMaximizar.Enabled = true;
        }

        private void MenuForm_Load(object sender, EventArgs e) {
            btnMaximizar.Enabled = true;
            btnRestaurar.Enabled = false;
            btnRestaurar.Visible = false;
        }

        private void btnMinimaze_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void painelCabecalho_MouseMove(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void AbrirNoPainel<Forms>() where Forms : Form, new() {
            Form formulario = new Forms();
            formulario = painelConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario != null) {
                formulario = null;
            }

            formulario = new Forms();
            formulario.TopLevel = false;
            //formulario.FormBorderStyle = FormBorderStyle.None;
            //formulario.Dock = DockStyle.Fill;
            painelConteudo.Controls.Add(formulario);
            painelConteudo.Tag = formulario;
            formulario.WindowState = FormWindowState.Maximized;
            formulario.Show();
            formulario.BringToFront();
        }

        private void btnClientes_Click(object sender, EventArgs e) {
            AbrirNoPainel<SetoresForm>();
        }

        private void btnRequisicao_Click(object sender, EventArgs e) {
            AbrirNoPainel<RequisicaoForm>();
        }

        private void btnFornecedor_Click(object sender, EventArgs e) {
            AbrirNoPainel<FornecedorForm>();
        }

        private void btnAlmo_Click(object sender, EventArgs e) {
            AbrirNoPainel<AlmoxarifadoForm>();
        }

        private void btnSobre_Click(object sender, EventArgs e) {

        }

        
    }
}
