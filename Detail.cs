namespace CuttingApp
{

    public class Detail
    {
        public string Name { get; private set; }
        public int Xsize { get; private set; }
        public int Ysize { get; private set; }
        public Detail(string name, int length, int width)
        {
            Name = name;
            Xsize = length;
            Ysize = width;
        }
    }
}
