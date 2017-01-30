using lojaComEntity.Entidades;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            //UsuarioDao dao = new UsuarioDao();
            //Usuario vinicios = dao.BuscaPorID(3);
            //Usuario vinicios = new Usuario() { Nome = "vinicios", Senha= "abc123" };
            //vinicios.Nome = "Vinicios Neves";
            //dao.SaveChanges();
            //dao.Salva(vinicios);

            /*Categoria c = new Categoria() { Nome = "Roupas" };
            var catDao = new CategoriaDao();
            catDao.Salva(c);
            Produto p = new Produto() { Nome = "casaco", Preco = 215, CategoriaID = 2 };
            proDao.Salva(p);*/

            //Produto produto = proDao.BuscaPorID(1);
            //Console.WriteLine(produto.Categoria.Nome);

            /*var categoria = catDao.BuscaPorID(1);

            foreach (var p in categoria.Produtos)
            {
                Console.WriteLine(p.Nome);
            }
            EntidadesContext contexto = new EntidadesContext();

            var busca = from p in contexto.Produtos
                        where p.Preco > 100 && p.Categoria.Nome == "Roupas"
                        orderby p.Nome 
                        select p;
            IList<Produto> resultado = busca.ToList();
            foreach (var produto in resultado)
            {
                Console.WriteLine(produto.Nome);
            }

            EntidadesContext contexto = new EntidadesContext();

            ProdutoDao proDao = new ProdutoDao();

            Venda v = new Venda() { Cliente = vinicios };

            Produto p = proDao.BuscaPorID(1);
            Produto p2 = proDao.BuscaPorID(3);

            ProdutoVenda pv = new ProdutoVenda() { Venda = v, Produto = p };
            ProdutoVenda pv2 = new ProdutoVenda() { Venda = v, Produto = p2 };


            contexto.Vendas.Add(v);
            contexto.ProdutoVenda.Add(pv);
            contexto.ProdutoVenda.Add(pv2);

            contexto.SaveChanges();


            Venda venda = contexto.Vendas.Include(v => v.ProdutoVenda).ThenInclude(pv => pv.Produto).FirstOrDefault(v => v.ID == 1);
            foreach (var pv in venda.ProdutoVenda)
            {
                Console.WriteLine(pv.Produto.Nome);
            }*/

            EntidadesContext contexto = new EntidadesContext();

            PessoaFisica pf = new PessoaFisica() { Nome = "pessoa física", Senha = "123", CPF = "123456789" };
            PessoaJuridica pj = new PessoaJuridica() { Nome = "pessoa juridica", Senha = "123", CNPJ = "12345678901" };

            contexto.PessoasFisicas.Add(pf);
            contexto.PessoasJuridicas.Add(pj);

            contexto.SaveChanges();

            Console.ReadLine();

        }

    }
}
