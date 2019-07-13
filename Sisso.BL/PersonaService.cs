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

        public Task<object> Info()
        {
            return PersonaRepository.Info();
        }
    }
}
