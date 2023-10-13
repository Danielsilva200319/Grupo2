using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Entities
{
    public class Departamento : BaseEntity
    {
        public string NombreDep { get; set; }
        public ICollection<Pais> IdPais { get; set; }
    }
}
