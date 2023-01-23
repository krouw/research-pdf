using PdfSharp.Drawing;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Drawing.Layout;

namespace pdf_netframework
{
    public class Demo_PdfSharp
    {
        public void InsertRectangle()
        {
            // Open an existing PDF document
            PdfDocument document = PdfReader.Open(
                @"C:\Users\joel_\Documents\GitHub\research-pdf\inputs\114319B.PDF",
                PdfDocumentOpenMode.Modify);

            // Create a new page and get its graphics context
            PdfPage page = document.Pages[0];
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a rectangle and draw it on the page
            XRect rect = new XRect(445, 670, 60, 110);
            gfx.DrawRectangle(XPens.Black, XBrushes.White, rect);

            // Create a text layout and draw it on the page

            XTextFormatter tf = new XTextFormatter(gfx);
            tf.DrawString(
                "OT.121324",
                new XFont("Verdana", 14),
                XBrushes.Black,
                rect,
                XStringFormats.TopLeft
                );

            XFont font = new XFont("Verdana", 14, XFontStyle.Bold);
            gfx.DrawString("OT.112334", font, XBrushes.Black,
              new XRect(515, 690, 60, 110), XStringFormats.Center);


            //gfx.RotateAtTransform(90, new XPoint(515, 690));

            // Save the document with a new name
            document.Save("modified_document_3.pdf");
            Console.WriteLine("Done");
        }
        public void Start()
        {
            // open a file to edit using PDFsharp
            PdfDocument document = PdfReader.Open(
                @"C:\Users\joel_\Documents\GitHub\research-pdf\inputs\114319A.PDF",
                PdfDocumentOpenMode.Modify);

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
