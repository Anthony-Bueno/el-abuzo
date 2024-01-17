using System;
using System.Xml;
using System.Linq;
using System.Xml.Linq;
using xml_prueba;
using System.Net;
using System.Text.RegularExpressions;
using System.Text.Json;

public class Pagos
{
    public Pagos()
    {

    }
    public String Codigo { get; set; }
    public String Nombre { get; set; }
    public String Importe { get; set; }
}

public class IndexBoleta
{
    public int rowIndex { get; set; }
    public int cellIndex { get; set; }
    public IndexBoleta(int rowIndex, int cellIndex)
    {
        this.rowIndex = rowIndex;
        this.cellIndex = cellIndex;

    }

    public IndexBoleta()
    {

    }

}

class Program
{
    static void Main()
    {
        try
        {
            String dni = "";


            List<Pagos> listaIngresos = new List<Pagos>();
            List<Pagos> Descuentos = new List<Pagos>();
            List<Pagos> Aportes = new List<Pagos>();


            // Ruta de tu archivo XML
            string xmlFilePath = "/Users/isw17/Desktop/Boletas ayuda/proyecto/xml_prueba/boleta.xml";

            // Crear un nuevo documento XML
            XmlDocument xmlDoc = new XmlDocument();

            // Cargar el XML desde el archivo
            xmlDoc.Load(xmlFilePath);

            // Obtener la información que necesitas navegando por los nodos
            XmlNodeList rows = xmlDoc.SelectNodes("//ss:Row", GetXmlNamespaceManager(xmlDoc));
            Console.WriteLine("*******************************");
            int cont = 0;

            Boleta boleta = new Boleta();


            foreach (XmlNode row in rows)
            {
                cont ++;
                int rowIndex = int.Parse(row.Attributes["ss:Index"].Value);
            

                // Procesar cada fila y sus celdas
                foreach (XmlNode cell in row.SelectNodes("ss:Cell", GetXmlNamespaceManager(xmlDoc)))
                {

                    int cellIndex = int.Parse(cell.Attributes["ss:Index"].Value);

                    IndexBoleta indice = new IndexBoleta(rowIndex,cellIndex);
                    string data = cell.SelectSingleNode("ss:Data", GetXmlNamespaceManager(xmlDoc))?.InnerText;


                    if((indice.rowIndex == 2) && (indice.cellIndex == 9))
                    {
                        boleta.Fecha_Reporte = data;
                    }else if((indice.rowIndex == 3) && (indice.cellIndex == 9))
                    {
                        boleta.Hora_Reporte = data;

                    }else if ((indice.rowIndex == 6) && (indice.cellIndex == 2))
                    {

                        Match match = Regex.Match(data, @":\s*([\d]+)");

                        boleta.Ruc = match.Success? match.Groups[1].Value:"";

                    }
                    else if((indice.rowIndex == 7) && (indice.cellIndex == 2))
                    {
                        Match match = Regex.Match(data, @":\s*([\d]+)");
                        boleta.Empleador = match.Success ? match.Groups[1].Value : "";

                    }
                    else if ((indice.rowIndex == 8) && (indice.cellIndex == 2))
                    {
                        Match match = Regex.Match(data, @":\s*([\d]+)");
                        boleta.Periodo = match.Success ? match.Groups[1].Value : "";

                    }
                    else if ((indice.rowIndex == 13) && (indice.cellIndex == 2))
                    {
                        boleta.Documento_Identidad_Tipo = data;

                    }
                    else if ((indice.rowIndex == 13) && (indice.cellIndex == 3))
                    {
                        boleta.Documento_Identidad_Numero = data;

                    }
                    else if ((indice.rowIndex == 13) && (indice.cellIndex == 4))
                    {
                        boleta.Nombre = data;

                    }
                    else if ((indice.rowIndex == 13) && (indice.cellIndex == 8))
                    {
                        boleta.Situacion = data;

                    }
                    else if ((indice.rowIndex == 15) && (indice.cellIndex == 2))
                    {
                        boleta.Fecha_Ingreso = data;

                    }
                    else if ((indice.rowIndex == 15) && (indice.cellIndex == 4))
                    {
                        boleta.Tipo_Trabajador = data;

                    }
                    else if ((indice.rowIndex == 15) && (indice.cellIndex == 6))
                    {
                        boleta.Regimen_Pensionario = data;

                    }
                    else if ((indice.rowIndex == 18) && (indice.cellIndex == 2))
                    {
                        boleta.Dias_Laborados = data;

                    }
                    else if ((indice.rowIndex == 18) && (indice.cellIndex == 3))
                    {
                        boleta.Dias_NoLaborados = data;

                    }
                    else if ((indice.rowIndex == 18) && (indice.cellIndex == 4))
                    {
                        boleta.Dias_Subsiadiado = data;

                    }
                    else if ((indice.rowIndex == 18) && (indice.cellIndex == 5))
                    {
                        boleta.Condicion = data;

                    }
                    else if ((indice.rowIndex == 18) && (indice.cellIndex == 5))
                    {
                        boleta.Condicion = data;

                    }
                    else if ((indice.rowIndex == 18) && (indice.cellIndex == 6))
                    {
                        boleta.Jornada_Ordinaria_Total = data;

                    }
                    else if ((indice.rowIndex == 18) && (indice.cellIndex == 7))
                    {
                        boleta.Jornada_Ordinaria_Minutos = data;

                    }
                    else if ((indice.rowIndex == 18) && (indice.cellIndex == 8))
                    {
                        boleta.Sobretiempo_Total = data;

                    }
                    else if ((indice.rowIndex == 18) && (indice.cellIndex == 9))
                    {
                        boleta.Sobretiempo_Minutos = data;

                    }
                    else if ((indice.rowIndex == 21) && (indice.cellIndex == 8))
                    {
                        boleta.Empleadores_Renta_Quinta_Categoria = data;

                    }

                    else if (data=="Neto a Pagar")
                    {   

                        int cellIndexNeto = 9;

                        IndexBoleta indiceNeto = new IndexBoleta(rowIndex, cellIndexNeto);
                        var celda = row.ChildNodes[1];
                        string dataNeto = celda.SelectSingleNode("ss:Data", GetXmlNamespaceManager(xmlDoc))?.InnerText;
        
                       boleta.Sueldo_Neto_Pagar = dataNeto;

                    }

                    else if (data == "Ingresos")
                    {
                        Conceptos_Boleta conceptos_Boleta = new Conceptos_Boleta();
                         int indiceFinRow = 0;
                        int indiceInicio = int.Parse(row.Attributes["ss:Index"].Value);

                        //rango fin
                        for (var i = 0; i < rows.Count; i++)
                        {
                           
                            foreach (XmlNode cell2 in rows[i].SelectNodes("ss:Cell", GetXmlNamespaceManager(xmlDoc)))
                            {
                                string dataConcepto = cell2.SelectSingleNode("ss:Data", GetXmlNamespaceManager(xmlDoc))?.InnerText;
                                if (dataConcepto == "Descuentos")
                                {
                                    indiceFinRow = int.Parse(rows[i].Attributes["ss:Index"].Value);

                                }

                            }
                        }

                        //llenado de concepto Ingresos


                        //for (var i = indiceInicio+1; i <= indiceFinRow-1; i++)
                        //{
                        //    XmlNode filaNueva;
                        //    foreach(XmlNode fila in rows)
                        //    {

                        //        if(fila.Attributes("ss:Index") == indiceBuscado)
                                
                        //    }

                        //     rows.(row => (int)row.Attribute("ss:Index") == indiceBuscado);

                          


                        //}





                            {

                        }

                        int cellIndexNeto = 9;

                        IndexBoleta indiceNeto = new IndexBoleta(rowIndex, cellIndexNeto);
                        var celda = row.ChildNodes[1];
                        string dataNeto = celda.SelectSingleNode("ss:Data", GetXmlNamespaceManager(xmlDoc))?.InnerText;

                        boleta.Sueldo_Neto_Pagar = dataNeto;


                    }




                }


            }
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(boleta, options);
            Console.WriteLine("\n============ RESULT DATA ============");
            Console.WriteLine(jsonString);

            var request = boleta;


            // Preguntar al usuario qué contenido desea visualizar
            Console.WriteLine("¿Qué contenido del XML deseas visualizar?");
            Console.WriteLine("1. Boleta de Pago");
            Console.WriteLine("2. Información Adicional");

            int opcion;
            do
            {
                Console.Write("Selecciona una opción (1-2): ");
            } while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 2);

            // Mostrar el contenido según la opción seleccionada
            switch (opcion)
            {
                case 1:
                    MostrarBoleta(xmlDoc);
                    break;
                case 2:
                    MostrarInformacionAdicional(xmlDoc);
                    break;
            }

            // Esperar a que el usuario presione una tecla antes de cerrar la consola
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void MostrarBoleta(XmlDocument xmlDoc)
    {
        XmlNode boletaCell = xmlDoc.SelectSingleNode("//ss:Row/ss:Cell[1]/ss:Data", GetXmlNamespaceManager(xmlDoc));
        string boletaContent = boletaCell?.InnerText;

        XmlNode montoCell = xmlDoc.SelectSingleNode("//ss:Row/ss:Cell[2]/ss:Data", GetXmlNamespaceManager(xmlDoc));
        string monto = montoCell?.InnerText;

        Console.WriteLine($"Contenido de la Boleta de Pago: {boletaContent}");
        Console.WriteLine($"Monto: {monto}");
    }


    static void MostrarInformacionAdicional(XmlDocument xmlDoc)
    {
        XmlNode infoCell = xmlDoc.SelectSingleNode("//ss:Row/ss:Cell[3]/ss:Data", GetXmlNamespaceManager(xmlDoc));
        string infoContent = infoCell?.InnerText;

        Console.WriteLine($"Información Adicional: {infoContent}");
    }

    // Obtener el administrador de espacios de nombres XML para manejar los prefijos
    static XmlNamespaceManager GetXmlNamespaceManager(XmlDocument xmlDoc)
    {
        XmlNamespaceManager namespaceManager = new XmlNamespaceManager(xmlDoc.NameTable);
        namespaceManager.AddNamespace("ss", "urn:schemas-microsoft-com:office:spreadsheet");
        return namespaceManager;
    }

    private static XmlNamespaceManager GetNamespaceManager(XmlDocument xmlDoc)
    {
        XmlNamespaceManager namespaceManager = new XmlNamespaceManager(xmlDoc.NameTable);
        namespaceManager.AddNamespace("ss", "urn:schemas-microsoft-com:office:spreadsheet");
        return namespaceManager;
    }
}

