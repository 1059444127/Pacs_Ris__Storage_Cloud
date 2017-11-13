using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Consulta
    {
        public int Id { get; set; }
        public string Laudo { get; set; }
        public DateTime DataConsulta { get; set; }

        //chave estrangeiras
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
    }
}
