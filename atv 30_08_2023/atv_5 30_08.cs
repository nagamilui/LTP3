using System;
using System.Text;
public class atv5
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("digite o nome completo");
        string nomecompleto = Console.ReadLine();
        Console.WriteLine ("digite a idade");
        int idade = Convert.ToInt16(Console.ReadLine());
        
        Console.WriteLine($"seu nome maiusculo{nomecompleto.ToUpper()}");
        Console.WriteLine($"seu nome minusculo{nomecompleto.ToLower()}");
        string nomesemespaco = nomecompleto.Replace(" ", "");
        Console.WriteLine($"a quantidade de caracteres do seu nome é {nomesemespaco.Length}");
        int anonascimento = idade - 2023;
        Console.WriteLine($"seu ano de nascimento{anonascimento} e daqui 100 anos voce terá {idade + 100}");
    }
}
