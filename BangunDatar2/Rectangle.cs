using System;

public class Rectangle
{
    private double Long;
    private double Wide;

    public void setLong(double Long)
    {
        this.Long = Long;
    }
    public void setWide(double Wide)
    {
        this.Wide = Wide;
    }
    public double area()
    {
        return Long * Wide;
    }
    public double around()
    {
        return 2 * (Long + Wide);
    }
}
