using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    // creating class that will calculate the area of the rectangle
    public class Rectangle
    {
        private int length; // to store the length side of rectangle
        private int width; // to store the width side of the rectangle

        // default constructor sers both sides to 1
        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        // constructor that accepts values
        public Rectangle(int newLength, int newWidth)
        {
            length = newLength;
            width = newWidth;
        }

        // to get the length value
        public int GetLength()
        {
            return length;
        }

        // to update the length 
        public int SetLength(int newLength)
        {
            length = newLength;
            return length;
        }

        // To get the width value
        public int GetWidth()
        {
            return width;
        }

        // To update the width value
        public int SetWidth(int newWidth)
        {
            width = newWidth;
            return width;
        }

        // Adding all the sides together
        public int GetPerimeter()
        {
            int perimeter = (length + width) * 2;
            return perimeter;
        }

        // multiplying both sides to get area
        public int GetArea()
        {
            int area = length * width;
            return area;
        }
    }
}
