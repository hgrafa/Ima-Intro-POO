# Introdução a POO

## Requisitos

* variáveis
* arrays / vetores

## Exemplo inicial

```c#
  string[] nomes = new string[10];
  int[] idades = new int[10];
  double[] alturas = new double[10];
  double[] medias = new double[10];
```

## Subproblema

**problema:** Como trocar duas variáveis.

```c#
  int a = 2, b = 3;
  
  // a = 2 ; b = 3 ; temp = 2
  int temp = a; 
  
  // a = 3 ; b = 3 ; temp = 2
  a = b; 
  
  // a = 3 ; b = 2 ; temp = 2
  b = temp;
```

# Ideia de POO

```
estrutura Aluno {
  nome,
  idade,
  altura,
  media;
}
```

## Voltando no problema inicial

```c#
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
```

```c#
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
```