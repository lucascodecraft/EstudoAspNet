using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public List<Produto> GetProdutos()
        {
            return dbSet.ToList();
        }

        
        public void SaveProdutos(List<Livro> livros)
        {
            foreach (var livro in livros)
            {

                if (!dbSet.Where(p => p.Codigo == livro.Codigo).Any())
                {
                    dbSet.AddRange(new Produto(livro.Codigo, livro.Nome, livro.Preco)); // Varrendo a lista de livros.
                }
            }
            contexto.SaveChanges(); // Salvando no banco de dados
        }
    }
}
