using System;

namespace Cifre_Non_uscite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();//Creo una nuova variabile random
            int[] numeri = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };//creazione array
            Console.WriteLine("premere invio per generare i numeri");
            Console.ReadLine();
            for (int i = 0; i < numeri.Length; i++)//ciclo for che cicla per il numero di dati presenti nell array
            {
                int numero = num.Next(0, 10);//"Pesco" un numero random da 0 a 9 e lo assegno alla variabile numeri
                //Console.WriteLine(numero)
                numeri[numero] = int.MaxValue;// saaegno al numero pescato il valore massimo assegnabile a una varibile intera
            }
            Console.WriteLine("\nI numeri che non sono stati estratti...");
            for (int i = 0; i < numeri.Length; i++)// ciclo per stampare a schermo i numeri non pescati
            {
                if (numeri[i] != int.MaxValue)// controllo se il posto x dell'array è il valoe max per un int, nel caso non lo sia stampo il numero a schermo 
                {
                    Console.WriteLine("Numero non estratto: {0}", numeri[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
