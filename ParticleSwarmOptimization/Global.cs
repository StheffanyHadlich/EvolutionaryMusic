using System;

public class Global
{
    public char[] GNotes {get; set;}
    public int[] GTimes {get; set;}
    public float GFitness {get; set;}

    public Global(){
        GNotes = new char[Particles.Size];
        GTimes = new int[Particles.Size];
    }
}
