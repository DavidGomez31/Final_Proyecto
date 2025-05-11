using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proyecto
{
    public class SensorData
    {
        public DateTime FechaHora { get; set; }
        public double PH { get; set; }
        public double Turbidez { get; set; }
        public double Metales { get; set; }
        public double Quimicos { get; set; }
    }

    public static class DatosGlobales
    {
        public static List<SensorData> ListaDatos = new List<SensorData>();
    }
}
