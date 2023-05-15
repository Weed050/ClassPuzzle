public interface Nose
{
    int Ear();
    string Face { get; }
}
abstract class Picasso : Nose
{
    public virtual int Ear() => 7;
    public Picasso(string face) => this.face = face;
    public virtual string Face { get { return this.face; } } // may be mistake there, after return
    string face;
}
class Clowns : Picasso
{
    public Clowns() : base("Clowns") { }
}
class Acts: Picasso
{
    public Acts() : base("Acts") { }
    public override int Ear() => 5;
}
class Of76 : Picasso
{
    public Of76() : base("Of76") { }
    public static void Main(string[] a)
    {
        string result = "";
        Nose[] i = new Nose[3];
        i[0] = new Acts();
        i[2] = new Of76();
        i[1] = new Clowns();
        for (int x = 0; x < 3; x++)
        {
            result += (i[x].Ear() + " " + i[x].Face+"\n");
        }
        Console.WriteLine(result);
        Console.ReadLine();
    }
}
