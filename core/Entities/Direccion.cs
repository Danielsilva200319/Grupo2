using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Entities
{
    public class Direccion : BaseEntity
    {
        public string TipoVia { get; set; }
        public int Numero { get; set; }
    }
}