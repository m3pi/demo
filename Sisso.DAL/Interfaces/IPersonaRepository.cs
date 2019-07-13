using Sisso.BE.DTO;
using Sisso.BE.Entities;
using Sisso.BE.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sisso.DAL.Services
{
    public interface IPersonaRepository
    {
        Task<ReponseDTO> Add(PersonaAddViewModel model);
        Task<Persona> FinPersonaByDoi(string nroDoi);
        Task<object> Info();
    }
}
