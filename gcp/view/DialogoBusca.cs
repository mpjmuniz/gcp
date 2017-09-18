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
    public partial class DialogoBusca : Form
    {

        public DialogoBusca()
        {
            InitializeComponent();
        }

        private void DialogoBusca_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            this.Close();
        }

        private void dadoscpBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        /*
        public int getFuncionario() {
            return _linqSource.getFuncionario();
        }*/
    }
}
