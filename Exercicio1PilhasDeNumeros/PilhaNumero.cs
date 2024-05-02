using System;
using System.Reflection.Metadata.Ecma335;

namespace Exercicio1PilhasDeNumeros
{
    internal class PilhaNumero
    {
        Numero headNumero;
        int quantidadeNumeros;

        public PilhaNumero()
        {
            headNumero = null;
            quantidadeNumeros = 0;
            Console.WriteLine("\nPilha Criada!");
        }

        public int tamanhoPilha()
        {
            return quantidadeNumeros;
        }

        public void push(Numero auxNumero)
        {
            if (Empty() == true)
            {
                headNumero = auxNumero;
            }
            else
            {
                auxNumero.setAnterior(headNumero);
                headNumero = auxNumero;
            }
            quantidadeNumeros++;
        }

        bool Empty()
        {
            return headNumero == null;
        }

        public Numero pop()
        {
            if (Empty())
            {
                Console.WriteLine("Pilha Vazia! Impossível Remover.");
                Console.Write("Pressione qualquer tecla para continuar:");
                Console.ReadKey();
                return null; // Ou lançar uma exceção, dependendo do comportamento desejado
            }
            else
            {
                Numero numeroRemovido = headNumero;
                headNumero = headNumero.getAnterior();
                quantidadeNumeros--;
                return numeroRemovido;
            }
        }


        public Numero ProcurarPorNumero()
        {
            Numero numeroAtual = headNumero;
            Numero maiorNumero = numeroAtual;

            while (numeroAtual != null)
            {
                if (numeroAtual.getValor() > maiorNumero.getValor())
                {
                    maiorNumero = numeroAtual;
                }

                numeroAtual = numeroAtual.getAnterior();
            }

            return maiorNumero;
        }


        public double CalcularMedia()
        {
            if (Empty())
            {
                Console.WriteLine("Pilha Vazia! Não é possível calcular a média.");
                return 0;
            }

            double soma = 0;
            Numero numeroAtual = headNumero;
            int contador = 0;

            while (numeroAtual != null)
            {
                soma += numeroAtual.getValor();
                contador++;
                numeroAtual = numeroAtual.getAnterior();
            }

            return soma / contador;
        }

        public double EncontrarMaiorValor()
        {
            if (Empty())
            {
                Console.WriteLine("Pilha Vazia! Não há maior valor.");
                return 0;
            }

            Numero numeroAtual = headNumero;
            double maiorValor = numeroAtual.getValor();

            while (numeroAtual != null)
            {
                if (numeroAtual.getValor() > maiorValor)
                {
                    maiorValor = numeroAtual.getValor();
                }

                numeroAtual = numeroAtual.getAnterior();
            }

            return maiorValor;
        }

        public double EncontrarMenorValor()
        {
            if (Empty())
            {
                Console.WriteLine("Pilha Vazia! Não há menor valor.");
                return 0;
            }

            Numero numeroAtual = headNumero;
            double menorValor = numeroAtual.getValor();

            while (numeroAtual != null)
            {
                if (numeroAtual.getValor() < menorValor)
                {
                    menorValor = numeroAtual.getValor();
                }

                numeroAtual = numeroAtual.getAnterior();
            }

            return menorValor;
        }

        public void transferirPilha(PilhaNumero pilhaOrigem)
        {
            while (!pilhaOrigem.Empty())
            {
                Numero numero = pilhaOrigem.pop();
                this.push(numero);
            }


        }

        public void imprimirPilha()
        {
            Console.WriteLine("Valores na pilha:");
            Numero numeroAtual = headNumero;
            while (numeroAtual != null)
            {
                Console.WriteLine(numeroAtual.getValor());
                numeroAtual = numeroAtual.getAnterior();
            }
        }

        public void imprimirValoresImpares()
        {
           
            Numero numeroAtual = headNumero;

            while (numeroAtual != null)
            {
                if (numeroAtual.getValor() % 2 != 0) 
                {
                    Console.WriteLine(numeroAtual.getValor()); 
                }
                numeroAtual = numeroAtual.getAnterior();
            }
        }


        public void imprimirValoresPares()
        {

            Numero numeroAtual = headNumero;

            while (numeroAtual != null)
            {
                if (numeroAtual.getValor() % 2 == 0)
                {
                    Console.WriteLine(numeroAtual.getValor());
                }
                numeroAtual = numeroAtual.getAnterior();
            }
        }
    }
}