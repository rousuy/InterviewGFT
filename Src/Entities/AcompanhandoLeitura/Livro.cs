namespace teste2.Src.Entities.AcompanhandoLeitura
{
    // CLASSE
    public class Livro
    {
        // ATRIBUTOS
        public string Titulo { get; set; }
        public int QtdPagina { get;  set; }
        public int PaginasLidas { get;  set; }

        // CONSTRUTOR
        public Livro(string titulo, int qtdePaginas){
            this.Titulo = titulo;
            this.QtdPagina = qtdePaginas;
        }

        //MÉTODOS
        public double VerificaProgresso(){
            if (PaginasLidas <= QtdPagina){
                double progresso =  this.PaginasLidas * 100 / this.QtdPagina;
                return progresso;
            }
            else{
                return 100;
            } 
            
        }
        public void AdicionarPaginasLidas(int paginasLidas){
            this.PaginasLidas += paginasLidas;
        }       
    }

}