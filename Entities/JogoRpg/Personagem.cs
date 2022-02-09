namespace teste.Entities.JogoRpg
{
    // CLASSE
    public abstract class Personagem
    {
        // ATRIBUTOS E AutoProperties
        public string Nome { get; set; } 
        public int Vida { get; set; }

        public int Mana { get; set; }
        
        public float Xp { get; set; }

        public int Forca { get; set; }

        public  int Level { get; set; }

        

        // CONSTRUTOR
        public Personagem(string nome, int forca, int vida){
            this.Nome = nome;
            this.Level = forca;
            this.Vida = vida;
        }

        public override string ToString(){
            return $"{this.Nome} {this.Level} {this.Vida}";
        }

     

    }
}