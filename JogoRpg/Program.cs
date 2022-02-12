using static System.Console;
using JogoRpg.Src.Entities;
/*
Personagens RPG
1. Usando o conceito de polimorfismo, implemente o método lvlUp(), de forma que o Mago ao subir de nível possua um aumento maior nos
atributos Mana e Inteligência e o Guerreiro possua um aumento maior nos atributos Vida e Força.
2. Implemente o método attack() de forma que siga a seguinte regra:
Mago: ( Inteligência / 2 * Level² ) + numeroRandomico( 0 até 180).
Guerreiro: ( Força / 2 * Level² ) + numeroRandomico( 0 até 180 )
*/

Mago mago;
Guerreiro guerreiro;

WriteLine("Jogo RPG.");
WriteLine();

Write("Qual personagem? [1] - Mago / [2] - Guerreiro: ");
int tipoPersonagem = int.Parse(ReadLine());
switch(tipoPersonagem){
case 1:
    Write("Nome do mago: ");
    string nomeMago = ReadLine();
    mago = new Mago(nomeMago) ;
    while (true){    
        Write("Qual ação? [1]- Dados / [2] - Aprender nova magia / [3] - Atacar [4] - Subir de nível / [5] - fim: ");
        int acao = int.Parse(ReadLine());
        switch (acao){
            case 1:
                WriteLine(mago);
                break;
            case 2:
                Write("Qual magia? ");
                string magia = ReadLine();
                mago.AprenderMagia(magia);
                break;
            case 3:
                WriteLine(mago.Attack());
                break;
            case 4:
                WriteLine("Level Up...");
                mago.LvLUp();
                break;
            case 5:
                return;
        }
    }
case 2:
    Write("Nome do guerreiro: ");
    string nomeGuerreiro = ReadLine();
    guerreiro = new Guerreiro(nomeGuerreiro);
    while (true){
        Write("Qual ação? [1]- Dados / [2] - Aprender nova habilidade / [3] - Atacar  / [4] - Subir de nível / [5] - fim: ");
        int acao = int.Parse(ReadLine());
        switch (acao){
            case 1:
            WriteLine(guerreiro);
            WriteLine();
            break;
        case 2:
            Write("Qual habilidade? ");
            string habilidade = ReadLine();
            guerreiro.AprenderHabilidade(habilidade);
            WriteLine();
            break;
        case 3:
            WriteLine(guerreiro.Attack());
            WriteLine();
            break;
        case 4:
            WriteLine("Level Up...");
            guerreiro.LvLUp();
            break;
        case 5:
            return;
        }
    } 
}