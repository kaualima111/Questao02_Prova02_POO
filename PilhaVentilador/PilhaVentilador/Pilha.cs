using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaVentilador
{
    public class Pilha
    {
        private Stack<string> pecas;

        public Pilha()
        {
            pecas = new Stack<string>();
        }

        // Método para adicionar uma peça à pilha
        public void AdicionarPeca(string peca)
        {
            pecas.Push(peca);
        }

        // Método para trocar uma peça
        public void TrocarPeca(string pecaVelha, string pecaNova)
        {
            Stack<string> tempStack = new Stack<string>();
            bool pecaEncontrada = false;

            // Desmontar até encontrar a peça velha
            while (pecas.Count > 0)
            {
                string peca = pecas.Pop();
                if (peca == pecaVelha)
                {
                    // Trocar a peça
                    tempStack.Push(pecaNova);
                    pecaEncontrada = true;
                    break;
                }
                else
                {
                    tempStack.Push(peca);
                }
            }

            // Se a peça velha foi encontrada, reinserir as peças
            if (pecaEncontrada)
            {
                while (tempStack.Count > 0)
                {
                    pecas.Push(tempStack.Pop());
                }
            }
            else
            {
                Console.WriteLine($"A peça '{pecaVelha}' não foi encontrada.");
                // Reinserir as peças que foram removidas se a peça não for encontrada
                while (tempStack.Count > 0)
                {
                    pecas.Push(tempStack.Pop());
                }
            }
        }

        // Método para mostrar o estado da pilha
        public void MostrarPecas()
        {
            Console.WriteLine("Peças na pilha:");
            foreach (var peca in pecas)
            {
                Console.WriteLine(peca);
            }
        }
    }
}