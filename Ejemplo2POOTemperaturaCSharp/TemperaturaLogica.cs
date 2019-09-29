using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2POOTemperaturaCSharp
{
   public class TemperaturaLogica : Temperatura
    {
        public double calcularFarenheit()
        {
            return ((this.getGrados() * 9 / 5) + 32);
        }

        public double calcularCentigrados()
        {
            return ((this.getGrados() - 32) * 5 / 9);
        }
       
       
    }
}
