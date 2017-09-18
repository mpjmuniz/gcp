using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gcp.view
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void funcionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormularioFuncionario fFuncionario = new FormularioFuncionario();
            fFuncionario.MdiParent = this;
            fFuncionario.Show();
        }
    }
}
