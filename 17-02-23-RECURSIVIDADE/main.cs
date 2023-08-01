using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite um número: ");
    contar(int.Parse(Console.ReadLine())); 


    
  }


  public static void contar(int n)
  {
    if(n == -1)
    return;
    
    Console.WriteLine(n);
    contar(n-1);
  }

  
}