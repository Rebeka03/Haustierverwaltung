public abstract class Saeugetier : Haustier, IStreicheln
{
    public Saeugetier(String name, String besitzer) : base(name, besitzer){

    }
    
    public override void Pflegen(){return;}
    
    public abstract void Fortbewegen();

    public abstract void Streicheln();
}