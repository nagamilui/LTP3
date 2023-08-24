using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       Console.WriteLine ("digite um numero para tabuada");
         int numero = Convert.ToInt32(Console.ReadLine());
         for(int i = 0; i<=10;i++){
             int tabuada = numero * i;
    Console.WriteLine("sua tabuada de"+numero+"x"+i+"="+tabuada);
    }
}
}