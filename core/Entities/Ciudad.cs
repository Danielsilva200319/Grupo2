using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Entities
{
    public class Ciudad : BaseEntity
    {
        public string NombreCiudad { get; set; }
        public ICollection<Departamento> IdDepartamento { get; set; }
    }
}