using System;


class MainClass {
  
  public static void exibeNumero (float numero1, float numero2) 
  {
    float soma;
    soma = numero1+numero2;
    Console.WriteLine ("essa é a soma dos numero {0}", soma );
  }
  public static void Main () {
    float numero1, numero2;
    Console.WriteLine ("digite o numero1 e numero2 a serem somado");
    numero1= float.Parse(Console.ReadLine());
    numero2= float.Parse(Console.ReadLine());

    exibeNumero(numero1, numero2);


  }
}