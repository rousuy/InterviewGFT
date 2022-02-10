namespace teste2.Src.Entities.AcompanhandoLeitura
{
    // CLASSE
    public class Livro
    {
        // ATRIBUTOS
        public string Titulo {get; private set;}
        public int QtdPagina { get; private set; }
        public int PaginasLidas { get; private set; }

        // CONSTRUTOR
        public Livro(string titulo, int qtdePaginas, int paginasLidas){
            this.Titulo = titulo;
            this.QtdPagina = qtdePaginas;
            this.PaginasLidas = paginasLidas;
        }

        //MÉTODOS
        public double VerificaProgresso(){
            double progresso =  this.PaginasLidas * 100 / this.QtdPagina;
            return progresso;
            
        }

        public void AdicionarPaginasLidas(int paginasLidas){
            this.PaginasLidas += paginasLidas;
        }
            
    }

}