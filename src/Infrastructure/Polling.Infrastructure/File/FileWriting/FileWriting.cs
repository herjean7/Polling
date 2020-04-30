using System;
using System.Collections.Generic;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Polling.Application.Common.Interfaces;
using Polling.Domain;

namespace Polling.Infrastructure.File.FileWriting
{
    public class FileWriting
    {
        //List<Person> persons = new List<Person>()
        //{
        //    new Person(){Id=1,Name="John",Gender='F',DOB="19900520",Nationality="Singaporean"},
        //    new Person(){Id=2,Name="Fanny Seah",Gender='M',DOB="19900520 @19910520",Nationality="Malaysian"},
        //    new Person(){Id=3,Name="Shi Wan",Gender='M',DOB="19840320",Nationality="Chinese"}
        //};

        public void CreatePDF(List<Person> persons, string filedepositpath) 
        {
            PdfDocument pdf = new PdfDocument(new PdfWriter(new FileStream(filedepositpath, FileMode.Create, FileAccess.Write)));
            Document doc = new Document(pdf);

            string line = "test itextpdf";
            doc.Add(new Paragraph(line));

            Table table = new Table(UnitValue.CreatePercentArray(new float[] { 5, 35, 10, 20, 30 })).UseAllAvailableWidth();
            table.AddHeaderCell("S/N");
            table.AddHeaderCell("Name");
            table.AddHeaderCell("Gender");
            table.AddHeaderCell("Date of Birth");
            table.AddHeaderCell("Nationality");

            foreach (Person pax in persons)
            {
                table.AddCell(pax.Id.ToString());

                Cell nameCell = new Cell();
                nameCell.Add(new Paragraph("Johnny Kim Like That"));
                nameCell.Add(new Paragraph("@Chan Ma Li Chan"));
                nameCell.Add(new Paragraph("@Muneiru Valiba"));
                table.AddCell(nameCell);

                table.AddCell(pax.Gender.ToString());
                table.AddCell(pax.DOB);
                table.AddCell(pax.Nationality);
            }

            doc.Add(table);

            doc.Close();
        }
    }
}
