using System;
using System.Text;
public class atv5
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding=Encoding.UTF8;
        Console.WriteLine ("digite o usuário");
        string palavra = Console.ReadLine();
        Console.WriteLine ("digite a senha");
        int senha = Convert.ToInt32(Console.ReadLine());
        
        if(palavra == "admin" && senha == 1234 ){
            Console.WriteLine("Bem vindo admin");
        }else{
            Console.WriteLine("Acesso negado");
        }
    }
}