using System;

class Program {
  public static void Main (string[] args) {
    
    // Faça um programa que leia uma palavra e a imprima de trás-para-frente.

    // declaração
    string palavra;

    // pedir uma palavra
    Console.Write("Digite a palavra: ");
    palavra = Console.ReadLine();

    // imprimir palavra de trás-para-frente
    for (int i = palavra.Length - 1; i >= 0; i--) {
      Console.Write(palavra[i]);
    }
  }
}