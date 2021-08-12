# PDF CODE
Criar arquivo PDF com SENHA em .NET CORE 5.0


## USE

dotnet add package iTextSharp.LGPLv2.Core --version 1.7.3

## Como usar
//pdfcode.exe "/Users/myuser/test.pdf" "/Users/myuser/test_com_senha.pdf" "sua_senha"

## Compilar
git clone https://github.com/marciorcruz/pdfcomsenha.git

cd pdfcomsenha

dotnet restore

dotnet build

dotnet publish -f net5.0 -r win10-x64 --self-contained false
