﻿using System;

/*Ex2
Scrieti un program care va calcula media aritmetica a trei numere citite de la
tastatura*/

class Lab1Ex2
{
    static void Main(string[] args)
    {
        int primulNumarNorocos;
        int alDoileaNumarNorocos;
        int alTreileaNumarNorocos;
        int mediaAritmetica;

        Console.WriteLine("Primul numar norocos ?");
        primulNumarNorocos = int.Parse(Console.ReadLine());

        Console.WriteLine("Al doilea numar norocos ?");
        alDoileaNumarNorocos = int.Parse(Console.ReadLine());

        Console.WriteLine("Cel de al treilea numar norocos ?");
        alTreileaNumarNorocos = int.Parse(Console.ReadLine());

        mediaAritmetica = (primulNumarNorocos + alDoileaNumarNorocos + alTreileaNumarNorocos) / 3;

        Console.WriteLine("Numarul jackpot este:");
        Console.WriteLine(mediaAritmetica);

    }

}
