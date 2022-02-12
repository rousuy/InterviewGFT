using static System.Console;
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

WriteLine("Multiplicando Arrays, com tratamento de excessões: ");
WriteLine();

static int[] MultiplyVet( int[] arrayF, int[] arrayJ){
    try{
        int[] result = new int[arrayJ.Length];
        for (int i = 0; i < result.Length; i++){       
            result[i] = arrayF[i] * arrayJ[i];
            if (i == 0)
                Write($"[{result[i]}, ");
            else if (i == arrayJ.Length - 1)
                Write($"{result[i]}]");
            else
                Write($"{result[i]}, ");
        }
        WriteLine();
        return result;
    }
    catch(Exception e){
        WriteLine();
        WriteLine($"Tamanho dos vetores diferentes! Erro: {e}");
    }
    return null;
}
int[] vet1 = new int[4] {10, 5, 98, 452};
int[] vet2 = new int[4] {10, 5, 98, 452};

int[] vetA = new int[3] {548, 213, 10};
int[] vetB = new int[3] {5, 21, 12};

int[] vetFoo = new int[3] {50, 60, 70};
int[] vetBar = new int[3] {5, 21, 12 };

int[] vetX = new int[2] {60, 70};
int[] vetY = new int[3] {1, 2, 3};

int[] array1 = MultiplyVet(vet1, vet2);
int[] array2 = MultiplyVet(vetA, vetB);
int[] array3 = MultiplyVet(vetFoo, vetBar);
int[] array4 = MultiplyVet(vetX, vetY);