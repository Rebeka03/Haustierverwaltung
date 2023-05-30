public abstract class Fisch : Haustier
{
    public Fisch(String name, String besitzer) : base(name, besitzer)
    {
        
    }
    public override void Pflegen(){
        WasserWechseln();
    }

    public abstract void Schwimmen();

    public void WasserWechseln(){
        Console.WriteLine("schwimmen schwimmen schwimmen. Ach nee, kein Wasser drin XD");
    }

}