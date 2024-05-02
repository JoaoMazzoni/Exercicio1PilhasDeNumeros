using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1PilhasDeNumeros
{
    internal class Numero
    {
        int valor;
        Numero anterior;

        public Numero(int valor)
        {
            this.valor = valor;
            anterior = null;
        }

        public override string? ToString()
        {
            return "\n\nValor do número da pilha: " + valor;
        }

        public void setAnterior (Numero numero)
        {
            anterior = numero;
        }

        public Numero getAnterior()
        {
            return anterior;
        }

        
        public int getValor() //Função para pegar o valor do numero.
        {
            return this.valor;
        }

        
    }
}
