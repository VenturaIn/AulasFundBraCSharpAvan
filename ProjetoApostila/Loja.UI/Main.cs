using System;
using System.Windows.Forms;

namespace Loja.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new Usuario();
            child.MdiParent = this;
            child.Show();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new Teste();
            child.MdiParent = this;
            child.Show();
        }
    }
}
