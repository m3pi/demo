using Sisso.BE.DTO;
using Sisso.BE.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sisso.BL.Service
{
    public interface IPersonaService
    {
        Task<ReponseDTO> Add(PersonaAddViewModel model);
        Task<object> Info();
    }
}
