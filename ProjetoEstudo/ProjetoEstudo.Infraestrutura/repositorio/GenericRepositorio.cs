using Microsoft.EntityFrameworkCore;
using ProjetoEstudo.Infraestrutura.Contexto;
using ProjetoEstudo.Infraestrutura.repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudo.Infraestrutura.repositorio
{
    public class GenericRepositorio<T> : IGenericRepositorio<T>, IDisposable where T : class
    {
        private readonly ProjetoEstudoContexto _db;

        public GenericRepositorio()
        {
            var options = new DbContextOptionsBuilder<ProjetoEstudoContexto>().UseSqlServer("DefaultConnection").Options; 
            _db = new ProjetoEstudoContexto(options);
        }

        public void Adicionar(T entidade)
        {
            _db.Add(entidade);
            Commit();
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
            }

            GC.SuppressFinalize(this);
        }
    }
}
