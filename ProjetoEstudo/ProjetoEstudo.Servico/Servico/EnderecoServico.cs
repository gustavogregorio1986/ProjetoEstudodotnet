using PorjetoEstudo.Dominio.Dominio;
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
    public class EnderecoServico : IEnderecoServico
    {
        private IEnderecoRepositorio enderecoRepostorio;

        public EnderecoServico(IEnderecoRepositorio enderecoRepostorio)
        {
            this.enderecoRepostorio = enderecoRepostorio;
        }

        public void Adicionar(EnderecoDTO enderecoDTO)
        {
            enderecoRepostorio.Adicionar(enderecoDTO);
        }
    }
}
