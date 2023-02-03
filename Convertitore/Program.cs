using System;

namespace Convertitore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, resto, x = Console.WindowWidth / 2;
            string risp, rip;
            do
            {
                Console.Clear();
                //Inserimento numero da convertire
                do
                {
                    Console.WriteLine("Inserire un numero decimale da 0 a 255");
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num < 0)
                    {
                        Console.WriteLine("Inserito valore non supportato\nReinserire");
                    }
                } while (num < 0);
                Console.WriteLine("In cosa si vuole convertire?\nEsadecimale - Hex\nOttale - Oct\nBinario - Bin");
                risp = Console.ReadLine().ToLower();

                Console.SetCursorPosition(x - 20, 6);
                Console.WriteLine("Valore convertito:");

                //if, ciclo e switch per conversione in esadecimale
                if (risp == "hex")
                {
                    do
                    {
                        Console.SetCursorPosition(x + 2, 6);
                        resto = num % 16;
                        num /= 16;
                        switch (resto)
                        {

                            case 1:
                                Console.Write(1);
                                break;
                            case 2:
                                Console.Write(2);
                                break;
                            case 3:
                                Console.Write(3);
                                break;
                            case 4:
                                Console.Write(4);
                                break;
                            case 5:
                                Console.Write(5);
                                break;
                            case 6:
                                Console.Write(6);
                                break;
                            case 7:
                                Console.Write(7);
                                break;
                            case 8:
                                Console.Write(8);
                                break;
                            case 9:
                                Console.Write(9);
                                break;
                            case 10:
                                Console.Write("A");
                                break;
                            case 11:
                                Console.Write("B");
                                break;
                            case 12:
                                Console.Write("C");
                                break;
                            case 13:
                                Console.Write("D");
                                break;
                            case 14:
                                Console.Write("E");
                                break;
                            case 15:
                                Console.Write("F");
                                break;
                        }
                        x--;
                    } while (resto > 0);
                }

                //if e ciclo per conversione in ottale
                else if (risp == "oct")
                {
                    do
                    {
                        resto = num % 8;
                        num /= 8;
                        if (resto != 0)
                        {
                            Console.SetCursorPosition(x + 2, 6);
                            Console.WriteLine(resto);
                        }
                        x--;
                    } while (resto > 0);
                }

                //if e ciclo per conversione in binario
                else if (risp == "bin")
                {
                    do
                    {
                        resto = num % 2;
                        if (resto != 0)
                        {
                            num -= 1;
                        }
                        num /= 2;
                        Console.SetCursorPosition(x + 8, 6);
                        Console.WriteLine(resto);
                        x--;
                    } while (num != 0);

                }

                //Ripetizione
                Console.SetCursorPosition(0,7);
                Console.WriteLine("Si vuole ripetere?");
                rip = Console.ReadLine().ToLower();
            } while (rip == "si");
            
            Console.ReadLine();
        }
    }
}
