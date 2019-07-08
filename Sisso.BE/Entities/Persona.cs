using System;
using System.Collections.Generic;
using System.Text;

namespace Sisso.BE.Entities
{
    public class Persona: BaseEntity
    {
        public Persona()
        {
            PersonaId = Guid.NewGuid();
        }

        public Guid PersonaId { get; set; }

        public string ApellidoMaterno { get; set; }
        public string ApellidoPaterno { get; set; }
        public string NroDoi { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
    }
}
