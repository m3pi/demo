using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sisso.BE.Entities
{
    [Table("TipoDocumentoIdentidades")]
    public class TipoDocumentoIdentidad: BaseEntity
    {
        public TipoDocumentoIdentidad()
        {
            TipoDocumentoIdentidadId = Guid.NewGuid();
        }

        [Key]
        public Guid TipoDocumentoIdentidadId { get; set; }

        public string Nombre { get; set; }
        public string Codigo { get; set; }

        //[InverseProperty(nameof(Persona.TipoDocumentoIdentidad))]
        //public ICollection<Persona> Personas { get; set; } = new List<Persona>();
    }
}
