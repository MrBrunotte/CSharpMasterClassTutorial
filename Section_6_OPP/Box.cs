using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_6_OPP
{
    class Box
    {
        // member variables
        private int length;
        private int height;
        private int width;
        private int volume;
        // properties
        public int Width { get; set; }
        //public int Volume { get; set; }
        // Read only property
        public int FrontSurface 
        { 
            get
            {
                return height * length;
            } 
        }
        public int Volume
        {
            get
            {
                return length * height * Width;
            }
        }
        public int Length 
        { 
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        public int Height 
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    // if value < 0 the -value multiplies it with -1 to make it positive.
                    height = -value;
                }
                else
                {
                height = value;   
                }
            }
        }
        // constructor
        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }

        //public void SetLength(int length)
        //{
        //    if (length < 0)
        //    {
        //        throw new Exception("Length should be higher than 0");
        //    }
        //    Length = length;
        //}
        public void DispalyInfo()
        {
            Console.WriteLine($"Length: {length}, Height {height}, Width: {Width}, Volume: {volume = Length * height * Width}");
        }
        
    }
}
