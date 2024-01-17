using System;
namespace xml_prueba
{
	public class Boleta
	{
		public Boleta()
		{
		}

		public String Fecha_Reporte { get; set; }
        public String Hora_Reporte { get; set; }
		public String Ruc { get; set; }
        public String Empleador { get; set; }
        public String Periodo { get; set; }
        public String Numero_Orden { get; set; }
        public String Documento_Identidad_Tipo { get; set; }
        public String Documento_Identidad_Numero { get; set; }
        public String Nombre { get; set; }
        public String Situacion { get; set; }
        public String Fecha_Ingreso { get; set; }
        public String Tipo_Trabajador { get; set; }
        public String Regimen_Pensionario { get; set; }
        public String Cuspp { get; set; }
        public String Dias_Laborados { get; set; }
        public String Dias_NoLaborados { get; set; }
        public String Dias_Subsiadiado { get; set; }
        public String Condicion { get; set; }
        public String Jornada_Ordinaria_Total { get; set; }
        public String Jornada_Ordinaria_Minutos { get; set; }
        public String Sobretiempo_Total { get; set; }
        public String Sobretiempo_Minutos { get; set; }
        public String Motivo_Suspension_Tipo { get; set; }
        public String Motivo_Suspension_Motivo { get; set; }
        public String Motivo_Suspension_N_Dias { get; set; }
        public String Empleadores_Renta_Quinta_Categoria { get; set; }
        public String Sueldo_Neto_Pagar { get; set; }
        public List<Conceptos_Boleta> conceptos_Boleta { get; set; }


    }
    public class Conceptos_Boleta
     {
        public Conceptos_Boleta()
        {
        }

        public String Codigo { get; set; }
        public String Concepto { get; set; }
        public String Ingresos { get; set; }
        public String Descuentos { get; set; }
        public String Neto { get; set; }
        public String Tipo { get; set; }

    }



}

