namespace SistemaAlmoxerifado.FORMS {
    partial class MenuForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.painelCabecalho = new System.Windows.Forms.Panel();
            this.btnMinimaze = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.painelMenu = new System.Windows.Forms.Panel();
            this.btnAlmo = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnRequisicao = new System.Windows.Forms.Button();
            this.painelConteudo = new System.Windows.Forms.Panel();
            this.painelCabecalho.SuspendLayout();
            this.painelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelCabecalho
            // 
            this.painelCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.painelCabecalho.Controls.Add(this.btnMinimaze);
            this.painelCabecalho.Controls.Add(this.label1);
            this.painelCabecalho.Controls.Add(this.btnRestaurar);
            this.painelCabecalho.Controls.Add(this.btnFechar);
            this.painelCabecalho.Controls.Add(this.btnMaximizar);
            this.painelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.painelCabecalho.Name = "painelCabecalho";
            this.painelCabecalho.Size = new System.Drawing.Size(1100, 41);
            this.painelCabecalho.TabIndex = 0;
            this.painelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.painelCabecalho_MouseMove);
            // 
            // btnMinimaze
            // 
            this.btnMinimaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimaze.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimaze.FlatAppearance.BorderSize = 0;
            this.btnMinimaze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimaze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimaze.Image = global::SistemaAlmoxerifado.Properties.Resources.minimize__1_;
            this.btnMinimaze.Location = new System.Drawing.Point(956, 5);
            this.btnMinimaze.Name = "btnMinimaze";
            this.btnMinimaze.Size = new System.Drawing.Size(40, 34);
            this.btnMinimaze.TabIndex = 4;
            this.btnMinimaze.UseVisualStyleBackColor = true;
            this.btnMinimaze.Click += new System.EventHandler(this.btnMinimaze_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightBlue;
            this.label1.Location = new System.Drawing.Point(38, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sistema Almoxarifado";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1002, 4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(40, 34);
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1049, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 34);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1002, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(40, 34);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // painelMenu
            // 
            this.painelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.painelMenu.Controls.Add(this.btnAlmo);
            this.painelMenu.Controls.Add(this.btnSobre);
            this.painelMenu.Controls.Add(this.btnClientes);
            this.painelMenu.Controls.Add(this.btnFornecedor);
            this.painelMenu.Controls.Add(this.btnRequisicao);
            this.painelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.painelMenu.Location = new System.Drawing.Point(0, 41);
            this.painelMenu.Name = "painelMenu";
            this.painelMenu.Size = new System.Drawing.Size(178, 609);
            this.painelMenu.TabIndex = 1;
            // 
            // btnAlmo
            // 
            this.btnAlmo.FlatAppearance.BorderSize = 0;
            this.btnAlmo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnAlmo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmo.ForeColor = System.Drawing.Color.White;
            this.btnAlmo.Image = global::SistemaAlmoxerifado.Properties.Resources.data_storage;
            this.btnAlmo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlmo.Location = new System.Drawing.Point(0, 217);
            this.btnAlmo.Name = "btnAlmo";
            this.btnAlmo.Size = new System.Drawing.Size(184, 39);
            this.btnAlmo.TabIndex = 5;
            this.btnAlmo.Text = "        Almoxarifado";
            this.btnAlmo.UseVisualStyleBackColor = true;
            this.btnAlmo.Click += new System.EventHandler(this.btnAlmo_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.Image = global::SistemaAlmoxerifado.Properties.Resources.help_operator__3_;
            this.btnSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobre.Location = new System.Drawing.Point(0, 565);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(184, 41);
            this.btnSobre.TabIndex = 4;
            this.btnSobre.Text = "      Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(-6, 82);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(184, 39);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "           Setor";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.FlatAppearance.BorderSize = 0;
            this.btnFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedor.Image")));
            this.btnFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFornecedor.Location = new System.Drawing.Point(-9, 172);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(187, 39);
            this.btnFornecedor.TabIndex = 1;
            this.btnFornecedor.Text = "           Fornecedor";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnRequisicao
            // 
            this.btnRequisicao.FlatAppearance.BorderSize = 0;
            this.btnRequisicao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnRequisicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequisicao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequisicao.ForeColor = System.Drawing.Color.White;
            this.btnRequisicao.Image = ((System.Drawing.Image)(resources.GetObject("btnRequisicao.Image")));
            this.btnRequisicao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequisicao.Location = new System.Drawing.Point(-9, 127);
            this.btnRequisicao.Name = "btnRequisicao";
            this.btnRequisicao.Size = new System.Drawing.Size(193, 39);
            this.btnRequisicao.TabIndex = 2;
            this.btnRequisicao.Text = "           Requisição";
            this.btnRequisicao.UseVisualStyleBackColor = true;
            this.btnRequisicao.Click += new System.EventHandler(this.btnRequisicao_Click);
            // 
            // painelConteudo
            // 
            this.painelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelConteudo.Location = new System.Drawing.Point(178, 41);
            this.painelConteudo.Name = "painelConteudo";
            this.painelConteudo.Size = new System.Drawing.Size(922, 609);
            this.painelConteudo.TabIndex = 2;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.painelConteudo);
            this.Controls.Add(this.painelMenu);
            this.Controls.Add(this.painelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.painelCabecalho.ResumeLayout(false);
            this.painelCabecalho.PerformLayout();
            this.painelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelCabecalho;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel painelMenu;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnRequisicao;
        private System.Windows.Forms.Button btnAlmo;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnMinimaze;
        private System.Windows.Forms.Panel painelConteudo;
    }
}