using System;

namespace oop_6115261021_w08
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageData i1 = new ImageData("panda", "24/08/2563", "JPG", "46 KB");
            AlbumPicture a1 = new AlbumPicture("001", "animal pictures", "24/08/2563", "File folder", i1);

            ImageData i2 = new ImageData("zebra", "24/08/2563", "PNG", "61 KB");
            AlbumPicture a2 = new AlbumPicture("001", "animal pictures", "24/08/2563", "File folder", i2);

            Console.WriteLine(a1.ToString());
            Console.WriteLine(a2.ToString());
        }
    }
}
