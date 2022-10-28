namespace Proxy.Virtual
{
    class Bitmap : IImage
    {
        private readonly string filename;

        public Bitmap(string filename)
        {
            this.filename = filename;
            Console.WriteLine($"Loading image from {filename}");
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing image {filename}");
        }
    }

}

