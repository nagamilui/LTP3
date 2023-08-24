using System;

public class Teste
{
    public static void Main(string[] args)
    {
     Console.WriteLine ("digite um numero");
        String entrada = Console.ReadLine();
         int numero = Convert.ToInt32(entrada);
         Console.WriteLine("seu numero  " + numero);
    }
}