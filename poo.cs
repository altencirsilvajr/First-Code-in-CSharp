// // //1
// // using System;
// // using System.Collections.Generic;

// // public class Produto
// // {
// //     public string Nome { get; set; }
// //     public decimal Preco { get; set; }
// //     public int QuantidadeEmEstoque { get; set; }

// //     public Produto(string nome, decimal preco, int quantidadeEmEstoque)
// //     {
// //         Nome = nome;
// //         Preco = preco;
// //         QuantidadeEmEstoque = quantidadeEmEstoque;
// //     }

// //     public void AdicionarItens(int quantidade)
// //     {
// //         QuantidadeEmEstoque += quantidade;
// //     }

// //     public void RemoverItens(int quantidade)
// //     {
// //         if (QuantidadeEmEstoque >= quantidade)
// //         {
// //             QuantidadeEmEstoque -= quantidade;
// //         }
// //         else
// //         {
// //             Console.WriteLine("Quantidade insuficiente em estoque.");
// //         }
// //     }
// // }

// // //2
// // using System;
// // using System.Collections.Generic;

// // public class RegistroDeCompras
// // {
// //     public DateTime Data { get; set; }
// //     public Produto Produto { get; set; }
// //     public decimal Valor { get; set; }

// //     public RegistroDeCompras(DateTime data, Produto produto, decimal valor)
// //     {
// //         Data = data;
// //         Produto = produto;
// //         Valor = valor;
// //     }
// // }

// // public class GerenciadorDeCompras
// // {
// //     private List<RegistroDeCompras> compras = new List<RegistroDeCompras>();

// //     public void AdicionarCompra(RegistroDeCompras compra)
// //     {
// //         compras.Add(compra);
// //     }

// //     public void ListarCompras()
// //     {
// //         foreach (var compra in compras)
// //         {
// //             Console.WriteLine($"Data: {compra.Data}, Produto: {compra.Produto.Nome}, Valor: {compra.Valor}");
// //         }
// //     }
// // }

// // // 3
// // using System;
// // using System.Collections.Generic;

// // public class Imovel
// // {
// //     public string Endereco { get; set; }
// //     public decimal Preco { get; set; }
// //     public string Tipo { get; set; }

// //     public Imovel(string endereco, decimal preco, string tipo)
// //     {
// //         Endereco = endereco;
// //         Preco = preco;
// //         Tipo = tipo;
// //     }
// // }

// // public class CorretoraDeImoveis
// // {
// //     private List<Imovel> imoveis = new List<Imovel>();

// //     public void InserirImovel(Imovel imovel)
// //     {
// //         imoveis.Add(imovel);
// //     }

// //     public void AlterarPrecoImovel(string endereco, decimal novoPreco)
// //     {
// //         foreach (var imovel in imoveis)
// //         {
// //             if (imovel.Endereco == endereco)
// //             {
// //                 imovel.Preco = novoPreco;
// //                 return;
// //             }
// //         }
// //         Console.WriteLine("Imóvel não encontrado.");
// //     }

// //     public void ListarImoveis()
// //     {
// //         foreach (var imovel in imoveis)
// //         {
// //             Console.WriteLine($"Endereço: {imovel.Endereco}, Preço: {imovel.Preco}, Tipo: {imovel.Tipo}");
// //         }
// //     }

// //     public decimal CalcularValorMedio()
// //     {
// //         if (imoveis.Count == 0) return 0;

// //         decimal soma = 0;
// //         foreach (var imovel in imoveis)
// //         {
// //             soma += imovel.Preco;
// //         }
// //         return soma / imoveis.Count;
// //     }
// // }

// // public class ProgramaCorretora
// // {
// //     public static void Main(string[] args)
// //     {
// //         CorretoraDeImoveis corretora = new CorretoraDeImoveis();
// //         int opcao;
// //         do
// //         {
// //             Console.WriteLine("Menu:");
// //             Console.WriteLine("1 - Inserir Imóvel");
// //             Console.WriteLine("2 - Alterar Preço do Imóvel");
// //             Console.WriteLine("3 - Apresentar Todos os Imóveis");
// //             Console.WriteLine("4 - Sair");
// //             Console.Write("Escolha uma opção: ");
// //             opcao = int.Parse(Console.ReadLine());

// //             switch (opcao)
// //             {
// //                 case 1:
// //                     Console.Write("Endereço: ");
// //                     string endereco = Console.ReadLine();
// //                     Console.Write("Preço: ");
// //                     decimal preco = decimal.Parse(Console.ReadLine());
// //                     Console.Write("Tipo: ");
// //                     string tipo = Console.ReadLine();
// //                     corretora.InserirImovel(new Imovel(endereco, preco, tipo));
// //                     break;
// //                 case 2:
// //                     Console.Write("Endereço do imóvel para alterar o preço: ");
// //                     endereco = Console.ReadLine();
// //                     Console.Write("Novo Preço: ");
// //                     preco = decimal.Parse(Console.ReadLine());
// //                     corretora.AlterarPrecoImovel(endereco, preco);
// //                     break;
// //                 case 3:
// //                     corretora.ListarImoveis();
// //                     break;
// //                 case 4:
// //                     Console.WriteLine("Saindo...");
// //                     break;
// //                 default:
// //                     Console.WriteLine("Opção inválida.");
// //                     break;
// //             }
// //         } while (opcao != 4);
// //     }
// // }

// // // 4
// // using System;
// // using System.Collections.Generic;

// // public class Contato
// // {
// //     public string Nome { get; set; }
// //     public string Telefone { get; set; }
// //     public string Email { get; set; }

// //     public Contato(string nome, string telefone, string email)
// //     {
// //         Nome = nome;
// //         Telefone = telefone;
// //         Email = email;
// //     }
// // }

// // public class AgendaTelefonica
// // {
// //     private List<Contato> contatos = new List<Contato>();

// //     public void AdicionarContato(Contato contato)
// //     {
// //         contatos.Add(contato);
// //     }

// //     public void RemoverContato(string nome)
// //     {
// //         contatos.RemoveAll(c => c.Nome == nome);
// //     }

// //     public Contato BuscarContato(string nome)
// //     {
// //         return contatos.Find(c => c.Nome == nome);
// //     }

// //     public void ListarContatos()
// //     {
// //         foreach (var contato in contatos)
// //         {
// //             Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.Telefone}, Email: {contato.Email}");
// //         }
// //     }
// // }

// // // 5
// // using System;
// // using System.Collections.Generic;

// // public class Tarefa
// // {
// //     public string Descricao { get; set; }
// //     public DateTime DataVencimento { get; set; }

// //     public Tarefa(string descricao, DateTime dataVencimento)
// //     {
// //         Descricao = descricao;
// //         DataVencimento = dataVencimento;
// //     }

// //     public bool DeveriaExecutarHoje()
// //     {
// //         return DataVencimento.Date == DateTime.Today;
// //     }
// // }

// // public class GerenciadorDeTarefas
// // {
// //     private List<Tarefa> tarefas = new List<Tarefa>();

// //     public void AdicionarTarefa(Tarefa tarefa)
// //     {
// //         tarefas.Add(tarefa);
// //     }

// //     public void RemoverTarefa(string descricao)
// //     {
// //         tarefas.RemoveAll(t => t.Descricao == descricao);
// //     }

// //     public void ListarTarefas()
// //     {
// //         foreach (var tarefa in tarefas)
// //         {
// //             Console.WriteLine($"Descrição: {tarefa.Descricao}, Data de Vencimento: {tarefa.DataVencimento.ToShortDateString()}");
// //         }
// //     }

// //     public void VerificarTarefasParaHoje()
// //     {
// //         foreach (var tarefa in tarefas)
// //         {
// //             if (tarefa.DeveriaExecutarHoje())
// //             {
// //                 Console.WriteLine($"Tarefa para hoje: {tarefa.Descricao}");
// //             }
// //         }
// //     }
// // }

// // // 6
// // using System;
// // using System.Collections.Generic;

// // public class Produto
// // {
// //     public string Nome { get; set; }
// //     public decimal Preco { get; set; }
// //     public int QuantidadeEmEstoque { get; set; }
// //     public int Codigo { get; set; }

// //     public Produto(string nome, decimal preco, int quantidadeEmEstoque, int codigo)
// //     {
// //         Nome = nome;
// //         Preco = preco;
// //         QuantidadeEmEstoque = quantidadeEmEstoque;
// //         Codigo = codigo;
// //     }

// //     public void AdicionarItens(int quantidade)
// //     {
// //         QuantidadeEmEstoque += quantidade;
// //     }

// //     public void RemoverItens(int quantidade)
// //     {
// //         if (QuantidadeEmEstoque >= quantidade)
// //         {
// //             QuantidadeEmEstoque -= quantidade;
// //         }
// //         else
// //         {
// //             Console.WriteLine("Quantidade insuficiente em estoque.");
// //         }
// //     }
// // }

// // public class GerenciadorDeProdutos
// // {
// //     private List<Produto> produtos = new List<Produto>();

// //     public void AdicionarProduto(Produto produto)
// //     {
// //         produtos.Add(produto);
// //     }

// //     public void ListarProdutos()
// //     {
// //         foreach (var produto in produtos)
// //         {
// //             Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Preço: {produto.Preco}, Quantidade em Estoque: {produto.QuantidadeEmEstoque}");
// //         }
// //     }

// //     public Produto ConsultarProdutoPeloCodigo(int codigo)
// //     {
// //         return produtos.Find(p => p.Codigo == codigo);
// //     }
// // }

// // 7
// using System;
// using System.Collections.Generic;

// public class Musica
// {
//     public string Nome { get; set; }
//     public string Autor { get; set; }
//     public string Gravadora { get; set; }

//     public Musica(string nome, string autor, string gravadora)
//     {
//         Nome = nome;
//         Autor = autor;
//         Gravadora = gravadora;
//     }
// }

// public class Playlist
// {
//     public List<Musica> Musicas { get; set; } = new List<Musica>();
//     public string Dono { get; set; }

//     public Playlist(string dono)
//     {
//         Dono = dono;
//     }

//     public void AdicionarMusica(Musica musica)
//     {
//         Musicas.Add(musica);
//     }

//     public void TocarMusica()
//     {
//         if (Musicas.Count == 0)
//         {
//             Console.WriteLine("A playlist está vazia.");
//             return;
//         }

//         Random rand = new Random();
//         int index = rand.Next(Musicas.Count);
//         Console.WriteLine($"Tocando: {Musicas[index].Nome} - {Musicas[index].Autor}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Playlist playlist = new Playlist("João");

//         playlist.AdicionarMusica(new Musica("Música 1", "Autor 1", "Gravadora 1"));
//         playlist.AdicionarMusica(new Musica("Música 2", "Autor 2", "Gravadora 2"));

//         playlist.TocarMusica();
//         playlist.TocarMusica();
//     }
// }

// // 8
// using System;

// public class Fabricante
// {
//     public string Nome { get; set; }
//     public string Endereco { get; set; }
//     public string Cidade { get; set; }

//     public Fabricante(string nome, string endereco, string cidade)
//     {
//         Nome = nome;
//         Endereco = endereco;
//         Cidade = cidade;
//     }
// }

// public class Produto
// {
//     private string nome;
//     private decimal preco;

//     public string Nome
//     {
//         get { return nome; }
//         set
//         {
//             if (string.IsNullOrWhiteSpace(value))
//                 throw new ArgumentException("O nome não pode ser vazio.");
//             nome = value;
//         }
//     }

//     public Fabricante Fabricante { get; set; }

//     public decimal Preco
//     {
//         get { return preco; }
//         set
//         {
//             if (value <= 0)
//                 throw new ArgumentException("O preço deve ser positivo.");
//             preco = value;
//         }
//     }

//     public Produto(string nome, Fabricante fabricante, decimal preco)
//     {
//         Nome = nome;
//         Fabricante = fabricante;
//         Preco = preco;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Fabricante fabricante = new Fabricante("Fabricante 1", "Rua 1", "Cidade 1");
//         Produto produto = new Produto("Produto 1", fabricante, 10.0m);

//         Console.WriteLine($"Produto: {produto.Nome}, Fabricante: {produto.Fabricante.Nome}, Preço: {produto.Preco}");
//     }
// }

// // 9
// using System;

// public class Livro
// {
//     private string titulo;
//     private string autor;

//     public string Titulo
//     {
//         get { return titulo; }
//         set
//         {
//             if (string.IsNullOrWhiteSpace(value))
//                 throw new ArgumentException("O título não pode ser vazio.");
//             titulo = value;
//         }
//     }

//     public string Autor
//     {
//         get { return autor; }
//         set
//         {
//             if (string.IsNullOrWhiteSpace(value))
//                 throw new ArgumentException("O autor não pode ser vazio.");
//             autor = value;
//         }
//     }

//     public Livro(string titulo, string autor)
//     {
//         Titulo = titulo;
//         Autor = autor;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Livro livro = new Livro("Título 1", "Autor 1");
//         Console.WriteLine($"Livro: {livro.Titulo}, Autor: {livro.Autor}");
//     }
// }

// // 10
// using System;

// public class Livro
// {
//     private string titulo;
//     private string autor;

//     public string Titulo
//     {
//         get { return titulo; }
//         set
//         {
//             if (string.IsNullOrWhiteSpace(value))
//                 throw new ArgumentException("O título não pode ser vazio.");
//             titulo = value;
//         }
//     }

//     public string Autor
//     {
//         get { return autor; }
//         set
//         {
//             if (string.IsNullOrWhiteSpace(value))
//                 throw new ArgumentException("O autor não pode ser vazio.");
//             autor = value;
//         }
//     }

//     public Livro(string titulo, string autor)
//     {
//         Titulo = titulo;
//         Autor = autor;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Livro livro = new Livro("Título 1", "Autor 1");
//         Console.WriteLine($"Livro: {livro.Titulo}, Autor: {livro.Autor}");
//     }
// }

// // 11
// using System;

// public class Carro
// {
//     public string Modelo { get; set; }
//     public int Ano { get; set; }
//     public int Velocidade { get; set; }

//     public void Acelerar()
//     {
//         Velocidade += 10;
//         Console.WriteLine($"Acelerando... Velocidade atual: {Velocidade} km/h");
//     }

//     public void Frear()
//     {
//         Velocidade = Math.Max(0, Velocidade - 10);
//         Console.WriteLine($"Freando... Velocidade atual: {Velocidade} km/h");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Carro carro = new Carro { Modelo = "Modelo 1", Ano = 2020, Velocidade = 0 };
//         carro.Acelerar();
//         carro.Frear();
//     }
// }

// // 12
// using System;
// using System.Collections.Generic;

// public class Pessoa
// {
//     public string Nome { get; set; }
//     public int Idade { get; set; }
//     public float Altura { get; set; }

//     public Pessoa(string nome, int idade, float altura)
//     {
//         Nome = nome;
//         Idade = idade;
//         Altura = altura;
//     }
// }

// public class Agenda
// {
//     private List<Pessoa> pessoas = new List<Pessoa>();

//     public void ArmazenaPessoa(string nome, int idade, float altura)
//     {
//         pessoas.Add(new Pessoa(nome, idade, altura));
//     }

//     public void RemovePessoa(string nome)
//     {
//         pessoas.RemoveAll(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
//     }

//     public Pessoa BuscaPessoa(string nome)
//     {
//         return pessoas.Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
//     }

//     public void ImprimeAgenda()
//     {
//         foreach (var pessoa in pessoas)
//         {
//             Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Altura: {pessoa.Altura}");
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Agenda agenda = new Agenda();
//         string opcao;

//         do
//         {
//             Console.WriteLine("Menu:");
//             Console.WriteLine("1. Armazenar Pessoa");
//             Console.WriteLine("2. Remover Pessoa");
//             Console.WriteLine("3. Buscar Pessoa");
//             Console.WriteLine("4. Imprimir Agenda");
//             Console.WriteLine("5. Sair");
//             Console.Write("Escolha uma opção: ");
//             opcao = Console.ReadLine();

//             switch (opcao)
//             {
//                 case "1":
//                     Console.Write("Nome: ");
//                     string nome = Console.ReadLine();
//                     Console.Write("Idade: ");
//                     int idade = int.Parse(Console.ReadLine());
//                     Console.Write("Altura: ");
//                     float altura = float.Parse(Console.ReadLine());
//                     agenda.ArmazenaPessoa(nome, idade, altura);
//                     break;
//                 case "2":
//                     Console.Write("Nome: ");
//                     nome = Console.ReadLine();
//                     agenda.RemovePessoa(nome);
//                     break;
//                 case "3":
//                     Console.Write("Nome: ");
//                     nome = Console.ReadLine();
//                     Pessoa pessoa = agenda.BuscaPessoa(nome);
//                     if (pessoa != null)
//                     {
//                         Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Altura: {pessoa.Altura}");
//                     }
//                     else
//                     {
//                         Console.WriteLine("Pessoa não encontrada.");
//                     }
//                     break;
//                 case "4":
//                     agenda.ImprimeAgenda();
//                     break;
//                 case "5":
//                     Console.WriteLine("Saindo...");
//                     break;
//                 default:
//                     Console.WriteLine("Opção inválida.");
//                     break;
//             }
//         } while (opcao != "5");
//     }
// }
