using Aspose.Pdf;
using Aspose.Pdf.Drawing;



namespace pdf_net6
{
    class Program
    {
        static void Main(string[] args)
        {

            // Open an existing PDF document
            Document document = new Document(
                @"C:\Users\joel_\Documents\GitHub\research-pdf\inputs\114319B.PDF");
            
            // Get the first page of the document
            Page page = document.Pages[1];

           
            // Save the document with a new name
            document.Save("modified_document_v5.pdf");








        }
    }
}