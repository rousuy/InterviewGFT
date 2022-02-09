using System;
using teste.Entities.JogoRpg;
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

/*
Multiplicando arrays

Criar um método que realiza a multiplicação de dois arrays e seus resultados são
armazenados gerando um novo array.
O programa deve validar se os arrays são do mesmo tamanho, caso não sejam, deve gerar
uma exceção personalizada informando o erro.
Usar inputs abaixo e imprimir no console os resultados.
[10, 5, 98, 452] x [10, 5, 98, 452]
[548, 213, 10] x [5, 21, 12]
[50, 60, 70] x [5, 21, 12]
[60, 70] x [1, 2, 3]
*/


String[] strVet = ReadLine().Split(" ");

int length = strVet.ToString().Length;

int[] intVet = new int[length];
for (int i = 0; i < length; i++){
    intVet[i] = int.Parse(strVet[i]);
}




// Mago mago = new Mago("Mago Bruxo", 43, 5);