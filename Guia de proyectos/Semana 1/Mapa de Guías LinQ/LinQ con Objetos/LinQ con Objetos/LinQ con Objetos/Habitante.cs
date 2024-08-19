using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    public class Habitante
    {
        public int IdHabitante { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int IdCasa { get; set; }

        public string datosHabitante()
        {

            return $"Soy {Nombre} con edad de {Edad} años vividos en {IdCasa}";
        }
    }
}
