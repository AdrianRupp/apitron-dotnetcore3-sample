using System;
using System.IO;
using Apitron.PDF.Kit;

namespace apitron_dotnetcore3_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an empty document
            var document = new FixedDocument();
            using var outStream = File.OpenWrite("empty-file.pdf");

            // and save it without any changes
            document.Save(outStream);




            // open an existing pdf file
            using var inStream = File.OpenRead("../../../sample-files/test.pdf");
            var document2 = new FixedDocument(inStream);

            // and saving it without any changes
            using var outStream2 = File.OpenWrite("copy-file.pdf");
            document2.Save(outStream2);
        }
    }
}
