namespace JogoRpg.Src.Entities
{
    // CLASSE 
    abstract public class Personagem
    {
        //ATRIBUTOS
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Mana { get; set; }
        public float Xp { get; set; }
        public int Inteligencia { get; set; }
        public int Forca { get; set; }
        public int Level { get; set; }

        // CONTRUTORES
        public Personagem(string nome){
            this.Nome = nome; 
        }

        // MÉTODOS
        public abstract void LvLUp();
    }
}