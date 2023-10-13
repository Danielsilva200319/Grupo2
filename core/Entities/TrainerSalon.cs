using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Entities
{
    public class TrainerSalon : BaseEntity
    {
        public ICollection<Persona> IdPersona { get; set; }
        public ICollectio<Salon> IdSalon { get; set; }
    }
}
