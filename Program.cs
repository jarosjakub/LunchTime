namespace LunchTime;

internal class Program
{
    static void Main()
    {
        var mlyn = new Mlyn();
        mlyn.GetMenu();

        var puor = new PUOR();
        puor.GetMenu();

        var kluci = new UKluku();
        kluci.GetMenu();

        Console.Clear();

        Console.WriteLine("PUOR" + "\n" + "-----------------------" + "\n");
        Console.WriteLine(puor.Menu);
        Console.WriteLine("\n" + "U Kluků" + "\n" + "-----------------------" + "\n");
        Console.WriteLine(kluci.Menu);
        Console.WriteLine("\n" + "Třebovický mlýn" + "\n" + "-----------------------" + "\n");
        Console.WriteLine(mlyn.Menu);
    }
}