Haustier.Haustier[][] Zoo = new Haustier.Haustier[2][];
Zoo[0] = Garten;
Zoo[1] = Aquarium;

((Kaninchen)Zoo[0][1]).Pflegen();

foreach(Haustier.Haustier h in Zoo)
{
    foreach(Haustier.Haustier h2 in h)
    {
        if(h2 != null)
        {
            h2.Pflegen();
            if(h2 is Fisch fisch)
            {
                fisch.Schwimmen();
            }
        }
    }
}


public class Fish
{
    public virtual void Swim()
    {
        Console.WriteLine("Abstrakt (fisch) schwimmt.");
    }

    public calss AbsFish : Abstrakt
    {
        public override void Swim()
        {console.WriteLine("AbsFish schwimmt)}
    }
}

public class Guppy : Fish
{
    public 
}

static coid main(strg[] args)
{
    fish f1 = new fish();

    f1.swim();

    guppy g1 = new guppy();

    g1.swim();

    ((fish)g1).swim();

    Fish[] aquarium = new Fish[10];
    aquarium[0] = f1;
    aquarium[1] = g1;

    foreach(object o in aquarium)
    {
        ((Fish).o)?.Swim();
        
    }
    Console.WriteLine("Ab jetzt goldfisch");

    g1 gf1 = new gf();
    gf1.Swim();

    ((Fish)gf1).Swim();

    Console.WriteLine("Ab jetzt NORMAL");
    NORMAL n1 = new NORMAL();
    n1.Swim();
    ((Fish)n1).Swim();

    AbsFish abs = new AbsFish();
    abs.Swim
}

public class gf : Fish
{
    public void Swim();
}
