public class Guppy : Fisch
{
    public Guppy(String name, String besitzer) : base(name, besitzer){

    }

    public override void Schwimmen(){
        Console.WriteLine("schwimmt hin und her");
    }
    
}