using CasaDoCodigo.Models;
using CasaDoCodigo.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo
{
    public class DataService : IDataService
    {
        public readonly ApplicationContext contexto;
        public readonly IProdutoRepository produtoRepository;

        public DataService(ApplicationContext contexto,
            IProdutoRepository produtoRepository
            )
        {
            this.contexto = contexto;
            this.produtoRepository = produtoRepository;
        }

        public void IniciazilaDB()   // Inicializando banco de dados
        {
            contexto.Database.EnsureCreated();

            List<Livro> livros = GetLivros();

            produtoRepository.SaveProdutos(livros);
        }

        private static List<Livro> GetLivros()
        {
            var json = File.ReadAllText("livros.json"); // Lendo o arquivo json.
            var livros = JsonConvert.DeserializeObject<List<Livro>>(json); // Convertendo de json para objeto.
            return livros;
        }
    }
}
