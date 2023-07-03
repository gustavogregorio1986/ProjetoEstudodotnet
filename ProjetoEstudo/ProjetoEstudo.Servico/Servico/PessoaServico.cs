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
    public class PessoaServico : IPessoaServico
    {
        private IPessoaRepositorio pessoaRepositorio;

        public PessoaServico(IPessoaRepositorio pessoaRepositorio)
        {
            this.pessoaRepositorio = pessoaRepositorio;
        }

        public void Adicionar(PessoaDTO pessoaDTO)
        {
            pessoaRepositorio.Adicionar(pessoaDTO);
        }
    }
}
