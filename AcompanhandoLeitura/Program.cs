using static System.Console;
using AcompanhandoLeitura.Src.Entities;
/*
Acompanhamento leitura
Criar classes leitor e livro, O leitor ao ser criado deve ser automaticamente criado junto e adicionado a sua estante seu livro favorito. O método de remover livro deve remover da estante do leitor e zerar a quantidade de páginas lidas.
O método que verifica o progresso de leitura do livro deve retornar o valor percentual com relação a quantidade total de páginas arredondado para baixo. (Ex.: 85,3% = 85%).
Demonstrar todos os métodos instanciando livros e leitor, criando uma classe main para executar e imprimir todos os resultados de alterações dos métodos.
*/

WriteLine("Acompanhando leitura");
WriteLine();

Write("Digite o nome do Leitor: ");
string nome = ReadLine();

Write($"Livro favorito: ");
string titulo = ReadLine();

Write("Quantidade de páginas: ");
int qtdePaginas = int.Parse(ReadLine());

Livro livro = new Livro(titulo, qtdePaginas);

Leitor leitor = new Leitor(nome, livro) ;

Write("Páginas lidas: ");
livro.AdicionarPaginasLidas(int.Parse(ReadLine()));

WriteLine();

WriteLine($"Nome:{leitor.Nome}");
foreach (var obj in leitor.EstanteLivros){
    WriteLine($"TÍTULO: {obj.Titulo}, QTDE PÁGINAS: {obj.QtdPagina}, PÁGINAS LIDAS: {obj.PaginasLidas}, "
            + $"PROGRESSO: ({obj.VerificaProgresso().ToString("F0")}%)");
}

WriteLine();

WriteLine("Removendo livro estante...");
Thread.Sleep(1000);
leitor.RemoverLivro(livro);

if (leitor.EstanteLivros.Count() == 0){
    WriteLine("Estante, vazia.");
}