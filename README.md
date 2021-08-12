# PDF CODE
Criar arquivo PDF com SENHA em .NET CORE 5.0

## USE

dotnet add package iTextSharp.LGPLv2.Core --version 1.7.3



```` 
using (Stream input = new FileStream(args[0], FileMode.Open, FileAccess.Read, FileShare.Read))
using (Stream output = new FileStream(args[1], FileMode.Create, FileAccess.Write, FileShare.None))
{
    PdfReader reader = new PdfReader(input);
    PdfEncryptor.Encrypt(reader, output, true, args[2].ToString(), args[2].ToString(), PdfWriter.ALLOW_PRINTING);
    Console.WriteLine("Arquivo com senha ( " + args[1] + " )");
}
````

## Como usar
//pdfcode.exe "/Users/myuser/test.pdf" "/Users/myuser/test_com_senha.pdf" "sua_senha"

## Compilar
git clone https://github.com/marciorcruz/pdfcomsenha.git

cd pdfcomsenha

dotnet restore

dotnet build

dotnet publish -f net5.0 -r win10-x64 --self-contained false
