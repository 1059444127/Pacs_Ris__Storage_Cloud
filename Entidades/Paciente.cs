using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        //relacionamento
        public List<Consulta> Consultas { get; set; }
    }
}
