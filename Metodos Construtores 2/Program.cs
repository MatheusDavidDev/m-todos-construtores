using System;
using Metodos_Construtores_2.classes;

namespace Metodos_Construtores_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilizando construtor vazio
            Produto produto1 = new Produto();

            produto1.Codigo = 1;
            produto1.Nome = "Coca-Cola";
            produto1.Descricao = "Refrigerante de cola";
            produto1.Estoque = 30;

            Console.WriteLine($"Produto 1 Codigo {produto1.Codigo}, nome {produto1.Nome}, Descricao {produto1.Descricao}, estoque {produto1.Estoque}");

            //Construtor inserindo apenas o codigo
            Produto produto2 = new Produto(10);

            Console.WriteLine($"Produto 2 Codigo inserido {produto2.Codigo}, nome {produto2.Nome}");

            //Construtor inserindo tods os valores
            Produto produto3 = new Produto(1,"Trakinas","Bolacha de chocolate", 1000);

            Console.WriteLine($"Produto 3 Codigo {produto3.Codigo}, nome {produto3.Nome}, Descricao {produto3.Descricao}, estoque {produto3.Estoque}");

            
        }
    }
}
