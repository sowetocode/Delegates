using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);
        
        /*
        With out using Generic delegate
        we can use Action<> which returns void
        or Func<> which returns a value


        public void Process (string path, PhotoFilterHandler filterHandler)

        */
        public void Process(string path, Action<Photo> filterHandler)
        {
            
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();

        }

        /*
        with out delegates
        public void Process (string path)
        {
            var photo = Photo.Load(path);

            var filters = new PhotoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyBrightness(photo);
            filters.Resize(photo);

            photo.Save();

        }


    */
    }
}
