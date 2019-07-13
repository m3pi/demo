using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sisso.BE.Entities
{
    public class TipoDocumentoIdentidad: BaseEntity
    {
        public TipoDocumentoIdentidad()
        {

        }

        [Key]
        public Guid TipoDocumentoIdentidadId { get; set; }

        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public ICollection<Persona> Personas { get; set; } = new List<Persona>();
    }
}
