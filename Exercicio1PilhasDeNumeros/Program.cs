using Exercicio1PilhasDeNumeros;

internal class Program
{
    static Numero cadastroNumero()
    {
        int numero;
        Console.Write("\nInforme o valor do número: ");
        numero = int.Parse(Console.ReadLine());
        return new Numero(numero); // 1 - CRIANDO LIVRO - livro1
    }


    private static void Main(string[] args)
    {
        PilhaNumero pilha1 = new PilhaNumero();
        PilhaNumero pilha2 = new PilhaNumero();
        PilhaNumero pilha3 = new PilhaNumero();
        int opc;
        do
        {
            Console.Clear();
            Console.WriteLine("\n---- MENU ----\n");
            Console.WriteLine("|1| - Inserir Numero");
            Console.WriteLine("|2| - Remover Numero");
            Console.WriteLine("|3| - Quantidade Pilha");
            Console.WriteLine("|4| - Média dos Valores");
            Console.WriteLine("|5| - Transferir Pilha");
            Console.WriteLine("|6| - Imprimir Números Ímpares");
            Console.WriteLine("|7| - Imprimir Números Pares");
            Console.Write("\nInforme a opção desejada: ");

            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {

                case 1:
                    int qualPilha = 0;
                    Console.Write("\nInforme qual pilha você deseja inserir um valor: ");
                    qualPilha = int.Parse(Console.ReadLine());
                    if (qualPilha == 1)
                    {
                        pilha1.push(cadastroNumero());
                    }
                    if (qualPilha == 2)
                    {
                        pilha2.push(cadastroNumero());
                    }
                    break;

                case 2:
                    qualPilha = 0;
                    Console.Write("\nInforme qual pilha você deseja remover um valor: ");
                    qualPilha = int.Parse(Console.ReadLine());
                    if (qualPilha == 1)
                    {
                        pilha1.pop();
                    }
                    if (qualPilha == 2)
                    {
                        pilha2.pop();
                    }
                    break;

                case 3:
                    Console.WriteLine($"\nQuantidade de números cadastrados na pilha 1: {pilha1.tamanhoPilha()} números");
                    Console.WriteLine($"\nQuantidade de números cadastrados na pilha 2: {pilha2.tamanhoPilha()} números");
                    Console.ReadLine();

                    if (pilha1.tamanhoPilha() == pilha2.tamanhoPilha())
                    {
                        Console.WriteLine("\nAs pilhas possuem o mesmo tamanho, ou seja, mesma quantidade de valores inseridos.");
                    }

                    else
                    {
                        Console.WriteLine("\nAs pilhas são diferentes");
                        if (pilha1.tamanhoPilha() > pilha2.tamanhoPilha())
                        {
                            Console.WriteLine("\nA pilha 1 é maior do que a pilha 2.");
                        }
                        else
                        {
                            Console.WriteLine("\nA pilha 2 é maior do que a pilha 1.");
                        }
                    }
                    Console.ReadLine();

                    break;

                case 4:
                    double media = pilha1.CalcularMedia();
                    double maiorValor = pilha1.EncontrarMaiorValor();
                    double menorValor = pilha1.EncontrarMenorValor();

                    Console.WriteLine();
                    Console.WriteLine($"A média dos números na pilha 1 é: {media}");
                    Console.WriteLine($"O maior valor na pilha 1 é: {maiorValor}");
                    Console.WriteLine($"O menor valor na pilha 1 é: {menorValor}");

                    media = pilha2.CalcularMedia();
                    maiorValor = pilha2.EncontrarMaiorValor();
                    menorValor = pilha2.EncontrarMenorValor();

                    Console.WriteLine();
                    Console.WriteLine($"A média dos números na pilha 2 é: {media}");
                    Console.WriteLine($"O maior valor na pilha 2 é: {maiorValor}");
                    Console.WriteLine($"O menor valor na pilha 2 é: {menorValor}");
                    Console.ReadLine();
                    break;

                case 5:
                    qualPilha = 0;
                    Console.Write("\nInforme de qual pilha você deseja transferir os valores (1 ou 2): ");
                    qualPilha = int.Parse(Console.ReadLine());

                    if (qualPilha == 1)
                    {
                        pilha3.transferirPilha(pilha1);
                    }
                    else if (qualPilha == 2)
                    {
                        pilha3.transferirPilha(pilha2);
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida! Digite 1 ou 2.");
                    }
                    Console.WriteLine("\nValores transferidos para a pilha 3!");
                    Console.WriteLine($"\nPilha 3: ");
                    pilha3.imprimirPilha();
                    Console.ReadLine();
                    break;

                    case 6:
                    Console.WriteLine("\nValores ímpares das pilhas");

                    Console.WriteLine("\nValores ímpares na pilha 1:");
                    pilha1.imprimirValoresImpares();

                    Console.WriteLine("\nValores ímpares na pilha 2:");
                    pilha2.imprimirValoresImpares();

                    Console.ReadLine();
                    break;

                case 7:
                    Console.WriteLine("\nValores pares das pilhas");

                    Console.WriteLine("\nValores pares na pilha 1:");
                    pilha1.imprimirValoresPares();

                    Console.WriteLine("\nValores pares na pilha 2:");
                    pilha2.imprimirValoresPares();
                    Console.ReadLine();
                    break;
            }

        } while (opc != 0);
    }
}



