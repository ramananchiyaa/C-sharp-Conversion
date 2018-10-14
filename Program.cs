using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert_Image_to_Pdf
{
    class Program
    {
        static void Main(string[] args)
        {
            SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
            f.OpenPdf(@"D:\Integra training\fileConversion\scansmpl.pdf");

            if (f.PageCount > 0)
            {
                f.ImageOptions.Dpi = 200;
                f.ImageOptions.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;

                for (int page = 1; page <= f.PageCount; page++)
                {
                    f.ToImage(@"D:\Integra training\fileConversion\images\" + "page" + page + ".jpg", page);
                }
                Console.ReadKey();
            }
        }
    }
}
