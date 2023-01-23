
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Spire.Pdf;
using Spire.Pdf.Graphics;


namespace pdf_net6
{
    internal class Demo_Spire
    {
        public void Start()
        {
            // Open the existing PDF
            PdfDocument pdfDoc = new PdfDocument();
            pdfDoc.LoadFromFile(@"C:\Users\joel_\Documents\GitHub\research-pdf\inputs\114319B.PDF");



            // add rectangle shape to pdfDoc 
            PdfPageBase page = pdfDoc.Pages[0];
            var graphics = page.Canvas;
            graphics.DrawRectangle(
                PdfPens.Black,
                PdfBrushes.White,
                36, 750, 100, 50);

            // add text to rectagle 
            //PdfTrueTypeFont font = new PdfTrueTypeFont(new Font("Arial", 12f, FontStyle.Bold));
            PdfStringFormat format = new PdfStringFormat(PdfTextAlignment.Center);
            graphics.DrawString(
                "OT.121324",
                new PdfFont(PdfFontFamily.Helvetica, 12f, PdfFontStyle.Bold),
                PdfBrushes.Black, new RectangleF(36, 750, 100, 50), format);



            // Save the modified PDF with a new name
            pdfDoc.SaveToFile("modified_pdf_v3.pdf");

            // Close the PDF document
            pdfDoc.Close();
        }
    }
}
