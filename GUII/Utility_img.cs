using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUII
{
    public static class Utility_img
    {
       
            public static Image ByteArrayToImage(byte[] fileBytes)
        {   if (fileBytes.Length == 0) return null;

            using (var stream = new MemoryStream(fileBytes))
            {
                
                return Image.FromStream(stream);
            }
        }

        public static Byte[] ImageToByteArray(Image img)
        {
            if (img == null) return null;
            using (var stream = new MemoryStream())
            {
                img.Save(stream, img.RawFormat);
                return stream.ToArray();
            }
        }
    }

}
