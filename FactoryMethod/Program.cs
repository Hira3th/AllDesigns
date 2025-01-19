// See https://aka.ms/new-console-template for more information
using FactoryMethod.Models;

Console.WriteLine("Hello, Factory!");

Document doc1 = DocumentFactory.CreateDocument("word");
Document doc2 = DocumentFactory.CreateDocument("pdf");

doc1.Open();
doc2.Open();