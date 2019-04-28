using Loja.BLL;
using Loja.DTO;
using System;
using System.Windows.Forms;

namespace Loja.UI
{
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();
        }

        private void Teste_Load(object sender, EventArgs e)
        {
            var usuarioBLL = new UsuarioBLL();
            var usuarios = usuarioBLL.ObterUsuarios();
            usuarios.Insert(0, new UsuarioDTO { Id = 0, Nome = "Selecione >>" });
            comboBox1.DataSource = usuarios;
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex < 1)
            {
                MessageBox.Show("Selecione o usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(String.Format("Usuário selecionado: {0}", (comboBox1.SelectedItem as UsuarioDTO).Nome), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
