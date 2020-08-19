using System;


class Exercicio4 {
  
  public static void exibeMedia (float nota1, float nota2, float nota3, float nota4 ) 
  {
    float soma, media;
    soma = nota1+nota2+nota3+nota4;
    media = soma / 4;
    Console.WriteLine ("essa é a media das notas {0}", media );
    
  }
}