using System;

public class Square
{
    private double side;

    public void aturside(double side)
    {
        this.side = side;
    }
    public double area()
    {
        return Math.Pow(this.side, 2);
    }
    public double around()
    {
        return 4 * side;
    }

}
