using System.IO;

namespace UmbracoExamine.PDF
{
    public interface IPdfTextExtractor
    {
        string GetTextFromPdf(Stream pdfFileStream);
    }
}
