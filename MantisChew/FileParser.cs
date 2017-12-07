using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantisChew
{
    public class FileParser
    {
        public static List<TimeTrack> Parse(string file)
        {
            var res = new List<TimeTrack>();
            using (StreamReader streamreader = new StreamReader(file))
            {
                var discardFirtLine = streamreader.ReadLine();
                while (streamreader.Peek() > 0)
                {
                    var track = ParseLine(streamreader.ReadLine());
                    if (track != null) res.Add(track);
                }
            }

            return res;
        }

        private static TimeTrack ParseLine(string line)
        {
            TimeTrack track = null;
            try
            {
                char[] delimiter = new char[] { '\t' };
                var data = line.Split(delimiter);
                var fecha = DateTime.ParseExact(data[1], "yyyy-MM-dd", null);
                var horas = Decimal.Parse(data[5].Replace('.', ','));
                var mantis = int.Parse(data[2]);
                track = new TimeTrack()
                {
                    Usuario = data[0],
                    Fecha = fecha,
                    Mantis = mantis,
                    Categoria = data[3],
                    Descripcion = data[4],
                    Horas = horas,
                    Tecnologia = data[6],
                    Informacion = data[7],
                    Actividad = data[8],
                    Proyecto= data[9]
                };

            }
            catch (Exception)
            {
            }
            return track;
        }
    }
}
