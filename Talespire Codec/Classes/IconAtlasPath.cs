using System;
using System.Drawing;
using System.IO;

namespace Talespire_Converter.Classes
{
    [Serializable]
    public class IconAtlasPath
    {
        public string Path { get; set; }
        public System.Drawing.Image Image { get; set; }
        public Bitmap Bitmap { get; set; }
        public void GetImage(string basePath)
        {
            var path = System.IO.Path.Combine(basePath, this.Path);

            if (File.Exists(path))
            {
                this.Image = System.Drawing.Image.FromFile(path);
                this.Bitmap = new Bitmap(this.Image);
            }
        }
    }
}
