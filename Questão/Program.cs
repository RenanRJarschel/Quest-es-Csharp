using System;

class Questões
{
    static void Main()
    {
        char respostaUsuario;
        char respostaCorreta = 'b', respostaCorreta2 = 'd';

        Console.WriteLine("Questão 1 - A soma de (2+5.2)+5 é: ");
        Console.WriteLine(" a) 15 \n b) 17 \n c) 25 \n d) 34 ");

        Console.Write("Escolha a alternativa correta entre (a, b, c ou d): \n");

        respostaUsuario = Char.ToLower(Console.ReadKey().KeyChar); // Lê um caractere e converte para minúscula
        Console.WriteLine();

        if (respostaUsuario == respostaCorreta)
        {
            Console.WriteLine("Resposta certa");
        }
        else
        {
            Console.WriteLine("Resposta incorreta");
        }
        Console.WriteLine("Questão 2 - A divisão de 50/2 é: ");
        Console.WriteLine(" a) 5 \n b) 15 \n c) 20 \n d) 25 ");

        Console.Write("Escolha a alternativa correta entre (a, b, c ou d): \n");

        respostaUsuario = Char.ToLower(Console.ReadKey().KeyChar); // Lê um caractere e converte para minúscula
        Console.WriteLine();

        if (respostaUsuario == respostaCorreta2)
        {
            Console.WriteLine("Resposta certa");
        }
        else
        {
            Console.WriteLine("Resposta incorreta");
        }

    }
}
