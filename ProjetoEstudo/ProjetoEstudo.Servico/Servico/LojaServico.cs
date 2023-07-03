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
    public class LojaServico : ILojaServico
    {
        private ILojaRepositorio lojaRepositorio;


        public LojaServico(ILojaRepositorio lojaRepositorio)
        {
            this.lojaRepositorio = lojaRepositorio;
        }

        public void Adicionar(LojaDTO lojaDTO)
        {
            lojaRepositorio.Adicionar(lojaDTO);
        }
    }
}
