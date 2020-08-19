using System;


class MainClass {
  
  public static void Main () {
    float numero1, numero2, nota1, nota2, nota3, nota4;
    Console.WriteLine ("digite o numero1 e numero2 a serem somado");
    numero1= float.Parse(Console.ReadLine());
    numero2= float.Parse(Console.ReadLine());

    Exercicio3.exibeNumero(numero1, numero2);

    Console.WriteLine ("digite as 4 notas"); 
    nota1= float.Parse(Console.ReadLine());
    nota2= float.Parse(Console.ReadLine());
    nota3= float.Parse(Console.ReadLine());
    nota4= float.Parse(Console.ReadLine());

    Exercicio4.exibeMedia(nota1, nota2, nota3, nota4);
    
  }
}