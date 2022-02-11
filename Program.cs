using System;
using System.Collections.Generic;
using teste2.Src.Entities.AcompanhandoLeitura;
using teste2.Src.Entities.JogoRpg;
using static System.Console;

/*
Acertar n° aleatório

Gere um número inteiro aleatório entre 0 e 10 a cada execução do programa(Biblioteca
Random tanto em Java como C#) e pergunte ao usuário um número. Se o usuário errar,
peça para ele entrar com outro número até que acerte o número gerado aleatoriamente.
*/

// WriteLine("Acerte o número!");
// WriteLine();

// static bool IsEqual(int randInt, int userInt){
//     if (randInt == userInt){
//         return true;
//     }
//     else{
//         return false;
//     }
// }

// Random rand = new Random();
// int randInt = rand.Next(0, 10);

// Write("Número: ");
// int userInt = int.Parse(ReadLine());

// while (!IsEqual(randInt, userInt)){
//     Write("ERROU! Digite novamente: ");
//     userInt = int.Parse(ReadLine());
// }

// WriteLine();
// WriteLine("------------------------------------------");
// WriteLine();
// Thread.Sleep(2000);
// /*
// Multiplicando arrays

// Criar um método que realiza a multiplicação de dois arrays e seus resultados são
// armazenados gerando um novo array.
// O programa deve validar se os arrays são do mesmo tamanho, caso não sejam, deve gerar
// uma exceção personalizada informando o erro.
// Usar inputs abaixo e imprimir no console os resultados.
// [10, 5, 98, 452] x [10, 5, 98, 452]
// [548, 213, 10] x [5, 21, 12]
// [50, 60, 70] x [5, 21, 12]
// [60, 70] x [1, 2, 3]
// */

// WriteLine("Multiplicando Arrays, com tratamento de excessões: ");
// WriteLine();

// static int[] MultiplyVet( int[] arrayF, int[] arrayJ){
//     try{
//         int[] result = new int[arrayJ.Length];
//         for (int i = 0; i < result.Length; i++){       
//             result[i] = arrayF[i] * arrayJ[i];
//             if (i == 0)
//                 Write($"[{result[i]}, ");
//             else if (i == arrayJ.Length - 1)
//                 Write($"{result[i]}]");
//             else
//                 Write($"{result[i]}, ");
//         }
//         WriteLine();
//         return result;
//     }
//     catch(Exception e){
//         WriteLine();
//         WriteLine($"Tamanho dos vetores diferentes! Erro: {e}");
//     }
//     return null;
// }
// int[] vet1 = new int[4] {10, 5, 98, 452};
// int[] vet2 = new int[4] {10, 5, 98, 452};

// int[] vetA = new int[3] {548, 213, 10};
// int[] vetB = new int[3] {5, 21, 12};

// int[] vetFoo = new int[3] {50, 60, 70};
// int[] vetBar = new int[3] {5, 21, 12 };

// int[] vetX = new int[2] {60, 70};
// int[] vetY = new int[3] {1, 2, 3};

// int[] array1 = MultiplyVet(vet1, vet2);
// int[] array2 = MultiplyVet(vetA, vetB);
// int[] array3 = MultiplyVet(vetFoo, vetBar);
// int[] array4 = MultiplyVet(vetX, vetY);

// WriteLine();
// WriteLine();
// WriteLine("------------------------------------------");
// WriteLine();
// Thread.Sleep(2000);

// /*
// Acompanhamento leitura

// Criar classes leitor e livro, O leitor ao ser criado deve ser automaticamente criado junto e adicionado a sua estante seu livro favorito. O método de remover livro deve remover da estante do leitor e zerar a quantidade de páginas lidas.

// O método que verifica o progresso de leitura do livro deve retornar o valor percentual com relação a quantidade total de páginas arredondado para baixo. (Ex.: 85,3% = 85%).

// Demonstrar todos os métodos instanciando livros e leitor, criando uma classe main para executar e imprimir todos os resultados de alterações dos métodos.
// */

// WriteLine("Acompanhando leitura");
// WriteLine();

// Write("Digite o nome do Leitor: ");
// string nome = ReadLine();

// Write($"Livro favorito: ");
// string titulo = ReadLine();

// Write("Quantidade de páginas: ");
// int qtdePaginas = int.Parse(ReadLine());

// Livro livro = new Livro(titulo, qtdePaginas);

// Leitor leitor = new Leitor(nome, livro) ;

// Write("Páginas lidas: ");
// livro.AdicionarPaginasLidas(int.Parse(ReadLine()));

// WriteLine();

// WriteLine($"Nome:{leitor.Nome}");
// foreach (var obj in leitor.EstanteLivros){
//     WriteLine($"TÍTULO: {obj.Titulo}, QTDE PÁGINAS: {obj.QtdPagina}, PÁGINAS LIDAS: {obj.PaginasLidas}, "
//             + $"PROGRESSO: ({obj.VerificaProgresso().ToString("F0")}%)");
// }

// WriteLine();

// WriteLine("Removendo livro estante...");
// Thread.Sleep(1000);
// leitor.RemoverLivro(livro);

// if (leitor.EstanteLivros.Count() == 0){
//     WriteLine("Estante, vazia.");
// }

// WriteLine();
// WriteLine("------------------------------------------");
// WriteLine();
// Thread.Sleep(2000);

/*
Personagens RPG

1. Usando o conceito de polimorfismo, implemente o método lvlUp(), de forma que o Mago ao subir de nível possua um aumento maior nos
atributos Mana e Inteligência e o Guerreiro possua um aumento maior nos atributos Vida e Força.

2. Implemente o método attack() de forma que siga a seguinte regra:

Mago: ( Inteligência / 2 * Level² ) + numeroRandomico( 0 até 180).

Guerreiro: ( Força / 2 * Level² ) + numeroRandomico( 0 até 180 )
*/

Guerreiro guerreiro;
Mago mago;

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

WriteLine();
WriteLine("------------------------------------------");
WriteLine();