using System; 

class DIO {

  static void Main(string[] args)
    {
    double a = 0.19, c, S = 1;
    for (int i = 1; i <= 2; i++)
    {
    c = 1; //coloque a sua lógica nos espaços em branco
    S += 1 + 1 / 2 + 1 / 3 + c + 1 / 100;
    }
    S = S + a;
    var x = Math.Round(S, 2);
    Console.WriteLine(S);
        }
    }
