﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAlmoxerifado.FORMS {
    public partial class SobreForm : Form {
        public SobreForm() {
            InitializeComponent();
        }

        private void SobreForm_Load(object sender, EventArgs e) {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
