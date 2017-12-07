using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantisChew
{
    public class Equipo
    {
        public List<string> Usuarios { get; set; }
        public List<int> MantisInternos { get; set; }

        public Equipo()
        {
            Usuarios = new List<string>();
            MantisInternos = new List<int>();
        }
    }
}
