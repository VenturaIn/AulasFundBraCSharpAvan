using Loja.DAL;
using Loja.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.BLL
{
    public class UsuarioBLL
    {

        private UsuarioDAL _usuarioDAL;
        public UsuarioBLL()
        {
            _usuarioDAL = new UsuarioDAL();
        }

        public IList<UsuarioDTO> ObterUsuarios()
        {
            return _usuarioDAL.ObterUsuarios();
        }

        public void Inserir(UsuarioDTO usuario)
        {
            _usuarioDAL.Inserir(usuario);
        }

        public void Alterar(UsuarioDTO usuario)
        {
            _usuarioDAL.Alterar(usuario);
        }
        public void Excluir(UsuarioDTO usuario)
        {
            _usuarioDAL.Excluir(usuario);
        }
    }
}
