using System;
using static System.Console;
/*

Acertar n° aleatório

Gere um número inteiro aleatório entre 0 e 10 a cada execução do programa(Biblioteca
Random tanto em Java como C#) e pergunte ao usuário um número. Se o usuário errar,
peça para ele entrar com outro número até que acerte o número gerado aleatoriamente.
*/

static bool IsEqual(int randInt, int userInt){
    if (randInt == userInt){
        return true;
    }
    else{
        return false;
    }
}

Random rand = new Random();
int randInt = rand.Next(0, 10);

WriteLine("Digite um número: ");
int userInt = int.Parse(ReadLine());

while (!IsEqual(randInt, userInt)){
    Write("ERROU! Digite novamente: ");
    userInt = int.Parse(ReadLine());
}


// Instanciando novo objeto no stack

