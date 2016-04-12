using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("pic.jpg", filterHandler);




            /*
            with out delegates
            var processor = new PhotoProcessor();
            prosessor.Process("photo.jpg");
            */
        }
        
        static void RemoveRedEyeFilter(Photo photo)
        {

            System.Console.WriteLine("Apply Remove red eye");
        }

    }
}
