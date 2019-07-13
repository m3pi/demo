using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sisso.DAL.Services
{
    public interface IPersonaRepository
    {
        Task<object> Info();
    }
}
