using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"C:/Users/mvi/OneDrive/Documents/18.pdf";
            string outputFilePath = @"C:/Users/mvi/OneDrive/Documents/18 modified.pdf";
            PdfDocument documentData = PdfReader.Open(inputFilePath, PdfDocumentOpenMode.Modify);

            documentData.Save(outputFilePath);

            Console.Read();
        }
    }
}
