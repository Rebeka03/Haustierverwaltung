public class Goldfisch : Fisch, IStreicheln
{
    public Goldfisch(String name, String besitzer) : base(name, besitzer){

    }
    
    public override void Schwimmen() {
        Console.WriteLine("schwimmt im kreis");
    }

    public void Streicheln(){
        Console.WriteLine("blub blub!");
    }
}