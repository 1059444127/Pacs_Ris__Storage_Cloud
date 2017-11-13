using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico
    {
        public int Id { get; set; }
        public int Nome { get; set; }

        //relacionamento
        public List<Consulta> Consultas { get; set; }
    }
}
