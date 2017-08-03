using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolDragCropImage
{
    public class Contents
    {
        public static List<ImageTypeManager> listImgType = new List<ImageTypeManager>()
        {
            new ImageTypeManager() { DuoiFile = ".jpg", Format = ImageFormat.Jpeg },
            new ImageTypeManager() { DuoiFile = ".png", Format = ImageFormat.Png },
            new ImageTypeManager() { DuoiFile = ".bmp", Format = ImageFormat.Bmp }
        };

    }


    public class ImageTypeManager
    {
        string _duoiFile;
        ImageFormat _format;

        public string DuoiFile
        {
            get
            {
                return _duoiFile;
            }

            set
            {
                _duoiFile = value;
            }
        }

        public ImageFormat Format
        {
            get
            {
                return _format;
            }

            set
            {
                _format = value;
            }
        }
    }
}
