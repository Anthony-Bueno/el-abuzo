// /* 
//     Licensed under the Apache License, Version 2.0

//     http://www.apache.org/licenses/LICENSE-2.0
//     */
// using System;
// using System.Xml.Serialization;
// using System.Collections.Generic;
// namespace Xml2CSharp
// {
//     [XmlRoot(ElementName = "DocumentProperties", Namespace = "urn:schemas-microsoft-com:office:office")]
//     public class DocumentProperties
//     {
//         [XmlElement(ElementName = "Author", Namespace = "urn:schemas-microsoft-com:office:office")]
//         public string Author { get; set; }
//         [XmlElement(ElementName = "LastAuthor", Namespace = "urn:schemas-microsoft-com:office:office")]
//         public string LastAuthor { get; set; }
//         [XmlElement(ElementName = "Created", Namespace = "urn:schemas-microsoft-com:office:office")]
//         public string Created { get; set; }
//         [XmlElement(ElementName = "LastSaved", Namespace = "urn:schemas-microsoft-com:office:office")]
//         public string LastSaved { get; set; }
//         [XmlElement(ElementName = "Company", Namespace = "urn:schemas-microsoft-com:office:office")]
//         public string Company { get; set; }
//         [XmlElement(ElementName = "Version", Namespace = "urn:schemas-microsoft-com:office:office")]
//         public string Version { get; set; }
//     }

//     [XmlRoot(ElementName = "ExcelWorkbook", Namespace = "urn:schemas-microsoft-com:office:excel")]
//     public class ExcelWorkbook
//     {
//         [XmlElement(ElementName = "WindowHeight", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string WindowHeight { get; set; }
//         [XmlElement(ElementName = "WindowWidth", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string WindowWidth { get; set; }
//         [XmlElement(ElementName = "WindowTopX", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string WindowTopX { get; set; }
//         [XmlElement(ElementName = "WindowTopY", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string WindowTopY { get; set; }
//         [XmlElement(ElementName = "ProtectStructure", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string ProtectStructure { get; set; }
//         [XmlElement(ElementName = "ProtectWindows", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string ProtectWindows { get; set; }
//     }

//     [XmlRoot(ElementName = "Border", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//     public class Border
//     {
//         [XmlAttribute(AttributeName = "Position", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string Position { get; set; }
//         [XmlAttribute(AttributeName = "LineStyle", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string LineStyle { get; set; }
//         [XmlAttribute(AttributeName = "Weight", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string Weight { get; set; }
//     }

//     [XmlRoot(ElementName = "Borders", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//     public class Borders
//     {
//         [XmlElement(ElementName = "Border", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public List<Border> Border { get; set; }
//     }

//     [XmlRoot(ElementName = "Font", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//     public class Font
//     {
//         [XmlAttribute(AttributeName = "FontName", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string FontName { get; set; }
//         [XmlAttribute(AttributeName = "Family", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string Family { get; set; }
//         [XmlAttribute(AttributeName = "Size", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string Size { get; set; }
//         [XmlAttribute(AttributeName = "Color", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string Color { get; set; }
//         [XmlAttribute(AttributeName = "Bold", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string Bold { get; set; }
//         [XmlAttribute(AttributeName = "Italic", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string Italic { get; set; }
//     }

//     [XmlRoot(ElementName = "Alignment", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//     public class Alignment
//     {
//         [XmlAttribute(AttributeName = "Vertical", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string Vertical { get; set; }
//         [XmlAttribute(AttributeName = "Horizontal", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string Horizontal { get; set; }
//         [XmlAttribute(AttributeName = "WrapText", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string WrapText { get; set; }
//     }

//     [XmlRoot(ElementName = "Style", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//     public class Style
//     {
//         [XmlElement(ElementName = "Borders", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public Borders Borders { get; set; }
//         [XmlElement(ElementName = "Font", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public Font Font { get; set; }
//         [XmlElement(ElementName = "Alignment", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public Alignment Alignment { get; set; }
//         [XmlAttribute(AttributeName = "ID", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string ID { get; set; }
//         [XmlElement(ElementName = "Interior", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public Interior Interior { get; set; }
//         [XmlElement(ElementName = "NumberFormat", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public NumberFormat NumberFormat { get; set; }
//     }

//     [XmlRoot(ElementName = "Interior", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//     public class Interior
//     {
//         [XmlAttribute(AttributeName = "Color", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string Color { get; set; }
//         [XmlAttribute(AttributeName = "Pattern", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string Pattern { get; set; }
//     }

//     [XmlRoot(ElementName = "NumberFormat", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//     public class NumberFormat
//     {
//         [XmlAttribute(AttributeName = "Format", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string Format { get; set; }
//     }

//     [XmlRoot(ElementName = "Styles", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//     public class Styles
//     {
//         [XmlElement(ElementName = "Style", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public List<Style> Style { get; set; }
//     }

//     [XmlRoot(ElementName = "Data", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//     public class Data
//     {
//         [XmlAttribute(AttributeName = "Type", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string Type { get; set; }
//         [XmlText]
//         public string Text { get; set; }
//     }

//     [XmlRoot(ElementName = "Cell", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//     public class Cell
//     {
//         [XmlElement(ElementName = "Data", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public Data Data { get; set; }
//         [XmlAttribute(AttributeName = "Index", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string Index { get; set; }
//         [XmlAttribute(AttributeName = "StyleID", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string StyleID { get; set; }
//         [XmlAttribute(AttributeName = "MergeAcross", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string MergeAcross { get; set; }
//         [XmlAttribute(AttributeName = "MergeDown", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string MergeDown { get; set; }
//     }

//     [XmlRoot(ElementName = "Row", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//     public class Row
//     {
//         [XmlElement(ElementName = "Cell", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public List<Cell> Cell { get; set; }
//         [XmlAttribute(AttributeName = "Index", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string Index { get; set; }
//     }

//     [XmlRoot(ElementName = "Table", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//     public class Table
//     {
//         [XmlElement(ElementName = "Row", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public List<Row> Row { get; set; }
//         [XmlAttribute(AttributeName = "ExpandedColumnCount", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string ExpandedColumnCount { get; set; }
//         [XmlAttribute(AttributeName = "ExpandedRowCount", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string ExpandedRowCount { get; set; }
//         [XmlAttribute(AttributeName = "FullColumns", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string FullColumns { get; set; }
//         [XmlAttribute(AttributeName = "FullRows", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string FullRows { get; set; }
//         [XmlAttribute(AttributeName = "DefaultColumnWidth", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string DefaultColumnWidth { get; set; }
//         [XmlAttribute(AttributeName = "DefaultRowHeight", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string DefaultRowHeight { get; set; }
//     }

//     [XmlRoot(ElementName = "Header", Namespace = "urn:schemas-microsoft-com:office:excel")]
//     public class Header
//     {
//         [XmlAttribute(AttributeName = "Margin", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string Margin { get; set; }
//         [XmlAttribute(AttributeName = "Data", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string Data { get; set; }
//     }

//     [XmlRoot(ElementName = "Footer", Namespace = "urn:schemas-microsoft-com:office:excel")]
//     public class Footer
//     {
//         [XmlAttribute(AttributeName = "Margin", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string Margin { get; set; }
//         [XmlAttribute(AttributeName = "Data", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string Data { get; set; }
//     }

//     [XmlRoot(ElementName = "PageMargins", Namespace = "urn:schemas-microsoft-com:office:excel")]
//     public class PageMargins
//     {
//         [XmlAttribute(AttributeName = "Top", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string Top { get; set; }
//         [XmlAttribute(AttributeName = "Right", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string Right { get; set; }
//         [XmlAttribute(AttributeName = "Bottom", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string Bottom { get; set; }
//         [XmlAttribute(AttributeName = "Left", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string Left { get; set; }
//     }

//     [XmlRoot(ElementName = "PageSetup", Namespace = "urn:schemas-microsoft-com:office:excel")]
//     public class PageSetup
//     {
//         [XmlElement(ElementName = "Header", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public Header Header { get; set; }
//         [XmlElement(ElementName = "Footer", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public Footer Footer { get; set; }
//         [XmlElement(ElementName = "PageMargins", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public PageMargins PageMargins { get; set; }
//     }

//     [XmlRoot(ElementName = "Print", Namespace = "urn:schemas-microsoft-com:office:excel")]
//     public class Print
//     {
//         [XmlElement(ElementName = "ValidPrinterInfo", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string ValidPrinterInfo { get; set; }
//         [XmlElement(ElementName = "PaperSizeIndex", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string PaperSizeIndex { get; set; }
//         [XmlElement(ElementName = "Scale", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string Scale { get; set; }
//         [XmlElement(ElementName = "HorizontalResolution", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string HorizontalResolution { get; set; }
//         [XmlElement(ElementName = "VerticalResolution", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public string VerticalResolution { get; set; }
//     }

//     [XmlRoot(ElementName = "WorksheetOptions", Namespace = "urn:schemas-microsoft-com:office:excel")]
//     public class WorksheetOptions
//     {
//         [XmlElement(ElementName = "PageSetup", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public PageSetup PageSetup { get; set; }
//         [XmlElement(ElementName = "Print", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public Print Print { get; set; }
//         [XmlAttribute(AttributeName = "xmlns")]
//         public string Xmlns { get; set; }
//     }

//     [XmlRoot(ElementName = "Worksheet", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//     public class Worksheet
//     {
//         [XmlElement(ElementName = "Table", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public Table Table { get; set; }
//         [XmlElement(ElementName = "WorksheetOptions", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public WorksheetOptions WorksheetOptions { get; set; }
//         [XmlAttribute(AttributeName = "Name", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public string Name { get; set; }
//     }

//     [XmlRoot(ElementName = "Workbook", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//     public class Workbook
//     {
//         [XmlElement(ElementName = "DocumentProperties", Namespace = "urn:schemas-microsoft-com:office:office")]
//         public DocumentProperties DocumentProperties { get; set; }
//         [XmlElement(ElementName = "ExcelWorkbook", Namespace = "urn:schemas-microsoft-com:office:excel")]
//         public ExcelWorkbook ExcelWorkbook { get; set; }
//         [XmlElement(ElementName = "Styles", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public Styles Styles { get; set; }
//         [XmlElement(ElementName = "Worksheet", Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
//         public Worksheet Worksheet { get; set; }
//         [XmlAttribute(AttributeName = "o", Namespace = "http://www.w3.org/2000/xmlns/")]
//         public string O { get; set; }
//         [XmlAttribute(AttributeName = "x", Namespace = "http://www.w3.org/2000/xmlns/")]
//         public string X { get; set; }
//         [XmlAttribute(AttributeName = "ss", Namespace = "http://www.w3.org/2000/xmlns/")]
//         public string Ss { get; set; }
//         [XmlAttribute(AttributeName = "html", Namespace = "http://www.w3.org/2000/xmlns/")]
//         public string Html { get; set; }
//     }

// }