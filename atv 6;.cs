using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Digite um numero");
         int numero1 = Convert.ToInt32(Console.ReadLine());
         if(numero1 % 2 == 0){
             Console.WriteLine ("o numero "+numero1+" ele = par ");
         }
         else{
             Console.WriteLine ("o numero "+numero1+" ele = impar ");
         }
    }
}