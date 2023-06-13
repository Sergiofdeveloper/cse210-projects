using System; 

public class Square : Shape
{
    private double _side; 
    public double Side
    {
        get { return _side; }
        set { _side = value; }
    }
     public Square (string color, double _side) : base(color)
     {
        Side = _side;
     }

    public override double GetArea()
    {
        return Side * Side;
    }

}
