using System.Collections.Generic;

namespace teste2.Src.Entities.AcompanhandoLeitura
{
    // CLASSE
    public class Leitor
    {
        // ATRIBUTOS
        public string Nome { get; private set; }
        public Livro Livros { get; set; }  
        public List<Livro> EstanteLivros { get; set; } 

        // CONSTRUTOR
        public Leitor(string nome, Livro livros){
            this.Nome = nome;
            this.EstanteLivros = new List<Livro>();
        }

        //MÉTODOS
        public void AdicionarLivro(Livro livro){
        this.EstanteLivros.Add(livro);
        }

        public void RemoverLivro(Livro livro){
            this.EstanteLivros.Remove(livro);
        }
    }
}