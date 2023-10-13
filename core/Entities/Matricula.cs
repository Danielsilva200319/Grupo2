using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Entities
{
    public class Matricula : BaseEntity
    {
        public ICollection<Persona> IdPersona { get; set; }
        public ICollection<Salon> IdSalon { get; set; }
    }
}
