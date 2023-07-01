using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudo.Infraestrutura.repositorio.Interface
{
    public interface IGenericRepositorio<T> where T : class
    {
        void Adicionar(T entidade);
    }
}
