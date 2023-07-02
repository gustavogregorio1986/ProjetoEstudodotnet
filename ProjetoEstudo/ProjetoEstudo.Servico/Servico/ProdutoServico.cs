using ProjetoEstudo.Infraestrutura.DTO;
using ProjetoEstudo.Infraestrutura.repositorio.Interface;
using ProjetoEstudo.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudo.Servico.Servico
{
    public class ProdutoServico : IProdutoServico
    {
        private IProdutoRepositorio produtoRepositorio;

        public void Adicionar(ProdutoDTO produtoDTO)
        {
            produtoRepositorio.Adicionar(produtoDTO);
        }
    }
}
