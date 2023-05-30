public class Kaninchen : Saeugetier, IPflanzenfresser
{
    public Kaninchen(String name, String besitzer) : base(name, besitzer){

    }

    public override void Pflegen()
    {
        Console.WriteLine("Stall ausmisten ");
    }

    public override void Fortbewegen()
    {
        Console.WriteLine("hoppelt");
    }

    public override void Streicheln()
    {
        Console.WriteLine("streichel streichel");
    }

    public void fressen(String nahrung){
        Console.WriteLine("mümmel mümmel");
    }
}