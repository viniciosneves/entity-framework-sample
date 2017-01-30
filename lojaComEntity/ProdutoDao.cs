using lojaComEntity.Entidades;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    class ProdutoDao
    {
        private EntidadesContext contexto;

        public ProdutoDao()
        {
            contexto = new EntidadesContext();
        }

        public void Salva(Produto produto)
        {
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
        }

        internal void SaveChanges()
        {
            contexto.SaveChanges();
        }

        internal void Remove(Produto produto)
        {
            contexto.Produtos.Remove(produto);
            contexto.SaveChanges();

        }

        public Produto BuscaPorID(int id)
        {

            return contexto.Produtos.Include(produto => produto.Categoria).FirstOrDefault(u => u.ID == id);

        }

    }
}
