using lojaComEntity.Entidades;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    class CategoriaDao
    {
        private EntidadesContext contexto;

        public CategoriaDao()
        {
            contexto = new EntidadesContext();
        }

        public void Salva(Categoria categoria)
        {
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
        }

        internal void SaveChanges()
        {
            contexto.SaveChanges();
        }

        internal void Remove(Categoria categoria)
        {
            contexto.Categorias.Remove(categoria);
            contexto.SaveChanges();

        }

        public Categoria BuscaPorID(int id)
        {

            return contexto.Categorias.Include(c => c.Produtos).FirstOrDefault(u => u.ID == id);

        }
    }
}
