using System;
namespace Metodos_Construtores_2.classes
{
    public class Produto
    {
        public int Codigo{get;set;}

        public string Nome{get;set;}

        public string Descricao{get;set;}

        public int Estoque{get; set;}

        //Metodos
        // O metodo construtor tem q ter os mesmo nome que a classe

        public Produto(){
        
        }

        public Produto(int cod){
            Codigo = cod;
        }

        public Produto(int codigo, string nome, string descricao, int estoque){
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Estoque = estoque;

        }

    }
}