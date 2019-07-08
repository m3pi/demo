using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sisso.BE.ViewModels
{
    /// <summary>
    /// View model para registrar una persona
    /// </summary>
    public class PersonaAddViewModel
    {
        public string ApellidoMaterno { get; set; }

        [Required(ErrorMessage = "El apellido paterno es obligatorio")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "El apellido paterno debe estar entre 2 y 150 caracteres")]
        public string ApellidoPaterno { get; set; }

        [Required(ErrorMessage = "El Nro. de DOI es obligatorio")]
        public string NroDoi { get; set; }

        [Required(ErrorMessage = "El primer nombre es obligatorio")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "El primer nombre debe estar entre 2 y 150 caracteres")]
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
    }

    /// <summary>
    /// View model para editar una persona
    /// </summary>
    public class PersonaUpdateViewModel
    {
        [Required(ErrorMessage = "El identificador de persona es obligatorio")]
        public Guid Id { get; set; }
    }
}
