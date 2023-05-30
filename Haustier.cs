public abstract class Haustier
{
    private String Name;
    readonly String Besitzer;


    public Haustier(String name, String besitzer){
        Name = name;
        Besitzer = besitzer; 
    }

    public abstract void Pflegen(); 

    public override string ToString()
    {
        return Name + Besitzer;
    }

}