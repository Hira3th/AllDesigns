// See https://aka.ms/new-console-template for more information
using FactoryMethod.Logic;
using FactoryMethod.Model;

Console.WriteLine("Hello, Factory!");

Document doc1 = DocumentFactory.CreateDocument(DocumentEnum.Word.ToString());
Document doc2 = DocumentFactory.CreateDocument(DocumentEnum.Pdf.ToString());
Document doc3 = DocumentFactory.CreateDocument(DocumentEnum.Excel.ToString());
Document doc4 = DocumentFactory.CreateDocument(DocumentEnum.Text.ToString());

doc1.Open();
doc2.Open();
doc3.Open();
doc4.Open();

Console.ReadLine();