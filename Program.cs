// See https://aka.ms/new-console-template for more information




public class Program
{
    
    public Fisch[] Aquarium = new Fisch[10];
    public Saeugetier[] Garten = new Saeugetier[8];

    static void Main(string[] args){
        Program p = new Program();
        p.testFischi();
        p.testGarten();
        p.testzoo();
        //p.testschwein();
    }

    public void testFischi()
    {
        Console.WriteLine("*********** testFischi ***********");
        for (int i = 0; i < 10; i = i + 2)
        {
            Aquarium[i] = new Guppy("Nemo" + i, " Thorsten");
            Aquarium[i + 1] = new Goldfisch("Dorie" + (i + 1), " Alfons");
        }

        foreach (Fisch f in Aquarium)
        {
            f.Schwimmen();
            f.Pflegen();
        }
    }

    public void testGarten()
    {
        Console.WriteLine("*********** testgarten ***********");
        for(int i = 0; i<5; i++)
        {
            if(i%2 == 0)
            {
                Garten[i] = new Kaninchen("Hoppel" + (i), " Uschi");
            }
            else
            {
                Garten[i] = new Katze("Mieze" + i, " Hildegard");
            }
        }

        for(int i=5; i<8; i++){
            Garten[i] = new Schwein("Peppa" + i, " Bauer Knolle");
        }

        
        foreach(Saeugetier s in Garten){
            s.Streicheln();
            if (s is IPflanzenfresser){
                ((IPflanzenfresser)s).fressen("loewenzahn");
            }
            
            if (s is IFleischfresser){
                ((IFleischfresser)s).fressen("Steak");
            }
            
        } 
    }  

    public void testzoo()
    {
        Console.WriteLine("*********** testzoo ***********");
        Haustier[][] Zoo = new Haustier[2][];
        Zoo[0] = Garten; 
        Zoo[1] = Aquarium;

        foreach(Haustier[] z in Zoo)
        {
            foreach(Haustier h in z)
            { 
                h.Pflegen();
                Console.WriteLine(h.ToString());
            }
        }
    }
/*     
    public void testschwein()
    {
        Schwein peppa = new Schwein("Peppa", "Papa Wutz");

        if(peppa is IPflanzenfresser){
            Console.WriteLine("Peppa mit Salat füttern:");
            peppa.fressen("Salat");
        }

        if(peppa is IFleischfresser){
            Console.WriteLine("Peppa mit Hühnchen füttern:");
            peppa.fressen("Hühnchen");
        }
    }
 */
}


