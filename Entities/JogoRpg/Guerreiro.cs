namespace teste.Entities.JogoRpg
{
    // CLASSE MAGO - Herdando de Personagem
    public class Guerreiro : Personagem
    {   

      // CONSTRUTORES 
      public Guerreiro(string nome, int forca, int vida){
        this.Nome = nome;
        this.Forca = forca;
        this.Vida = vida;
      }


      // MÉTODOS

      public string Nome { get; set; }
      public int Forca { get; set; }

      public int Vida { get; set; }
      
      public override string ToString(){
        return $"{Nome}, {Forca} {Level}";
      }

    
    }

}