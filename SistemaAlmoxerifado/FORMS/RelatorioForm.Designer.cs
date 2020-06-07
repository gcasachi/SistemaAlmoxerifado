namespace SistemaAlmoxerifado.FORMS {
    partial class RelatorioForm {
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnRelAlmo = new System.Windows.Forms.Button();
            this.btnRelRequisicao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 31);
            this.label3.TabIndex = 54;
            this.label3.Text = "Relátorios";
            // 
            // btnRelAlmo
            // 
            this.btnRelAlmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelAlmo.Location = new System.Drawing.Point(594, 254);
            this.btnRelAlmo.Name = "btnRelAlmo";
            this.btnRelAlmo.Size = new System.Drawing.Size(89, 23);
            this.btnRelAlmo.TabIndex = 56;
            this.btnRelAlmo.Text = "&Almoxarifado";
            this.btnRelAlmo.UseVisualStyleBackColor = true;
            this.btnRelAlmo.Click += new System.EventHandler(this.btnRelAlmo_Click);
            // 
            // btnRelRequisicao
            // 
            this.btnRelRequisicao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRelRequisicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelRequisicao.Location = new System.Drawing.Point(222, 254);
            this.btnRelRequisicao.Name = "btnRelRequisicao";
            this.btnRelRequisicao.Size = new System.Drawing.Size(87, 23);
            this.btnRelRequisicao.TabIndex = 55;
            this.btnRelRequisicao.Text = "&Requisições";
            this.btnRelRequisicao.UseVisualStyleBackColor = true;
            this.btnRelRequisicao.Click += new System.EventHandler(this.btnRelRequisicao_Click);
            // 
            // RelatorioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 531);
            this.ControlBox = false;
            this.Controls.Add(this.btnRelAlmo);
            this.Controls.Add(this.btnRelRequisicao);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelatorioForm";
            this.Text = "RelatorioForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRelAlmo;
        private System.Windows.Forms.Button btnRelRequisicao;
    }
}