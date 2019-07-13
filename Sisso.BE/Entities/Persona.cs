using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sisso.BE.Entities
{
    [Table("Personas")]
    public class Persona: BaseEntity
    {
        public Persona()
        {
            PersonaId = Guid.NewGuid();
        }

        [Key]
        public Guid PersonaId { get; set; }

        public string ApellidoMaterno { get; set; }
        public string ApellidoPaterno { get; set; }
        public string NroDoi { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }

        public Guid TipoDocumentoIdentidadId { get; set; }
        [ForeignKey(nameof(TipoDocumentoIdentidadId))]
        public TipoDocumentoIdentidad TipoDocumentoIdentidad { get; set; }
    }
}
