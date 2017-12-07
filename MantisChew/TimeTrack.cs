using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantisChew
{
    public class TimeTrack
    {
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public int Mantis { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public decimal Horas { get; set; }
        public string Tecnologia { get; set; }
        public string Informacion { get; set; }
        public string Actividad { get; set; }
        public string Proyecto { get; set; }
    }
}
