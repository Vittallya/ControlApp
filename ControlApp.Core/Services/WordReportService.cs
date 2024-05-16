using ControlApp.Core.Interfaces;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using ControlApp.Core.Entities;

namespace ControlApp.Core.Services;

internal class WordReportService : IReportService
{
    public void CreateReport<T>(IReadOnlyCollection<T> data, string filePath)
        where T: IEntity
    {

        using MemoryStream memoryStream = new();
        using WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document);
        // Add a main document part.
        MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

        // Create the document structure and add some text.
        mainPart.Document = new Document();
        Body body = new Body();

        // Create a table.
        Table table = new Table();

        // Create a table properties object and specify its border information.
        TableProperties tblProp = new TableProperties(
            new TableBorders(
                new TopBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                new BottomBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                new LeftBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                new RightBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                new InsideHorizontalBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                new InsideVerticalBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 }
            )
        );
        table.AppendChild<TableProperties>(tblProp);

        // Create table header
        TableRow headerRow = new TableRow();

        foreach (var prop in typeof(T).GetProperties())
        {
            TableCell headerCell = new TableCell(new Paragraph(new Run(new Text(prop.Name))));
            headerRow.AppendChild(headerCell);
        }

        table.AppendChild(headerRow);

        // Add data rows
        foreach (var item in data)
        {
            TableRow dataRow = new TableRow();

            foreach (var prop in typeof(T).GetProperties())
            {
                var value = prop.GetValue(item)?.ToString() ?? string.Empty;
                TableCell dataCell = new TableCell(new Paragraph(new Run(new Text(value))));
                dataRow.AppendChild(dataCell);
            }

            table.AppendChild(dataRow);
        }

        // Add the table to the body.
        body.AppendChild(table);

        // Add body to the document.
        mainPart.Document.AppendChild(body);        
    }
}



