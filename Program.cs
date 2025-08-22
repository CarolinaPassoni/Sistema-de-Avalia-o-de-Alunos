using System;

class Programa
{
    static void Main()
    {
        Console.WriteLine("=== Sistema de Avaliação de Alunos ===");

        Console.Write("Digite o nome do aluno: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2) / 2;

        Console.WriteLine($"\nAluno: {nome}");
        Console.WriteLine($"Média: {media}");

        if (media >= 7)
        {
            Console.WriteLine("Situação: Aprovado ");
        }
        else if (media >= 5)
        {
            Console.WriteLine("Situação: Recuperação ");
        }
        else
        {
            Console.WriteLine("Situação: Reprovado ");
        }
    }
}
