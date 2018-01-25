using System;
using System.Collections.Generic;
using System.IO;
using Godeltech.Mastery.Web.DigitalLibrary.Models.ViewModels;

namespace Godeltech.Mastery.Web.DigitalLibrary.Models
{
    public class Slider
    {
        public List<SliderImageViewModel> GetImages(string path)
        {
            string currentDir = Environment.CurrentDirectory;

            DirectoryInfo dir = new DirectoryInfo(path);

            List<SliderImageViewModel> files = new List<SliderImageViewModel>();
            foreach (FileInfo file in dir.GetFiles())
            {
                string ext = file.Extension;
                if (ext.Equals(".jpeg")
                    || ext.Equals(".gif")
                    || ext.Equals(".png")
                    || ext.Equals(".jpg"))
                {
                    files.Add(new SliderImageViewModel { ImagePath = "Content/Images/Slider/" + file.Name });
                }
            }
            return files;
        }
    }
}