using Sisso.BE.DTO;
using Sisso.BE.ViewModels;
using Sisso.BL.Service;
using Sisso.DAL.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sisso.BL
{
    public class PersonaService : IPersonaService
    {
        private IPersonaRepository PersonaRepository { get; set; }

        public PersonaService(IPersonaRepository personaRepository)
        {
            PersonaRepository = personaRepository;
        }

        public async Task<ReponseDTO> Add(PersonaAddViewModel model)
        {
            var info = new ReponseDTO();
            var existeOtraPersona = await PersonaRepository.FinPersonaByDoi(model.NroDoi);
            if (existeOtraPersona != null)
            {
                info.Mensaje = "Existe otra persona registrada con el mismo n[umero de DNI";
                return info;
            }

            return await PersonaRepository.Add(model);
        }

        public Task<object> Info()
        {
            return PersonaRepository.Info();
        }
    }
}
