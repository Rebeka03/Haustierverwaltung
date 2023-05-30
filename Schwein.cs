public class Schwein : Saeugetier, IPflanzenfresser, IFleischfresser
{
    public Schwein(String name, String besitzer) : base(name, besitzer){

    }

    public override void Streicheln()
    {
        Console.WriteLine("oink oink");
    }

    public override void Fortbewegen()
    {
        Console.WriteLine("Schwein geht"); 
    }

    public void fressen(String essen){
        Console.WriteLine("OIIINK, Lekker " + essen + "!"); 
    }
}