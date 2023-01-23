
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Borders;
using iText.Kernel.Colors;
using System.IO;
using iText.Kernel.Geom;

namespace pdf_net6
{
    internal class demo_itext7
    {
        public void Start()
        {


            // Open the existing PDF
            PdfReader reader = new PdfReader(@"C:\Users\joel_\Documents\GitHub\research-pdf\inputs\114319B.PDF");
            PdfWriter writer = new PdfWriter("modified_pdf_v1.pdf");
            PdfDocument pdfDoc = new PdfDocument(reader, writer);
            Document doc = new Document(pdfDoc);







            // insert text in rectangle
            Paragraph p = new Paragraph("OT.112334");
            p.SetFontSize(14);
            p.SetFontColor(ColorConstants.BLACK);
            p.SetFontFamily("Verdana");
            p.SetBold();
            p.SetRotationAngle(Math.PI / 2);
            p.SetFixedPosition(515, 690, 60);
            doc.Add(p);


            // Close the document
            doc.Close();
        }
    }
}
