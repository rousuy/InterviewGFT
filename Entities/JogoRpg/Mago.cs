namespace teste.Entities.JogoRpg
{
    
    // CLASSE MAGO herdando de Personagem
    
    public class Mago : Personagem
    {   
        // ATRIBUTOS
        public List<string> Magia;
        
        // MÉTODOS
        public string Nome { get; set; }
        public int Forca { get; set; } 
        public int Vida { get; set; }  
    
    }
}