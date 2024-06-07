using Aspose.Pdf;
using Aspose.Drawing;
using Aspose.Words.Reporting;
namespace AutotestAPI.Framework
{
    public class GenerationFile
    {
        public static Document CreateDocumentPDF()
        {
            Document document = new Document();
            Page page = document.Pages.Add();
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(GenerationData.GenerationString(156)));
            document.Save("document.pdf"); 
            Console.WriteLine(document.Info.Title);
            return document;
        }
        public static Aspose.Words.Document CreateDocumentWord()
        {
            Aspose.Words.Document doc = new Aspose.Words.Document("word.docx");
            Sender sender = new Sender(GenerationData.GenerationString(15), GenerationData.GenerationString(13));
            ReportingEngine engine = new ReportingEngine();
            engine.BuildReport(doc, sender, "sender");
            doc.Save("word.docx");
            return doc;
        }
        public static void DeleteDocumentPDF(Aspose.Pdf.Document doc) {
            File.Delete(doc.FileName);
        }
        public static void DeleteDocumentWords(Aspose.Words.Document doc)
        {
            File.Delete(doc.OriginalFileName);
        }
    }
}
