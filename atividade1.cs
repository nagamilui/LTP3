using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("digite o ano de nascimento");
        String entrada = Console.ReadLine();
         int ano = Convert.ToInt32(entrada);
        int data = DateTime.Now.Year;
        int resultado = data - ano;
        Console.WriteLine("sua idade igual " + resultado);
    }
}