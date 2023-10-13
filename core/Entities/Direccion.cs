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
        public string Letra { get; set; }
        public string SufijoCardinal { get; set; }
        public int NroViaSecundaria { get; set; }
        public string LetraViaSecundaria { get; set; }
        public int SufijoCards { get; set; }
        public ICollection<Persona> IdPersona { get; set; }
    }
}
