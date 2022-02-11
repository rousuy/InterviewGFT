namespace teste2.Src.Entities.JogoRpg
{
    // CLASSE
    public class Mago : Personagem
    {
        // ATRIBUTOS
        public List<string> Magia { get; private set; } = new List<string>();

        // CONSTRUTOR
        public Mago(string nome) : base(nome){
            this.Nome = nome;
        }

        // MÉTODOS
        public void AprenderMagia(string magia){
            this.Magia.Add(magia);
        }

        public override void LvLUp(){
            this.Level += 1;
            this.Mana += 2;
            this.Inteligencia += 2;
            this.Forca += 1;
            this.Vida += 1;
        }

        public virtual string Attack(){
            Random rand = new Random();
            int randInt = rand.Next(0, 180);
            float pontos = (float)((this.Inteligencia / 2) * Math.Pow(this.Level,2)) + randInt;
            this.Xp += pontos;
            return $"{this.Nome} atacou, e ganhou {pontos} pontos"; 

        }

        public override string ToString(){
            return "=================================\n" 
                + "DADOS DO PERSONAGEM: \n"
                + "=================================\n"
                + $"NOME: {this.Nome}\n"
                + $"FORÇA: {this.Forca}\n"
                + $"LEVEL: {this.Level}\n"
                + $"VIDA: {this.Vida}\n"
                + $"MANA: {this.Mana}\n"
                + $"INTELIGÊNCIA: {this.Inteligencia}\n"
                + $"XP: {this.Xp} pontos.\n"
                + $"================================\n";
        }
    }
}