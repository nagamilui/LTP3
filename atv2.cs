using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("digite o primeiro nome");
        String nome = Console.ReadLine();
        Console.WriteLine("digite o sobrenome");
        String sobrenome = Console.ReadLine();
        Console.WriteLine("seu primeiro nome  " + nome+ " seu sobrenome "+ sobrenome);
    }
}