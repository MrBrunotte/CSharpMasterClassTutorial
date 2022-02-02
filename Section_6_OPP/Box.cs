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
        public int height;
        public int width;
        public int volume;

        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Volume { get; set; }

        public void SetLength(int length)
        {
            Length = length;
        }
        public void DispalyInfo()
        {
            Console.WriteLine($"Length: {Length}, Height {height}, Width: {width}, Volume: {volume = Length * height * width}");
        }
        
    }
}
