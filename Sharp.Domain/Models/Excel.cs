using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp.Domain.Models
{
    public class Excel
    {
        [DisplayName("Nº DOSSIÊ")]
        public string NumeroDossie { get; set; }

        [DisplayName("Desdobramento")]
        public string Desdobramento { get; set; }

        [DisplayName("Evento")]
        public string Evento { get; set; }

        [DisplayName("Recebimento do documento")]
        public string ReciboDocumento { get; set; }

        [DisplayName("Data do Evento")]
        public string DataEvento { get; set; }

        [DisplayName("Documento")]
        public string Documento { get; set; }
    }
}
