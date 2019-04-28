using Loja.DAL;
using Loja.DTO;
using System.Collections.Generic;

namespace Loja.BLL
{
    public class ProdutoBLL
    {

        private ProdutoDAL _produtoDAL;
        public ProdutoBLL()
        {
            _produtoDAL = new ProdutoDAL();
        }

        public IList<ProdutoDTO> ObterProdutos()
        {
            return _produtoDAL.ObterProdutos();
        }

        public void Inserir(ProdutoDTO produto)
        {
            _produtoDAL.Inserir(produto);
        }

        public void Alterar(ProdutoDTO produto)
        {
            _produtoDAL.Alterar(produto);
        }
        public void Excluir(ProdutoDTO produto)
        {
            _produtoDAL.Excluir(produto);
        }
    }
}
