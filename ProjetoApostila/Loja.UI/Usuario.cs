using Loja.BLL;
using Loja.DTO;
using System;
using System.Windows.Forms;

namespace Loja.UI
{
    public partial class Usuario : Form
    {
        private string _comando;
        private int _idUsuario = 0;
        private UsuarioBLL _usuarioBLL;
        public Usuario()
        {
            InitializeComponent();

            _usuarioBLL = new UsuarioBLL();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _usuarioBLL.ObterUsuarios();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = (sender as DataGridView).CurrentRow.Index;

            _idUsuario = (int)(sender as DataGridView)[0, index].Value;
            textBox1.Text = (sender as DataGridView)[1, index].Value.ToString();
            textBox2.Text = (sender as DataGridView)[2, index].Value.ToString();
            textBox4.Text = (sender as DataGridView)[3, index].Value.ToString();
            textBox5.Text = (sender as DataGridView)[4, index].Value.ToString();

            if ((sender as DataGridView)[5, index].Value.ToString() == "A")
                comboBox1.Text = "Ativo";
            else
                comboBox1.Text = "Inativo";

            switch ((sender as DataGridView)[6, index].Value.ToString())
            {
                case "1":
                    comboBox2.Text = "Usuário";
                    break;
                case "2":
                    comboBox2.Text = "Editor";
                    break;
                case "3":
                    comboBox2.Text = "Administrador";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _comando = "Inserir";
            LimparCampos();
            textBox5.Text = DateTime.Now.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _comando = "Atualizar";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _comando = "Excluir";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _comando = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var _usuario = new UsuarioDTO();
            _usuario.Nome = textBox1.Text;
            _usuario.Email = textBox2.Text;
            _usuario.Senha = textBox4.Text;
            _usuario.DataCadastro = DateTime.Parse(textBox5.Text);

            switch (comboBox2.SelectedItem)
            {
                case "Usuário":
                    _usuario.Perfil = 1;
                    break;
                case "Editor":
                    _usuario.Perfil = 2;
                    break;
                case "Administrador":
                    _usuario.Perfil = 3;
                    break;
            }

            if (comboBox1.SelectedItem.ToString() == "Ativo")
                _usuario.Situacao = "A";
            else
                _usuario.Situacao = "I";

            if (_comando == "Inserir")
                _usuarioBLL.Inserir(_usuario);
            else if (_comando == "Atualizar")
            {
                if (_idUsuario <= 0)
                {
                    MessageBox.Show("Selecione o usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _usuario.Id = _idUsuario;

                _usuarioBLL.Alterar(_usuario);
            }
            else if (_comando == "Excluir")
            {
                if (_idUsuario <= 0)
                {
                    MessageBox.Show("Selecione o usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _usuario.Id = _idUsuario;

                _usuarioBLL.Excluir(_usuario);
            }

            dataGridView1.DataSource = _usuarioBLL.ObterUsuarios();

            _idUsuario = 0;
            _comando = "";
        }

        private void LimparCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
    }
}
