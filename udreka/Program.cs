// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using static System.Console;
using static System.Convert;


static int wlosy() {

    Console.WriteLine("Jakie wlosy chcesz 1 - krotkie, 2 - dlugie, 3 - krecone, 4 - lysa");
    int licznik = Convert.ToInt32(Console.ReadLine());
    while (true)
    {
        switch (licznik)
        {
                case 1:
                return 6;
                break;
                case 2:
                return 10;
                break;
                case 3:
                return 5;
                break;
                case 4:
                return 0;
                break;
                default:
                Console.WriteLine("zle wybrales. Sprobuj jeszcze raz");
                break;

        }
    }
}

Console.WriteLine("Szukator dziewczyn");
Console.WriteLine("Witaj jakiej dziewczyny szukasz, od 1 do 10");
int licznik = Convert.ToInt32(Console.ReadLine());
if(licznik < 11 && licznik > 0)
{
    if(licznik < 5)
    {
        Console.WriteLine("Takie to latwo znalesc, nie potrzebujesz szukatora");
    }
    switch(licznik)
    {
            case 6:
            break;

            case 7:
            break;

            case 8:
            break;

            case 9:
            break;

            case 10:
            break;
    }
}
else { Console.WriteLine("Widze ze pan ma wygorowane wymagania"); }