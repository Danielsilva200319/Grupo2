using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Entities
{
    public class Persona : BaseEntity
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public ICollection<Genero> IdGenero { get; set; }
        public ICollection<Ciudad> IdCiudad { get; set; }
        public ICollection<TipoPersona> IdTipoPersona { get; set; }
    }
}
