
class Domino
{
 public int d1;
 public int d2;

 public Domino (int d1, int d2)//Constructor
 {
    this.d1 = d1; 
    this.d2= d2; 
 }
 public Domino operator + (Domino a, Domino b)
 {
    int d1 = a.d1 * b.d2 ;
 }
}

internal class Program
{
    public static void Main(string[] args)
    {
        Domino d1= new Domino(0,1);
        Domino d2 = new Domino(2,3);
        int total = d1 + d2; 
    }
}