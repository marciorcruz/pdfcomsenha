using System;
using System.IO;
using iTextSharp.text.pdf;

namespace pdfcode
{
    public class Program
    {
        static void Main(string[] args)
        {

            //"/Users/macbookpro/Documents/BUILD/pdfcode/test.pdf"
            //"/Users/macbookpro/Documents/BUILD/pdfcode/test_encrypted.pdf"
            //pdfcode.dll "/Users/macbookpro/Documents/BUILD/pdfcode/test.pdf" "test_e2.pdf" "secret"
            //dotnet publish -f net5.0 -r win10-x64 --self-contained false

            if (args.Length != 3)
            {
                Console.WriteLine("Está faltando dados!");
                return ;
            }

            if (args[2].Length <= 0)
            {
                Console.WriteLine("Senha não pode ser vazia");
                return ;
            }

            if (Program.IsValidPdf(args[0]))
            {
                using (Stream input = new FileStream(args[0], FileMode.Open, FileAccess.Read, FileShare.Read))
                using (Stream output = new FileStream(args[1], FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    PdfReader reader = new PdfReader(input);
                    PdfEncryptor.Encrypt(reader, output, true, args[2].ToString(), args[2].ToString(), PdfWriter.ALLOW_PRINTING);
                    Console.WriteLine("Arquivo com senha ( " + args[1] + " )");
                }
            }
            else
            {
                Console.WriteLine("Arquivo PDF Inválido");
            }
        }

        private static bool IsValidPdf(string filepath)
        {
            bool Ret = true;
            PdfReader reader = null;
            try
            {
                reader = new PdfReader(filepath);
            }
            catch
            {
                Ret = false;
            }
            return Ret;
        }
    }
}
