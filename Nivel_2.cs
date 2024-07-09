//11)
// Console.WriteLine("Insira o valor do parâmetro A:");
// int value_A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insira o valor do parâmetro B:");
// int value_B = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"\nValores antes da troca A={value_A} // B={value_B}"); // A=2, B=4
// int convert_a = value_A; // convert_a = 2
// int convert_b = value_B; // convert_b = 4

// value_A = convert_b; // value_A = 4
// value_B = convert_a; // value_B = 2

// Console.WriteLine($"\nValores depois da troca A={value_A},B={value_B}");

//12)
// Console.Write("Insira um número inteiro: ");

// int numero = Convert.ToInt32(Console.ReadLine());
// int modulo = Math.Abs(numero);

// Console.WriteLine($"O módulo de {numero} é:{modulo}");

//13)
// int first, second, third;

// Console.Write("Insira o primeiro número inteiro: ");
// first = Convert.ToInt32(Console.ReadLine());

// Console.Write("Insira o segundo número inteiro: ");
// second = Convert.ToInt32(Console.ReadLine());

// Console.Write("Insira o terceiro número inteiro: ");
// third = Convert.ToInt32(Console.ReadLine());

// int[] numbers = [first, second, third];

// Array.Sort(numbers);
// Array.Reverse(numbers);

// Console.WriteLine($"Números em ordem decrescente: {numbers[0]}, {numbers[1]}, {numbers[2]}");

//14)

// while (true)
// {
//     Console.WriteLine("Insira o primeiro número:");
//     if (!double.TryParse(Console.ReadLine(), out double convertNumber))
//     {
//         Console.WriteLine("Não foi possível converter para um valor válido, tente novamente:");
//         continue;
//     }
//     Console.WriteLine("Insira o segundo número:");
//     if (!double.TryParse(Console.ReadLine(), out double convertNumber_2))
//     {
//         Console.WriteLine("Não foi possível converter para um valor válido, tente novamente:");
//         continue;
//     }
//     try
//     {
//         double result = convertNumber - convertNumber_2;
//         Console.WriteLine($"O resultado da diferença entre {convertNumber} e {convertNumber_2} é: {result}");
//         Console.WriteLine("\nPressione 'y' para CONTINUAR ou qualquer outra tecla para SAIR...");
//         char control = char.Parse(Console.ReadLine()!.ToLower());

//         if (control != 'y')
//         {
//             Console.Clear();
//             Console.WriteLine("Fim da execução");
//             break;
//         } else {
//             Console.Clear();
//         }
//     }
//     catch (Exception exception)
//     {
//         Console.WriteLine($"Ocorreu um erro: {exception.Message}"); // Qual o erro;
//         Console.WriteLine($"\nStack {exception.StackTrace}"); // Indica o local do erro;
//     }
// }

//15

// double[] notas = new double[4];
// for (int i = 0; i < 4; i++)
// {
//     Console.Write($"Digite a nota {i + 1}: ");
//     notas[i] = Convert.ToDouble(Console.ReadLine());
// }

// double media = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;
// Console.WriteLine($"Média: {media}");

// if (media >= 7)
// {
//     Console.WriteLine("Aluno aprovado.");
// }
// else
// {
//     Console.Write("Digite a nota de recuperação: ");
//     double notaRecuperacao = Convert.ToDouble(Console.ReadLine());
//     double novaMedia = (media + notaRecuperacao) / 2;

//     Console.WriteLine($"Nova Média: {novaMedia}");

//     if (novaMedia >= 7)
//     {
//         Console.WriteLine("Aluno aprovado na recuperação.");
//     }
//     else
//     {
//         Console.WriteLine("Aluno reprovado.");
//     }
// }

//16)

// Console.Write("Digite o primeiro número: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Digite o segundo número: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine($"Maior número: {num1}");
//     Console.WriteLine($"Menor número: {num2}");
// }
// else if (num2 > num1)
// {
//     Console.WriteLine($"Maior número: {num2}");
//     Console.WriteLine($"Menor número: {num1}");
// }
// else
// {
//     Console.WriteLine("Os números são iguais.");
// }

// 17)

// Console.Write("Digite um número inteiro: ");
// int numero = Convert.ToInt32(Console.ReadLine());

// if (numero >= 0 && numero <= 9)
// {
//     Console.WriteLine("Valor válido.");
// }
// else
// {
//     Console.WriteLine("Valor inválido.");
// }

// 18)

// Console.Write("Digite um código (1, 2 ou 3): ");
// int codigo = Convert.ToInt32(Console.ReadLine());

// switch (codigo)
// {
//     case 1:
//         Console.WriteLine("um");
//         break;
//     case 2:
//         Console.WriteLine("dois");
//         break;
//     case 3:
//         Console.WriteLine("três");
//         break;
//     default:
//         Console.WriteLine("Código inválido.");
//         break;
// }

// 19)

// Console.Write("Digite o lado A: ");
// double A = Convert.ToDouble(Console.ReadLine());

// Console.Write("Digite o lado B: ");
// double B = Convert.ToDouble(Console.ReadLine());

// Console.Write("Digite o lado C: ");
// double C = Convert.ToDouble(Console.ReadLine());

// if (A < B + C && B < A + C && C < A + B)
// {
//     if (A == B && B == C)
//     {
//         Console.WriteLine("Triângulo equilátero.");
//     }
//     else if (A == B || A == C || B == C)
//     {
//         Console.WriteLine("Triângulo isósceles.");
//     }
//     else
//     {
//         Console.WriteLine("Triângulo escaleno.");
//     }
// }
// else
// {
//     Console.WriteLine("Os lados fornecidos não formam um triângulo.");
// }

//20)

// int a, b, c;

// a = LerValor("Digite o valor de A: ");
// b = LerValor("Digite o valor de B: ");
// c = LerValor("Digite o valor de C: ");

// int menor = Math.Min(a, Math.Min(b, c));
// int maior = Math.Max(a, Math.Max(b, c));

// Console.WriteLine($"Menor valor lido multiplicado pelo maior: {menor * maior}");
// Console.WriteLine($"Maior valor dividido pelo menor: {(double)maior / menor}");

//21)

// while (true)
// {
//     Console.Write("Digite um número inteiro (ou 'sair' para encerrar): ");
//     string input = Console.ReadLine();

//     if (input.ToLower() == "sair")
//     {
//         break;
//     }

//     int numero = Convert.ToInt32(input);

//     if (numero >= 0)
//     {
//         Console.WriteLine("Número positivo.");
//     }
//     else
//     {
//         Console.WriteLine("Número negativo.");
//     }
// }

//22)

// Console.Write("Digite um número: ");
// int numero = Convert.ToInt32(Console.ReadLine());

// int A = 0, B = 0;

// if (numero >= 0)
// {
//     A = numero;
// }
// else
// {
//     B = numero;
// }

// Console.WriteLine($"Resultado em A: {A}");
// Console.WriteLine($"Resultado em B: {B}");

//23)

// Console.WriteLine("Escolha uma operação:");
// Console.WriteLine("1 – Adição");
// Console.WriteLine("2 – Subtração");
// Console.WriteLine("3 – Multiplicação");
// Console.WriteLine("4 – Divisão");

// int opcao = int.Parse(Console.ReadLine());

// Console.Write("Digite o primeiro número: ");
// double num1 = double.Parse(Console.ReadLine());

// Console.Write("Digite o segundo número: ");
// double num2 = double.Parse(Console.ReadLine());

// switch (opcao)
// {
//     case 1:
//         Console.WriteLine($"Resultado: {num1 + num2}");
//         break;
//     case 2:
//         Console.WriteLine($"Resultado: {num1 - num2}");
//         break;
//     case 3:
//         Console.WriteLine($"Resultado: {num1 * num2}");
//         break;
//     case 4:
//         if (num2 != 0)
//         {
//             Console.WriteLine($"Resultado: {num1 / num2}");
//         }
//         else
//         {
//             Console.WriteLine("Divisão por zero não é permitida.");
//         }
//         break;
//     default:
//         Console.WriteLine("Opção inválida.");
//         break;
// }

//24)

// Console.Write("Digite o primeiro número inteiro: ");
// int num1 = int.Parse(Console.ReadLine());

// Console.Write("Digite o segundo número inteiro: ");
// int num2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Escolha uma opção:");
// Console.WriteLine("1 – Verificar se um dos números é múltiplo do outro");
// Console.WriteLine("2 – Verificar se os dois números são pares");
// Console.WriteLine("3 – Verificar se a média dos dois números é maior ou igual a 7");
// Console.WriteLine("4 – Sair");

// int opcao = int.Parse(Console.ReadLine());

// switch (opcao)
// {
//     case 1:
//         if (num1 % num2 == 0 || num2 % num1 == 0)
//         {
//             Console.WriteLine("Um dos números é múltiplo do outro.");
//         }
//         else
//         {
//             Console.WriteLine("Nenhum dos números é múltiplo do outro.");
//         }
//         break;
//     case 2:
//         if (num1 % 2 == 0 && num2 % 2 == 0)
//         {
//             Console.WriteLine("Ambos os números são pares.");
//         }
//         else
//         {
//             Console.WriteLine("Os dois números não são pares.");
//         }
//         break;
//     case 3:
//         double media = (num1 + num2) / 2.0;
//         if (media >= 7)
//         {
//             Console.WriteLine("A média dos dois números é maior ou igual a 7.");
//         }
//         else
//         {
//             Console.WriteLine("A média dos dois números é menor que 7.");
//         }
//         break;
//     case 4:
//         Console.WriteLine("Saindo...");
//         break;
//     default:
//         Console.WriteLine("Opção inválida.");
//         break;
// }

//25)

// Console.Write("Digite a altura (em metros): ");
// double altura = double.Parse(Console.ReadLine());

// Console.Write("Digite o sexo (M para masculino, F para feminino): ");
// char sexo = char.Parse(Console.ReadLine().ToUpper());

// double pesoIdeal;

// if (sexo == 'M')
// {
//     pesoIdeal = (72.7 * altura) - 58;
// }
// else if (sexo == 'F')
// {
//     pesoIdeal = (62.1 * altura) - 44.7;
// }
// else
// {
//     Console.WriteLine("Sexo inválido.");
//     return;
// }

// Console.WriteLine($"O peso ideal é: {pesoIdeal:F2} kg");

//26)
//  for (int i = 100; i >= 1; i--)
//         {
//             Console.WriteLine(i);
//         }

//27)
// Console.Write("Quantos números deseja processar? ");
//         int quantidade = int.Parse(Console.ReadLine());

//         for (int i = 0; i < quantidade; i++)
//         {
//              if (n == 0) return 1;
//              long resultado = 1;
//              for (int i = 1; i <= n; i++)
//          {
//              resultado *= i;
//          }
//              return resultado;
//             Console.Write("Digite um número: ");
//             int numero = int.Parse(Console.ReadLine());
//             Console.WriteLine($"Fatorial de {numero} é {resultado}");
//         }


//28)

// Console.WriteLine("Digite números entre 100 e 200 (digite um número fora desse intervalo para terminar):");
//         while (true)
//         {
//             int numero = int.Parse(Console.ReadLine());
//             if (numero < 100 || numero > 200) break;
//             if (numero % 2 != 0)
//             {
//                 Console.WriteLine(numero);
//             }
//         }

//29)

// for (int i = 1; i <= 2000; i++)
//         {
//             Console.WriteLine(i);
//         }

//30)

// Console.Write("Digite um número para ver a tabuada: ");
//         int numero = int.Parse(Console.ReadLine());

//         for (int i = 1; i <= 10; i++)
//         {
//             Console.WriteLine($"{numero} x {i} = {numero * i}");
//         }

//31)
// int somaPares = 0;
// int somaImpares = 0;

// while (true)
// {
//     Console.Write("Digite um número positivo (ou um número negativo para sair): ");
//     int numero = int.Parse(Console.ReadLine());
//     if (numero < 0) break;

//     if (numero % 2 == 0)
//     {
//         somaPares += numero;
//         Console.WriteLine($"{numero} é par.");
//     }
//     else
//     {
//         somaImpares += numero;
//         Console.WriteLine($"{numero} é ímpar.");
//     }
// }

// Console.WriteLine($"Soma dos números pares: {somaPares}");
// Console.WriteLine($"Soma dos números ímpares: {somaImpares}");

//32)

// Console.Write("Digite um número maior que 0 e menor que 10: ");
//         int numero = int.Parse(Console.ReadLine());

//         if (numero <= 0 || numero >= 10)
//         {
//             Console.WriteLine("Número inválido.");
//             return;
//         }

//         int soma = 0;
//         int contador = 0;

//         for (int i = numero; contador < 20; i++)
//         {
//             if (i % 2 != 0)
//             {
//                 soma += i * i;
//                 contador++;
//             }
//         }

//         Console.WriteLine($"A soma dos quadrados dos 20 primeiros números ímpares a partir de {numero} é {soma}");

//33)

//  int quantidade = 0;
//         double somaNotas = 0;

//         while (true)
//         {
//             Console.Write("Digite o número de matrícula do aluno (ou 0 para sair): ");
//             int matricula = int.Parse(Console.ReadLine());
//             if (matricula == 0) break;

//             Console.Write("Digite a nota do aluno: ");
//             double nota = double.Parse(Console.ReadLine());

//             somaNotas += nota;
//             quantidade++;
//         }

//         if (quantidade > 0)
//         {
//             double media = somaNotas / quantidade;
//             Console.WriteLine($"A média da turma é {media:F2}");
//         }
//         else
//         {
//             Console.WriteLine("Nenhuma nota foi registrada.");
//         }

//34)
// int menor = int.MaxValue;
//         int maior = int.MinValue;

//         while (true)
//         {
//             Console.Write("Digite um número positivo (ou um número negativo para sair): ");
//             int numero = int.Parse(Console.ReadLine());
//             if (numero < 0) break;

//             if (numero > maior) maior = numero;
//             if (numero < menor) menor = numero;
//         }

//         if (menor != int.MaxValue && maior != int.MinValue)
//         {
//             Console.WriteLine($"Menor número: {menor}");
//             Console.WriteLine($"Maior número: {maior}");
//         }
//         else
//         {
//             Console.WriteLine("Nenhum número positivo foi registrado.");
//         }

//35)

// for (int i = 1; i <= 100; i++)
//         {
//             if (i % 10 == 0)
//             {
//                 Console.WriteLine($"{i} - Múltiplo de 10");
//             }
//             else
//             {
//                 Console.WriteLine(i);
//             }
//         }

//36)

// int[] valores = new int[10];
//         for (int i = 0; i < 10; i++)
//         {
//             Console.Write($"Digite o valor {i + 1}: ");
//             valores[i] = int.Parse(Console.ReadLine());
//         }

//         int maior = valores[0];
//         int menor = valores[0];
//         int soma = 0;

//         foreach (int valor in valores)
//         {
//             if (valor > maior) maior = valor;
//             if (valor < menor) menor = valor;
//             soma += valor;
//         }

//         double media = (double)soma / valores.Length;

//         Console.WriteLine($"Maior valor: {maior}");
//         Console.WriteLine($"Menor valor: {menor}");
//         Console.WriteLine($"Média dos valores: {media:F2}");

//37)
// bool continuar = true;
//         while (continuar)
//         {
//             Console.WriteLine("Escolha uma operação:");
//             Console.WriteLine("1 – Adição");
//             Console.WriteLine("2 – Subtração");
//             Console.WriteLine("3 – Multiplicação");
//             Console.WriteLine("4 – Divisão");
//             Console.Write("Informe a opção: ");
//             int opcao = int.Parse(Console.ReadLine());

//             Console.Write("Digite o primeiro número: ");
//             double num1 = double.Parse(Console.ReadLine());
//             Console.Write("Digite o segundo número: ");
//             double num2 = double.Parse(Console.ReadLine());

//             double resultado = 0;
//             switch (opcao)
//             {
//                 case 1:
//                     resultado = num1 + num2;
//                     break;
//                 case 2:
//                     resultado = num1 - num2;
//                     break;
//                 case 3:
//                     resultado = num1 * num2;
//                     break;
//                 case 4:
//                     if (num2 != 0)
//                     {
//                         resultado = num1 / num2;
//                     }
//                     else
//                     {
//                         Console.WriteLine("Divisão por zero não é permitida.");
//                     }
//                     break;
//                 default:
//                     Console.WriteLine("Opção inválida.");
//                     break;
//             }

//             Console.WriteLine("Resultado: " + resultado);

//             Console.Write("Deseja voltar ao menu principal? (S/N): ");
//             string resposta = Console.ReadLine();
//             if (resposta.ToUpper() != "S")
//             {
//                 continuar = false;
//             }
//         }

// 38)

// bool continuar = true;
//         while (continuar)
//         {
//             Console.Write("Digite o código do operário: ");
//             int codigo = int.Parse(Console.ReadLine());
//             Console.Write("Digite o número de horas trabalhadas: ");
//             int horasTrabalhadas = int.Parse(Console.ReadLine());

//             double salarioBase = 10.0;
//             double salarioExcedente = 0;
//             int horasExcedentes = horasTrabalhadas - 50;

//             if (horasExcedentes > 0)
//             {
//                 salarioExcedente = horasExcedentes * 20.0;
//             }

//             double salarioTotal = (horasTrabalhadas * salarioBase) + salarioExcedente;

//             Console.WriteLine("Salário Total: R$ " + salarioTotal);
//             Console.WriteLine("Salário Excedente: R$ " + salarioExcedente);

//             Console.Write("Deseja encerrar o programa? (S/N): ");
//             string resposta = Console.ReadLine();
//             if (resposta.ToUpper() == "S")
//             {
//                 continuar = false;
//             }

//39)

// bool continuar = true;
//         while (continuar)
//         {
//             Console.Write("Digite um número inteiro: ");
//             int numero = int.Parse(Console.ReadLine());

//             string paridade = (numero % 2 == 0) ? "par" : "ímpar";
//             string sinal = (numero >= 0) ? "positivo" : "negativo";

//             Console.WriteLine("O número é " + paridade + " e " + sinal);

//             Console.Write("Deseja encerrar o programa? (S/N): ");
//             string resposta = Console.ReadLine();
//             if (resposta.ToUpper() == "S")
//             {
//                 continuar = false;
//             }
//         }

//40)

// bool continuar = true;
//         while (continuar)
//         {
//             Console.Write("Digite o índice de poluição: ");
//             double indice = double.Parse(Console.ReadLine());

//             if (indice >= 0.05 && indice <= 0.25)
//             {
//                 Console.WriteLine("Índice de poluição dentro do aceitável.");
//             }
//             else if (indice > 0.25 && indice < 0.3)
//             {
//                 Console.WriteLine("Índice de poluição ligeiramente elevado.");
//             }
//             else if (indice >= 0.3 && indice < 0.4)
//             {
//                 Console.WriteLine("As indústrias do 1º grupo devem suspender suas atividades.");
//             }
//             else if (indice >= 0.4 && indice < 0.5)
//             {
//                 Console.WriteLine("As indústrias do 1º e 2º grupo devem suspender suas atividades.");
//             }
//             else if (indice >= 0.5)
//             {
//                 Console.WriteLine("Todas as indústrias devem suspender suas atividades.");
//             }
//             else
//             {
//                 Console.WriteLine("Índice de poluição inválido.");
//             }

//             Console.Write("Deseja encerrar o programa? (S/N): ");
//             string resposta = Console.ReadLine();
//             if (resposta.ToUpper() == "S")
//             {
//                 continuar = false;
//             }

//41)

// Console.Write("Digite a idade do nadador: ");
//         int idade = int.Parse(Console.ReadLine());

//         if (idade >= 5 && idade <= 7)
//         {
//             Console.WriteLine("Categoria: Infantil A");
//         }
//         else if (idade >= 8 && idade <= 11)
//         {
//             Console.WriteLine("Categoria: Infantil B");
//         }
//         else if (idade >= 12 && idade <= 13)
//         {
//             Console.WriteLine("Categoria: Juvenil A");
//         }
//         else if (idade >= 14 && idade <= 17)
//         {
//             Console.WriteLine("Categoria: Juvenil B");
//         }
//         else if (idade >= 18)
//         {
//             Console.WriteLine("Categoria: Adulto");
//         }
//         else
//         {
//             Console.WriteLine("Idade fora das categorias válidas.");
//         }

//42)

// int maior = int.MinValue;
//         int menor = int.MaxValue;

//         while (true)
//         {
//             Console.Write("Digite um número (ou 0 para encerrar): ");
//             int numero = int.Parse(Console.ReadLine());

//             if (numero == 0)
//             {
//                 break;
//             }

//             if (numero > maior)
//             {
//                 maior = numero;
//             }

//             if (numero < menor)
//             {
//                 menor = numero;
//             }
//         }

//         Console.WriteLine("Maior número: " + maior);
//         Console.WriteLine("Menor número: " + menor);

// //43)
// BigInteger graos = 1;
//         BigInteger totalGraos = 0;

//         for (int i = 1; i <= 64; i++)
//         {
//             totalGraos += graos;
//             graos *= 2;
//         }

//         Console.WriteLine("Número total de grãos: " + totalGraos);

//44)

// bool continuar = true;
//         while (continuar)
//         {
//             Console.WriteLine("Escolha uma opção:");
//             Console.WriteLine("1 – Conversão de Graus Celsius em Graus Fahrenheit");
//             Console.WriteLine("2 – Conversão de Graus Fahrenheit em Graus Celsius");
//             Console.WriteLine("3 – Peso ideal do homem");
//             Console.WriteLine("4 – Peso ideal da mulher");
//             Console.Write("Informe a opção: ");
//             int opcao = int.Parse(Console.ReadLine());

//             switch (opcao)
//             {
//                 case 1:
//                     Console.Write("Digite a temperatura em Graus Celsius: ");
//                     double celsius = double.Parse(Console.ReadLine());
//                     double fahrenheit = (celsius * 9 / 5) + 32;
//                     Console.WriteLine("Temperatura em Graus Fahrenheit: " + fahrenheit);
//                     break;
//                 case 2:
//                     Console.Write("Digite a temperatura em Graus Fahrenheit: ");
//                     fahrenheit = double.Parse(Console.ReadLine());
//                     celsius = (fahrenheit - 32) * 5 / 9;
//                     Console.WriteLine("Temperatura em Graus Celsius: " + celsius);
//                     break;
//                 case 3:
//                     Console.Write("Digite a altura em metros: ");
//                     double alturaHomem = double.Parse(Console.ReadLine());
//                     double pesoIdealHomem = (72.7 * alturaHomem) - 58;
//                     Console.WriteLine("Peso ideal do homem: " + pesoIdealHomem);
//                     break;
//                 case 4:
//                     Console.Write("Digite a altura em metros: ");
//                     double alturaMulher = double.Parse(Console.ReadLine());
//                     double pesoIdealMulher = (62.1 * alturaMulher) - 44.7;
//                     Console.WriteLine("Peso ideal da mulher: " + pesoIdealMulher);
//                     break;
//                 default:
//                     Console.WriteLine("Opção inválida.");
//                     break;
//             }
//         }

//45)

//   Console.Write("Digite o tamanho do vetor: ");
//         int n = int.Parse(Console.ReadLine());
//         int[] numeros = new int[n];

//         Console.WriteLine("Digite os números do vetor:");
//         for (int i = 0; i < n; i++)
//         {
//             numeros[i] = int.Parse(Console.ReadLine());
//         }

//         Console.WriteLine("Vetor na ordem inversa:");
//         for (int i = n - 1; i >= 0; i--)
//         {
//             Console.WriteLine(numeros[i]);
//         }

//46)

// Console.Write("Digite o tamanho dos vetores: ");
//         int n = int.Parse(Console.ReadLine());
//         int[] x = new int[n];
//         int[] y = new int[n];

//         Console.WriteLine("Digite os elementos do vetor x:");
//         for (int i = 0; i < n; i++)
//         {
//             x[i] = int.Parse(Console.ReadLine());
//         }

//         Console.WriteLine("Digite os elementos do vetor y:");
//         for (int i = 0; i < n; i++)
//         {
//             y[i] = int.Parse(Console.ReadLine());
//         }

//         int produtoEscalar = 0;
//         for (int i = 0; i < n; i++)
//         {
//             produtoEscalar += x[i] * y[i];
//         }

//         Console.WriteLine("O produto escalar dos vetores é: " + produtoEscalar);

//47)

// int[] vetor = new int[10];

//         Console.WriteLine("Digite os 10 números do vetor:");
//         for (int i = 0; i < 10; i++)
//         {
//             vetor[i] = int.Parse(Console.ReadLine());
//         }

//         Console.Write("Digite o número X: ");
//         int X = int.Parse(Console.ReadLine());

//         int maiores = 0, menores = 0, iguais = 0;
//         foreach (int num in vetor)
//         {
//             if (num > X)
//                 maiores++;
//             else if (num < X)
//                 menores++;
//             else
//                 iguais++;
//         }

//         Console.WriteLine("Maiores que X: " + maiores);
//         Console.WriteLine("Menores que X: " + menores);
//         Console.WriteLine("Iguais a X: " + iguais);

//48)

// string[] nomes = new string[20];
//         int[] idades = new int[20];

//         for (int i = 0; i < 20; i++)
//         {
//             Console.Write("Digite o nome da candidata " + (i + 1) + ": ");
//             nomes[i] = Console.ReadLine();
//             Console.Write("Digite a idade da candidata " + (i + 1) + ": ");
//             idades[i] = int.Parse(Console.ReadLine());
//         }

//         Console.WriteLine("Candidatas aptas:");
//         for (int i = 0; i < 20; i++)
//         {
//             if (idades[i] >= 18 && idades[i] <= 20)
//             {
//                 Console.WriteLine(nomes[i]);
//             }
//         }

//49)

// const int maxSize = 50;
//         Console.Write("Digite o tamanho dos vetores: ");
//         int n = int.Parse(Console.ReadLine());
//         int[] V1 = new int[n];
//         int[] V2 = new int[n];

//         Console.WriteLine("Digite os elementos do vetor V1:");
//         for (int i = 0; i < n; i++)
//         {
//             V1[i] = int.Parse(Console.ReadLine());
//         }

//         Console.WriteLine("Digite os elementos do vetor V2:");
//         for (int i = 0; i < n; i++)
//         {
//             V2[i] = int.Parse(Console.ReadLine());
//         }

//         int iguais = 0;
//         for (int i = 0; i < n; i++)
//         {
//             if (V1[i] == V2[i])
//             {
//                 iguais++;
//             }
//         }

//         Console.WriteLine("Número de vezes que V1 e V2 possuem valores idênticos nas mesmas posições: " + iguais);
//     }
// }

//50)

// Random random = new Random();
//         int numeroSorteado = random.Next(101);
//         int tentativas = 0;
//         int chute;

//         Console.WriteLine("Tente adivinhar o número sorteado (de 0 a 100):");

//         do
//         {
//             tentativas++;
//             chute = int.Parse(Console.ReadLine());

//             if (chute > numeroSorteado)
//             {
//                 Console.WriteLine("O número sorteado é menor.");
//             }
//             else if (chute < numeroSorteado)
//             {
//                 Console.WriteLine("O número sorteado é maior.");
//             }
//         } while (chute != numeroSorteado);

//         Console.WriteLine("Parabéns! Você acertou o número em " + tentativas + " tentativas.");

//51)

// Console.Write("Digite a quantidade de alunos: ");
//         int N = int.Parse(Console.ReadLine());
//         double[] notas = new double[N];

//         double soma = 0;
//         int acimaDeSete = 0;

//         Console.WriteLine("Digite as notas dos alunos:");
//         for (int i = 0; i < N; i++)
//         {
//             notas[i] = double.Parse(Console.ReadLine());
//             soma += notas[i];

//             if (notas[i] > 7.0)
//             {
//                 acimaDeSete++;
//             }
//         }

//         double media = soma / N;
//         Console.WriteLine("A média aritmética das notas é: " + media);
//         Console.WriteLine("Número de alunos com nota acima de 7.0: " + acimaDeSete);

//         bool acimaDeCinco = false;
//         foreach (double nota in notas)
//         {
//             if (nota > 5.0)
//             {
//                 acimaDeCinco = true;
//                 break;
//             }
//         }

//         if (!acimaDeCinco)
//         {
//             Console.WriteLine("Não há nenhum aluno com nota acima de 5.");
//         }

//52)
// int[] vetor = new int[100];
//         int indice = 0;
//         int numero;

//         Console.WriteLine("Digite os números do vetor (digite -1 para sair):");

//         while ((numero = int.Parse(Console.ReadLine())) != -1 && indice < 100)
//         {
//             vetor[indice++] = numero;
//         }

//         int count1 = 0, count3 = 0, count4 = 0;

//         for (int i = 0; i < indice; i++)
//         {
//             if (vetor[i] == 1)
//                 count1++;
//             else if (vetor[i] == 3)
//                 count3++;
//             else if (vetor[i] == 4)
//                 count4++;
//         }

//         Console.WriteLine("Número 1 aparece: " + count1 + " vezes");
//         Console.WriteLine("Número 3 aparece: " + count3 + " vezes");
//         Console.WriteLine("Número 4 aparece: " + count4 + " vezes");

//53)   

// Console.Write("Digite o número de voltas: ");
//         int N = int.Parse(Console.ReadLine());
//         double[] tempos = new double[N];

//         Console.WriteLine("Digite os tempos das voltas:");
//         for (int i = 0; i < N; i++)
//         {
//             tempos[i] = double.Parse(Console.ReadLine());
//         }

//         double melhorTempo = tempos[0];
//         int melhorVolta = 1;
//         double somaTempos = tempos[0];

//         for (int i = 1; i < N; i++)
//         {
//             somaTempos += tempos[i];

//             if (tempos[i] < melhorTempo)
//             {
//                 melhorTempo = tempos[i];
//                 melhorVolta = i + 1;
//             }
//         }

//         double tempoMedio = somaTempos / N;

//         Console.WriteLine("Melhor tempo: " + melhorTempo);
//         Console.WriteLine("Volta em que ocorreu o melhor tempo: " + melhorVolta);
//         Console.WriteLine("Tempo médio das voltas: " + tempoMedio);

// 54)
// int[] A = new int[5];
//         int[] B = new int[8];

//         Console.WriteLine("Digite os elementos do vetor A:");
//         for (int i = 0; i < 5; i++)
//         {
//             A[i] = int.Parse(Console.ReadLine());
//         }

//         Console.WriteLine("Digite os elementos do vetor B:");
//         for (int i = 0; i < 8; i++)
//         {
//             B[i] = int.Parse(Console.ReadLine());
//         }

//         Console.WriteLine("Elementos comuns aos dois vetores:");
//         foreach (int elemA in A)
//         {
//             foreach (int elemB in B)
//             {
//                 if (elemA == elemB)
//                 {
//                     Console.WriteLine(elemA);
//                 }
//             }
//         }

// 55)
// Console.WriteLine("Digite uma frase de até 50 caracteres:");
//         string frase = Console.ReadLine();

//         string fraseSemEspacos = "";
//         int espacos = 0;

//         foreach (char c in frase)
//         {
//             if (c == ' ')
//             {
//                 espacos++;
//             }
//             else
//             {
//                 fraseSemEspacos += c;
//             }
//         }

//         Console.WriteLine("Frase sem espaços em branco: " + fraseSemEspacos);
//         Console.WriteLine("Quantidade de espaços em branco: " + espacos);
// 56)
// int[] vetor = new int[50];

//         Console.WriteLine("Digite os números do vetor:");
//         for (int i = 0; i < 50; i++)
//         {
//             vetor[i] = int.Parse(Console.ReadLine());
//         }

//         int pares = 0, multiplosDeCinco = 0;

//         foreach (int num in vetor)
//         {
//             if (num % 2 == 0)
//             {
//                 pares++;
//             }

//             if (num % 5 == 0)
//             {
//                 multiplosDeCinco++;
//             }
//         }

//         Console.WriteLine("Quantidade de números pares: " + pares);
//         Console.WriteLine("Quantidade de múltiplos de 5: " + multiplosDeCinco);
// 57)
// Console.WriteLine("Digite uma frase:");
//         string frase = Console.ReadLine();

//         Console.WriteLine("Somente as vogais da frase:");
//         foreach (char c in frase)
//         {
//             if ("aeiouAEIOU".IndexOf(c) >= 0)
//             {
//                 Console.Write(c);
//             }
//         }
//         Console.WriteLine();

// 58)
// Console.Write("Digite a quantidade de números: ");
//         int quantidade = int.Parse(Console.ReadLine());

//         int[] numeros = new int[quantidade];
//         int soma = 0;
//         int maior = int.MinValue;

//         Console.WriteLine("Digite os números:");
//         for (int i = 0; i < quantidade; i++)
//         {
//             numeros[i] = int.Parse(Console.ReadLine());
//             soma += numeros[i];
//             if (numeros[i] > maior)
//             {
//                 maior = numeros[i];
//             }
//         }

//         double media = (double)soma / quantidade;
//         Console.WriteLine("Média dos números: " + media);
//         Console.WriteLine("Maior número: " + maior);
// 59)
//  Console.WriteLine("Digite dois caracteres (de A a Z) em ordem alfabética:");
//         char char1 = char.Parse(Console.ReadLine());
//         char char2 = char.Parse(Console.ReadLine());

//         if (char1 >= 'A' && char1 <= 'Z' && char2 >= 'A' && char2 <= 'Z' && char1 < char2)
//         {
//             int numCaracteres = char2 - char1 - 1;
//             Console.WriteLine("O número de caracteres entre eles é: " + numCaracteres);
//         }
//         else
//         {
//             Console.WriteLine("Erro: caracteres fora de ordem ou fora do intervalo A-Z.");
//         }
// 64)

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static List<int> vetor = new List<int>();

//     static void Main()
//     {
//         int opcao;
//         do
//         {
//             Console.WriteLine("Escolha uma opção:");
//             Console.WriteLine("1 - Carregar Vetor");
//             Console.WriteLine("2 - Listar Vetor");
//             Console.WriteLine("3 - Exibir apenas os números pares do vetor");
//             Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
//             Console.WriteLine("5 - Exibir a quantidade de números pares nas posições ímpares do vetor");
//             Console.WriteLine("6 - Exibir a quantidade de números ímpares nas posições pares do vetor");
//             Console.WriteLine("7 - Sair");
//             opcao = int.Parse(Console.ReadLine());

//             switch (opcao)
//             {
//                 case 1:
//                     CarregarVetor();
//                     break;
//                 case 2:
//                     ListarVetor();
//                     break;
//                 case 3:
//                     ExibirNumerosPares();
//                     break;
//                 case 4:
//                     ExibirNumerosImpares();
//                     break;
//                 case 5:
//                     QuantidadeParesPosicoesImpares();
//                     break;
//                 case 6:
//                     QuantidadeImparesPosicoesPares();
//                     break;
//                 case 7:
//                     Console.WriteLine("Saindo...");
//                     break;
//                 default:
//                     Console.WriteLine("Opção inválida. Tente novamente.");
//                     break;
//             }
//         } while (opcao != 7);
//     }

//     static void CarregarVetor()
//     {
//         vetor.Clear();
//         Console.WriteLine("Digite o tamanho do vetor:");
//         int tamanho = int.Parse(Console.ReadLine());

//         for (int i = 0; i < tamanho; i++)
//         {
//             Console.WriteLine($"Digite o elemento {i + 1}:");
//             int elemento = int.Parse(Console.ReadLine());
//             vetor.Add(elemento);
//         }
//     }

//     static void ListarVetor()
//     {
//         Console.WriteLine("Elementos do vetor:");
//         foreach (var elemento in vetor)
//         {
//             Console.Write(elemento + " ");
//         }
//         Console.WriteLine();
//     }

//     static void ExibirNumerosPares()
//     {
//         Console.WriteLine("Números pares do vetor:");
//         foreach (var elemento in vetor)
//         {
//             if (elemento % 2 == 0)
//             {
//                 Console.Write(elemento + " ");
//             }
//         }
//         Console.WriteLine();
//     }

//     static void ExibirNumerosImpares()
//     {
//         Console.WriteLine("Números ímpares do vetor:");
//         foreach (var elemento in vetor)
//         {
//             if (elemento % 2 != 0)
//             {
//                 Console.Write(elemento + " ");
//             }
//         }
//         Console.WriteLine();
//     }

//     static void QuantidadeParesPosicoesImpares()
//     {
//         int count = 0;
//         for (int i = 1; i < vetor.Count; i += 2)
//         {
//             if (vetor[i] % 2 == 0)
//             {
//                 count++;
//             }
//         }
//         Console.WriteLine($"Quantidade de números pares nas posições ímpares: {count}");
//     }

//     static void QuantidadeImparesPosicoesPares()
//     {
//         int count = 0;
//         for (int i = 0; i < vetor.Count; i += 2)
//         {
//             if (vetor[i] % 2 != 0)
//             {
//                 count++;
//             }
//         }
//         Console.WriteLine($"Quantidade de números ímpares nas posições pares: {count}");
//     }
// }

