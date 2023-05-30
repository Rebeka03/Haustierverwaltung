public class Katze : Saeugetier, IFleischfresser
{
    public Katze(String name, String besitzer) : base(name, besitzer){

    }
    
    public override void Fortbewegen() {
        Console.WriteLine("Katze schleicht");
    }

    public override void Pflegen(){
        Console.WriteLine("Fell wird gebürstet");
    }

    public override void Streicheln(){
        Console.WriteLine("streichel streichel");
        Schnurren();
    }

    public void Schnurren(){
        Console.WriteLine("Schnurr, Schnurr!");
    }

    public void fressen(String nahrung){
        Console.WriteLine("nomnomnom");
    }
}