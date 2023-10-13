using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Entities
{
    public class Salon : BaseEntity
    {
        public int NombreSalon { get; set; }
        public int Capacidad { get; set; }
    }
}
