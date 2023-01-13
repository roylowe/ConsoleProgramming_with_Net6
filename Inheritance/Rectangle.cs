// See https://aka.ms/new-console-template for more information

//Inheritance is sharing with something else


//ABSTRACT MEANS CANNOT INSTANTIATE OBJECT



using Inheritance;

internal class Rectangle : Shape, IShape
{
    public double Width { get; set; }
    public double getArea()
    {
        return Length * Width;
    }
}
