using System;
using System.Collections.Generic;
using System.Text;

namespace Sisso.BE.DTO
{
    public class BaseResponseDTO
    {
        public BaseResponseDTO()
        {
            Excepcion = string.Empty;
            Confirmacion = false;
        }

        public string Excepcion { get; set; }
        public string Mensaje { get; set; }
        public bool Confirmacion { get; set; }
        //public IDictionary<string, string> Errores { get; set; }
    }

    public class ReponseDTO: BaseResponseDTO
    {

    }

    public class TableDTO<T> : BaseResponseDTO
    {
        public int Total { get; set; }
        public IEnumerable<T> Data { get; set; }
    }

    public class InfoDTO<T> : BaseResponseDTO
    {
        public T Data { get; set; }
    }
}
