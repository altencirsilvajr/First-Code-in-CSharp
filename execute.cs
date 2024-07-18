// public class Programa
// {
//     public static void Main(string[] args)
//     {
//         // Exemplo de uso para cada classe:

//         // Exercicio 1:
//         Produto produto = new Produto("Produto A", 10.0m, 100, 1);
//         produto.AdicionarItens(20);
//         produto.RemoverItens(10);
//         Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco}, Quantidade em Estoque: {produto.QuantidadeEmEstoque}");

//         // Exercicio 2:
//         RegistroDeCompras compra = new RegistroDeCompras(DateTime.Now, produto, 200.0m);
//         GerenciadorDeCompras gerenciadorDeCompras = new GerenciadorDeCompras();
//         gerenciadorDeCompras.AdicionarCompra(compra);
//         gerenciadorDeCompras.ListarCompras();

//         // Exercicio 3:
//         ProgramaCorretora.Main(args);

//         // Exercicio 4:
//         AgendaTelefonica agenda = new AgendaTelefonica();
//         agenda.AdicionarContato(new Contato("João", "12345678", "joao@exemplo.com"));
//         agenda.AdicionarContato(new Contato("Maria", "87654321", "maria@exemplo.com"));
//         agenda.ListarContatos();

//         // Exercicio 5:
//         GerenciadorDeTarefas gerenciadorDeTarefas = new GerenciadorDeTarefas();
//         gerenciadorDeTarefas.AdicionarTarefa(new Tarefa("Tarefa 1", DateTime.Now));
//         gerenciadorDeTarefas.AdicionarTarefa(new Tarefa("Tarefa 2", DateTime.Now.AddDays(1)));
//         gerenciadorDeTarefas.ListarTarefas();
//         gerenciadorDeTarefas.VerificarTarefasParaHoje();

//         // Exercicio 6:
//         GerenciadorDeProdutos gerenciadorDeProdutos = new GerenciadorDeProdutos();
//         gerenciadorDeProdutos.AdicionarProduto(produto);
//         gerenciadorDeProdutos.ListarProdutos();
//         Produto encontrado = gerenciadorDeProdutos.ConsultarProdutoPeloCodigo(1);
//         if (encontrado != null)
//         {
//             Console.WriteLine($"Produto encontrado: {encontrado.Nome}, Preço: {encontrado.Preco}");
//         }
//     }
// }
