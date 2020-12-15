namespace Metodos_Construtores.classes
{
    public class Pessoa
    {
        private string sobreNome;
        
        public string SobreNome{
            get{return sobreNome;}
            set{sobreNome = value;}
        }
        private string nome;

        public string Nome{
            get{return nome;}
            set{nome = value;}
        }
        // O construtor vazio nao obriga o usuario a escrever
        public Pessoa(){

        }

        // O construor obriga o usuario a escrever
        public Pessoa(string firsName, string lastSobreNome){

            sobreNome = lastSobreNome;

            nome = firsName;
        }

        public Pessoa(string anome){

             nome = anome;
        }
    }
}