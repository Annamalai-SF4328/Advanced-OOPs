namespace MathLib;

public class Class1
{
    protected internal float PI { get{return 3.14F;}}
    internal float _g { get{return 9.8F;}}
    
    public double CalculateWeight(double mass)
    {
        return mass*_g;
    }
}
