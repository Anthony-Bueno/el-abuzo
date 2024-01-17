// // using System;
// // using System.Xml.Linq;
// // using System.Linq;

// // class Prueba
// // {
// //     static void Main()
// //     {
// //         // XML de ejemplo con espacio de nombres 'ss' declarado
// //         string xmlString = @"
// //             <Root>
// //                 <ss:Row xmlns:ss='urn:schemas-microsoft-com:office:spreadsheet' ss:Index='3'>
// //                     <ss:Cell ss:Index='2' ss:MergeAcross='5'>
// //                         <ss:Data ss:Type='String'>(Contiene datos mínimos de una Boleta de Pago)</ss:Data>
// //                         <ss:Data ss:Type='Number'>2.00</ss:Data>
// //                     </ss:Cell>
// //                     <ss:Cell ss:Index='9'>
// //                         <ss:Data ss:Type='String'>1:50:46</ss:Data>
// //                     </ss:Cell>
// //                     <ExtraInfo>Información adicional</ExtraInfo>
// //                 </ss:Row>
// //                 <ss:Row xmlns:ss='urn:schemas-microsoft-com:office:spreadsheet' ss:Index='6'>
// //                     <ss:Cell ss:Index='2' ss:StyleID='s75' ss:MergeAcross='7'>
// //                         <ss:Data ss:Type='String'>RUC : 20600695984</ss:Data>
// //                     </ss:Cell>
// //                 </ss:Row>
// //             </Root>";

// //         // Cargar el XML desde la cadena
// //         XDocument xmlDoc = XDocument.Parse(xmlString);

// //         // Preguntar al usuario qué contenido desea visualizar
// //         Console.WriteLine("¿Qué contenido del XML deseas visualizar?");
// //         Console.WriteLine("1. Boleta de Pago");
// //         Console.WriteLine("2. Información Adicional");

// //         int opcion;
// //         do
// //         {
// //             Console.Write("Selecciona una opción (1-2): ");
// //         } while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 2);

// //         // Mostrar el contenido según la opción seleccionada
// //         switch (opcion)
// //         {
// //             case 1:
// //                 MostrarBoleta(xmlDoc);
// //                 break;
// //             case 2:
// //                 MostrarInformacionAdicional(xmlDoc);
// //                 break;
// //         }

// //         // Esperar a que el usuario presione una tecla antes de cerrar la consola
// //         Console.ReadKey();
// //     }

// //     static void MostrarBoleta(XDocument xmlDoc)
// //     {
// //         XElement boletaCell = xmlDoc.Root
// //             .Elements("{urn:schemas-microsoft-com:office:spreadsheet}Row")
// //             .Elements("{urn:schemas-microsoft-com:office:spreadsheet}Cell")
// //             .ElementAt(0);

// //         string boletaContent = boletaCell.Elements("{urn:schemas-microsoft-com:office:spreadsheet}Data").Select(data => data.Value).FirstOrDefault();
// //         string monto = boletaCell.Elements("{urn:schemas-microsoft-com:office:spreadsheet}Data").Skip(1).Select(data => data.Value).FirstOrDefault();

// //         Console.WriteLine($"Contenido de la Boleta de Pago: {boletaContent}");
// //         Console.WriteLine($"Monto: {monto}");
// //     }

// //     static void MostrarInformacionAdicional(XDocument xmlDoc)
// //     {
// //         XElement infoCell = xmlDoc.Root
// //             .Elements("{urn:schemas-microsoft-com:office:spreadsheet}Row")
// //             .Elements("{urn:schemas-microsoft-com:office:spreadsheet}Cell")
// //             .ElementAt(2); // Índice 2 para la celda de Información Adicional

// //         string infoContent = infoCell.Value;

// //         Console.WriteLine($"Información Adicional: {infoContent}");
// //     }
// // }

// using System;
// using System.Collections.Generic;
// using System.Xml;

// class Boleta
// {
//     public string Contenido { get; set; }
//     public string Fecha { get; set; }
// }

// class InformacionAdicional
// {
//     public string Contenido { get; set; }
// }

// public class Pago
// {
//     public string Codigo { get; set; }
//     public string Nombre { get; set; }
//     public string Importe { get; set; }
// }

// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             string xmlFilePath = "boleta.xml";
//             XmlDocument xmlDoc = new XmlDocument();
//             xmlDoc.Load(xmlFilePath);

//             Console.WriteLine("¿Qué contenido del XML deseas visualizar?");
//             Console.WriteLine("1. Datos de Boleta");
//             Console.WriteLine("2. Información Adicional");
//             Console.WriteLine("3. Mostrar Pagos");

//             int opcion;
//             do
//             {
//                 Console.Write("Selecciona una opción (1-3): ");
//             } while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3);

//             switch (opcion)
//             {
//                 case 1:
//                     MostrarBoleta(xmlDoc);
//                     break;
//                 case 2:
//                     MostrarInformacionAdicional(xmlDoc);
//                     break;

//             }

//             Console.ReadKey();
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("Error: " + ex.Message);
//         }
//     }

//     static void MostrarBoleta(XmlDocument xmlDoc)
//     {
//         Boleta boleta = ObtenerBoleta(xmlDoc);

//         Console.WriteLine($"Contenido de la Boleta de Pago: {boleta.Contenido}");
//         Console.WriteLine($"Fecha: {boleta.Fecha}");
//     }

//     static Boleta ObtenerBoleta(XmlDocument xmlDoc)
//     {
//         XmlNode boletaCell = xmlDoc.SelectSingleNode("//ss:Row/ss:Cell[1]/ss:Data", GetXmlNamespaceManager(xmlDoc));
//         string boletaContent = boletaCell?.InnerText;

//         XmlNode fecha1 = xmlDoc.SelectSingleNode("//ss:Row/ss:Cell[2]/ss:Data", GetXmlNamespaceManager(xmlDoc));
//         string fecha = fecha1?.InnerText;

//         return new Boleta { Contenido = boletaContent, Fecha = fecha };
//     }

//     static void MostrarInformacionAdicional(XmlDocument xmlDoc)
//     {
//         InformacionAdicional info = ObtenerInformacionAdicional(xmlDoc);

//         Console.WriteLine($"Información Adicional: {info.Contenido}");
//     }

//     static InformacionAdicional ObtenerInformacionAdicional(XmlDocument xmlDoc)
//     {
//         XmlNode infoCell = xmlDoc.SelectSingleNode("//ss:Row[2]/ss:Cell[1]/ss:Data", GetXmlNamespaceManager(xmlDoc));
//         string infoContent = infoCell?.InnerText;

//         return new InformacionAdicional { Contenido = infoContent };
//     }



//     static XmlNamespaceManager GetXmlNamespaceManager(XmlDocument xmlDoc)
//     {
//         XmlNamespaceManager namespaceManager = new XmlNamespaceManager(xmlDoc.NameTable);
//         namespaceManager.AddNamespace("ss", "urn:schemas-microsoft-com:office:spreadsheet");
//         return namespaceManager;
//     }
// }


