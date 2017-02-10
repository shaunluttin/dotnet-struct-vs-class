class Program
{
    private ValueType v;

    private ReferenceType r;

    static void Main(string[] args)
    {
        var p = new Program();
        try
        {
            System.Console.WriteLine(p.v.I);
            System.Console.WriteLine(p.r.I);
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex);
        }
    }
}

public struct ValueType
{
    public readonly int I;
}

public class ReferenceType
{
    public int I;
}