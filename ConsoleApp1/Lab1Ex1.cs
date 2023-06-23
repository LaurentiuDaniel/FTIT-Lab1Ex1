

/*Ex1
Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
paralelipiped dreptunghic, va afisa volumul lui*/

class Lab1Ex1
{ 
    static void Main(string[] args)
    {
        int lungime;
        int latime;
        int inaltime;
        int volum;

        Console.WriteLine("Introduce lungimea");
        lungime = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce latimea");
        latime = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce inaltimea");
        inaltime = int.Parse(Console.ReadLine());

        volum = lungime * latime * inaltime;

        Console.WriteLine("Volumul paralelipipedului dreptunghic este:");
        Console.WriteLine(volum);

    }

}



