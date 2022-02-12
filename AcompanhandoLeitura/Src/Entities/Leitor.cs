namespace AcompanhandoLeitura.Src.Entities
{
    // CLASSE
    public class Leitor
    {
        // ATRIBUTOS
        public string Nome { get; private set; }
        private Livro Livro { get; set; }  
        public List<Livro> EstanteLivros { get; private set; } = new List<Livro>();

        // CONSTRUTOR
        public Leitor(string nome, Livro livro){
            this.Nome = nome;
            AdicionarLivro(livro);
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