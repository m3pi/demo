using Microsoft.EntityFrameworkCore;
using Sisso.BE.Entities;
using Sisso.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisso.DAL
{
    public class PersonaRepository : MasterRepository, IPersonaRepository
    {
        public async Task<object> Info()
        {
            dynamic info = new System.Dynamic.ExpandoObject();
            try
            {
                var query = await Context.Personas.FirstOrDefaultAsync(x => x.Deleted == null);
                var personas = new List<Persona>
                {
                    new Persona { ApellidoMaterno = "Guarniz", ApellidoPaterno = "Saavedra", NroDoi = "47701560", PrimerNombre = "Oscar", SegundoNombre = "Geny" },
                    new Persona { ApellidoMaterno = "Urteaga", ApellidoPaterno = "Bazan", NroDoi = "87654321", PrimerNombre = "Anderson", SegundoNombre = "Kevin" }
                };

                info.data = personas;
                info.total = personas.Count();
                info.mensaje = "Lista de personas obtenidas correctamente";
                info.confirmacion = true;
            }
            catch (Exception ex)
            {
                info.excepcion = ex.ToString();
                info.mensaje = "No se pudo obtner la lista de personas";
                info.confimacion = false;
            }

            return await Task.FromResult(info);
        }
    }
}
