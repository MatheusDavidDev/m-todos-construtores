using System;
using Metodos_Construtores.classes;

namespace Metodos_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o seu sobrenome: ");
            string sobreNome = Console.ReadLine();
            
            Pessoa p = new Pessoa("Carlos Eduardo", "Tsukamoto");

            Console.WriteLine($"Bem vindo {p.Nome} {p.SobreNome}");
        }
    }
}
