using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaVentilador
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pilha pilha = new Pilha();
            pilha.AdicionarPeca("Cúpula de Vidro");
            pilha.AdicionarPeca("Lâmpada");
            pilha.AdicionarPeca("Hélice");
            pilha.AdicionarPeca("Suporte");

            Console.WriteLine("Pilha original:");
            pilha.MostrarPecas();

            // Solicitar ao usuário a peça a ser trocada e a nova peça
            Console.Write("\nDigite o nome da peça a ser trocada: ");
            string pecaVelha = Console.ReadLine();

            Console.Write("Digite o nome da nova peça: ");
            string pecaNova = Console.ReadLine();

            // Trocando a peça
            pilha.TrocarPeca(pecaVelha, pecaNova);

            Console.WriteLine("\nPilha após troca:");
            pilha.MostrarPecas();
            Console.ReadLine();
        }
    }
}
