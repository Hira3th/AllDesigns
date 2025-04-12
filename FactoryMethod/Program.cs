﻿// See https://aka.ms/new-console-template for more information
using FactoryMethod.Model;

Console.WriteLine("Hello, Factory!");

Document doc1 = DocumentFactory.CreateDocument("word");
Document doc2 = DocumentFactory.CreateDocument("pdf");
Document doc3 = DocumentFactory.CreateDocument("excel");
Document doc4 = DocumentFactory.CreateDocument("text");

doc1.Open();
doc2.Open();
doc3.Open();
doc4.Open();

Console.ReadLine();