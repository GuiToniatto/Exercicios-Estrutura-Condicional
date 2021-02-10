using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int continuar = 1;

            Console.WriteLine("Seja bem vindo à lista de exercícios de estruturas condicionais. A seguir será fornecido o tópico dos 8 exercícios onde você poderá escolher um deles para testar.");

            while (continuar != 0)
            {
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine("Exercício 1 - Número positivo ou negativo.");
                Console.WriteLine("Exercício 2 - Número par ou ímpar.");
                Console.WriteLine("Exercício 3 - Múltiplos entre si.");
                Console.WriteLine("Exercício 4 - Duração em horas de um jogo.");
                Console.WriteLine("Exercício 5 - Valor a ser pago em uma compra.");
                Console.WriteLine("Exercício 6 - Número dentro de um intervalo.");
                Console.WriteLine("Exercício 7 - Coordenada em eixo cartesiano.");
                Console.WriteLine("Exercício 8 - Imposto de renda.");
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                Console.Write("Escola a opção do exercício desejado (se desejar encerrar o programa digite qualquer outro número): ");
                int opcao = int.Parse(Console.ReadLine());

                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                if (opcao == 1)
                {
                    Console.WriteLine("Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.");

                    Console.Write("Digite um número inteiro = ");
                    int n1 = int.Parse(Console.ReadLine());

                    if (n1 >= 0)
                        Console.WriteLine("NAO NEGATIVO");
                    else
                        Console.WriteLine("NEGATIVO");
                }
                else if(opcao == 2)
                {
                    Console.WriteLine("Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.");

                    Console.Write("Digite um número inteiro = ");
                    int n1 = int.Parse(Console.ReadLine());

                    if (n1 % 2 == 0)
                        Console.WriteLine("PAR");
                    else
                        Console.WriteLine("IMPAR");
                }
                else if(opcao == 3)
                {
                    Console.WriteLine("Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem \"Sao Multiplos\" ou \"Nao sao Multiplos\", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.");

                    Console.Write("Digite dois números inteiros na mesma linha = ");
                    string[] temp = Console.ReadLine().Split(" ");

                    int n1 = int.Parse(temp[0]);
                    int n2 = int.Parse(temp[1]);

                    if (n1 % n2 == 0 || n2 % n1 == 0)
                        Console.WriteLine("Sao Multiplos");
                    else
                        Console.WriteLine("Nao sao Multiplos");
                }
                else if(opcao == 4)
                {
                    Console.WriteLine("Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.");

                    Console.Write("Digite dois números inteiros na mesma linha = ");
                    string[] temp = Console.ReadLine().Split(" ");

                    int n1 = int.Parse(temp[0]);
                    int n2 = int.Parse(temp[1]);
                    int hora = 24;

                    if (n1 > n2)
                        hora = 24 - n1 + n2;
                    else if (n1 < n2)
                        hora = n2 - n1;

                    Console.WriteLine($"O JOGO DUROU {hora} HORA(S)");
                }
                else if(opcao == 5)
                {
                    Console.WriteLine("Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.");

                    Console.Write("Digite o código e quantidade do produto desejado na mesma linha = ");
                    string[] temp = Console.ReadLine().Split(" ");

                    int codigo = int.Parse(temp[0]);
                    int quantidade = int.Parse(temp[1]);
                    double total = 0.0;

                    if (codigo == 1)
                        total = quantidade * 4.00;
                    else if (codigo == 2)
                        total = quantidade * 4.50;
                    else if (codigo == 3)
                        total = quantidade * 5.00;
                    else if (codigo == 4)
                        total = quantidade * 2.00;
                    else if (codigo == 5)
                        total = quantidade * 1.50;

                    Console.WriteLine($"Total: R$ {total.ToString("F2")}");
                }
                else if(opcao == 6)
                {
                    Console.WriteLine("Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos([0, 25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem \"Fora de intervalo\".");

                    Console.Write("Informe o número = ");
                    float n = float.Parse(Console.ReadLine());

                    if(n >= 0 && n <= 25)
                        Console.WriteLine("Intervalo [0,25]");
                    else if(n > 25 && n <= 50)
                        Console.WriteLine("Intervalo (25,50]");
                    else if(n > 50 && n <= 75)
                        Console.WriteLine("Intervalo (50,75]");
                    else if(n > 75 && n <= 100)
                        Console.WriteLine("Intervalo (75,100]");
                    else
                        Console.WriteLine("Fora de intervalo");
                }
                else if(opcao == 7)
                {
                    Console.WriteLine("Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano.A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).");
                    Console.WriteLine("Se o ponto estiver na origem, escreva a mensagem \"Origem\".");
                    Console.WriteLine("Se o ponto estiver sobre um dos eixos escreva \"Eixo X\" ou \"Eixo Y\", conforme for a situação.");

                    Console.Write("Digite o valor de X e Y na mesma linha = ");
                    string[] temp = Console.ReadLine().Split(" ");
                    float x = float.Parse(temp[0]);
                    float y = float.Parse(temp[1]);

                    if(x > 0 && y > 0)
                        Console.WriteLine("Q1");
                    else if(x < 0 && y > 0)
                        Console.WriteLine("Q2");
                    else if (x < 0 && y < 0)
                        Console.WriteLine("Q3");
                    else if (x > 0 && y < 0)
                        Console.WriteLine("Q4");
                    else
                        Console.WriteLine("Origem");
                }
                else if(opcao == 8)
                {
                    Console.WriteLine("Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem qualquer desvio.A moeda deste país é o Rombus, cujo símbolo é o R$.");
                    Console.WriteLine("Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.");
                    Console.WriteLine("Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda.No exemplo fornecido(abaixo), a taxa é de 8 % sobre R$ 1000.00 + 18 % sobre R$ 2.00, o que resulta em R$ 80.36 no total.O valor deve ser impresso com duas casas decimais.");

                    Console.Write("Digite o valor do salário = ");
                    float salario = float.Parse(Console.ReadLine());
                    float ir = 0.00f;

                    if(salario > 0.00 && salario <= 2000.00)
                        Console.WriteLine("Isento");
                    else
                    {
                        if (salario > 2000.00 && salario <= 3000.00)
                            ir = (salario - 2000) * 0.08f;
                        else if (salario > 3000 && salario <= 4500.00)
                            ir = (1000 * 0.08f) + (salario - 3000) * 0.18f;
                        else if (salario > 4500)
                            ir = (1000 * 0.08f) + (1500 * 0.18f) + (salario - 4500) * 0.28f;

                        Console.WriteLine($"R$ {ir.ToString("F2")}");
                    }
                }

                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                Console.Write("Digite 1 caso queira verificar outro exercício ou 0 para encerrar: ");
                continuar = int.Parse(Console.ReadLine());

                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                Console.Clear();
            }
        }
    }
}
