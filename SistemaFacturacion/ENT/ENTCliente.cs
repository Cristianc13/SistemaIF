using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ENTCliente
    {
        public int idCLiente { get; set; }
        public string nombreCliente { get; set; }
        public string apellidoCliente { get; set; }
        public string telefono { get; set; }

        public ENTCliente(int idClientec, string nombreClientec, string apellidoClientec, string telefonoc)
        {
            this.idCLiente = idClientec;
            this.nombreCliente = nombreClientec;
            this.apellidoCliente = apellidoClientec;
            this.telefono = telefonoc;
        }

        public ENTCliente(int idC)
        {
            this.idCLiente = idC;
        }
            
    }
}