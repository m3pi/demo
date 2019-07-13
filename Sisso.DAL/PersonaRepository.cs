using Microsoft.EntityFrameworkCore;
using Sisso.BE.DTO;
using Sisso.BE.Entities;
using Sisso.BE.ViewModels;
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
        public async Task<ReponseDTO> Add(PersonaAddViewModel model)
        {
            var info = new ReponseDTO();

            try
            {
                var persona = new Persona
                {
                    ApellidoMaterno = model.ApellidoMaterno,
                    ApellidoPaterno = model.ApellidoPaterno,
                    NroDoi = model.NroDoi,
                    PrimerNombre = model.PrimerNombre,
                    SegundoNombre = model.SegundoNombre
                };

                Context.Personas.Add(persona);
                await Context.SaveChangesAsync();

                info.Mensaje = "Informaci[on de persona registrada correctamente";
                info.Confirmacion = true;
            }
            catch (Exception ex)
            {
                info.Excepcion = ex.ToString();
                info.Mensaje = $"Error: No se pude registrar la personas";
            }

            return info;
        }

        public async Task<Persona> FinPersonaByDoi(string nroDoi)
        {
            return await Context.Personas.FirstOrDefaultAsync(x => x.Deleted == null && x.NroDoi == nroDoi);
        }

        public async Task<object> Info()
        {
            dynamic info = new System.Dynamic.ExpandoObject();
            try
            {
                var personas = await Context.Personas.Where(x => x.Deleted == null).ToListAsync();
                //var personas = new List<Persona>
                //{
                //    new Persona { ApellidoMaterno = "Guarniz", ApellidoPaterno = "Saavedra", NroDoi = "47701560", PrimerNombre = "Oscar", SegundoNombre = "Geny" },
                //    new Persona { ApellidoMaterno = "Urteaga", ApellidoPaterno = "Bazan", NroDoi = "87654321", PrimerNombre = "Anderson", SegundoNombre = "Kevin" }
                //};

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
