namespace teste2.Src.Entities.JogoRpg
{
    // CLASSE
    public class Guerreiro : Personagem
    {
        // ATRIBUTOS
        public List<string> Habilidade { get; set; } = new List<string>();


        //CONSTRUTOR
        public Guerreiro(string nome) : base(nome) {
            this.Nome = nome;
        }

        // MÉTODOS
        public override void LvLUp()
        {
            this.Forca += 1;
            this.Vida += 1;
        }

        public void AprenderHabilidade(string habilidade){
            this.Habilidade.Add(habilidade);
        }

        public virtual string Attack(){
            Random rand = new Random();
            int randInt = rand.Next(0, 180);
            float pontos = (float)((this.Forca / 2) * Math.Pow(this.Level,2)) + randInt;
            this.Xp += pontos;
            return $"{this.Nome} ganhou {pontos} pontos"; 

        }    
    }
}