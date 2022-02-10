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

static int[] ConvertToInt(ref string strValor){
    int length = strValor.ToString().Length;
    List<int> listaInt = new List<int>();
    
    for (int i = 0; i < length; i++)
    {
        if (strValor[i] >= '0' && strValor[i] <= '9'){
            string val = strValor[i].ToString();
            int num = int.Parse(val);
            listaInt.Add(num);
        }
    }
    int[] intArray = listaInt.ToArray();
    return intArray;
}

static int[] MultiplyArray(int[] arr1, int[] arr2){
    int[] newIntArray = new int[arr1.Length];
    for (int i = 0; i < arr1.Length; i++){
        newIntArray[i] = arr1[i] * arr2[i];
    }
    return newIntArray;
}

WriteLine("Digite os valores: ");
string[] strVetValores = ReadLine().Split("x");

string strValor1 = strVetValores[0];
string strValor2 = strVetValores[1];

try{
    int[] intVetValor1;
    int[] intVetValor2;
    int[] resultado;
    intVetValor1 = ConvertToInt(ref strValor1);
    intVetValor2 = ConvertToInt(ref strValor2);
    resultado = MultiplyArray(intVetValor1, intVetValor2);
    foreach (int i in resultado){
        Write($"{i} ");
    }
}
catch(Exception e){
    WriteLine($"Tamanho do vetores diferentes {e}");
}