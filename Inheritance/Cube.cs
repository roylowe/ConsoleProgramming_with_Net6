using System.ComponentModel.DataAnnotations;

namespace Inheritance
{
    class Cube : Shape, IShape

        // keyword ctor generates the method stub
    {

        // constructors are public, have the same name as the class and can take parameters
        //public Cube()
        //{

        //}

        //can have constructor overloads like there are method overloads
        public Cube(int width, int height, int length)
        {
            Width= width;
            Height= height;
            Length= length;
        }

        public double Width { get; set; }

        public double getArea()
        {
            return Length * Width;
        }

        public double getVolume()
        {
            return Length * Width * Height;
        }


    }
}

   
