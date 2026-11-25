using System;



  
    
        Console.Write("Digite o nome do personagem: ");
        string nome = Console.ReadLine()!;

        int vida = 100;
        int moedas = 20;
        int nivel = 1;

        Console.WriteLine();
        Console.WriteLine("=== FICHA DO PERSONAGEM ===");
        Console.WriteLine($"Nome:   {nome}");
        Console.WriteLine($"Nível:  {nivel}");
        Console.WriteLine($"Vida:   {vida}");
        Console.WriteLine($"Moedas: {moedas}");
        Console.WriteLine("============================");
    