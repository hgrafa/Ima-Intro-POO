namespace Turma {

    class Aluno { 
        // atributos
        public string Nome;
        public int Idade;
        public double Altura;
        public double Media;

        // métodos
        public void FazerAniversario() {
            Idade++; // Idade = Idade + 1
        }


    }

    public class Program {
        public static void Main(string[] args) {

            Aluno joao = new Aluno(); // objeto
            Aluno maria = new Aluno(); // objeto

            joao.Nome = "Joao da Silva";
            joao.Idade = 19;
            joao.Altura = 1.75;
            joao.Media = 7.9;

            joao.Idade = 200;

            joao.FazerAniversario(); // chamada do método

            Console.WriteLine(joao.Idade);

            Aluno temp = joao;
            joao = maria;
            maria = temp;

        }
    }
}