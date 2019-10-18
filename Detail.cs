using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingApp
{

    public class Detail
    {
        public string Name { get; private set; }
        public int Length { get; private set; }
        public int Width { get; private set; }
        public Detail(string name,int length,int width)
        {
            Name = name;
            Length = length;
            Width = width;
        }
    }
}
