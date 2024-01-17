using System;


public class Shape
{

    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

public class Rectangle : Shape
{
    private int width;
    private int height;

    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }
   
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }
    public new int Area()
    {
        return height * width;
    }
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }

}

public class Square : Rectangle
{
    private int size;
    public int size
    {
        get { return size; }
        set 
        { 
            if (value < 0) 
            throw new ArgumentException("Size must be great than or equal to 0");
            else
            
                size = value;
                height = value;
                width = value;
            
        }
    }
}