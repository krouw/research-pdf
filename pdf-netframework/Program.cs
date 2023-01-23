using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdf_netframework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // open a file to edit using PDFsharp
            PdfDocument document = PdfReader.Open(
                @"C:\Users\joel_\Documents\GitHub\research-pdf\inputs\114319A.PDF",
                PdfDocumentOpenMode.Import);

            //PdfDocument document = new PdfDocument();
            //document.Info.Title = "Created with PDFsharp";

            // get dimensions of document
            string info = document.Info.ToString();
            Console.WriteLine("info: " + info);

            // add rectangle shape to document with black border and overlay the text and images
            XGraphics gfx = XGraphics.FromPdfPage(document.Pages[0]);
            //XRect rect = new XRect(445, 670, 60, 110);
            //gfx.DrawRectangle(XBrushes.Red, rect);


            //PdfPage page = document.AddPage();
            //XGraphics gfx = XGraphics.FromPdfPage(page);
            XRect rect = new XRect(445, 670, 60, 110);
            gfx.DrawRectangle(XPens.Black, XBrushes.White, rect);

            // rotate text
            gfx.RotateAtTransform(90, new XPoint(515, 690));
            XFont font = new XFont("Verdana", 14, XFontStyle.Bold);
            gfx.DrawString("OT.112334", font, XBrushes.Black,
              new XRect(515, 690, 60, 110), XStringFormats.Center);

            // Save the document...
            const string filename = "prueba_10.pdf";
            document.Save(filename);
            // ...and start a viewer.
            //Process.Start(filename);

            Console.WriteLine("Done");
        }
    }
}
