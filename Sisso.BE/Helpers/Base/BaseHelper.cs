using System;
using System.Collections.Generic;
using System.Text;

namespace Sisso.BE.Helpers
{
    public class BaseHelper
    {
        #region Fechas

        /// <summary>
        /// Gets the SA Pacific Standard Time.
        /// Se obtiene la fecha y hora
        /// </summary>
        /// <returns>The SA Pacific Standard Time date time 1993/02/22 05:33:23.</returns>
        public DateTime DateTimePst()
        {
            try
            {
                DateTime fServer = DateTime.UtcNow;
                TimeZoneInfo timeLima = TimeZoneInfo.FindSystemTimeZoneById("SA Pacific Standard Time");
                return fServer = TimeZoneInfo.ConvertTimeFromUtc(fServer, timeLima);
            }
            catch
            {
                return DateTime.Now;
            }

        }

        /// <summary>
        /// Gets the SA Pacific Standard Time date.
        /// Se obtines solo la fecha con hora 00:00
        /// </summary>
        /// <returns>The SA Pacific Standard Time date 1993/02/22 00:00:00.</returns>
        public DateTime DatePst()
        {
            try
            {
                DateTime fServer = DateTime.UtcNow;
                TimeZoneInfo timeLima = TimeZoneInfo.FindSystemTimeZoneById("SA Pacific Standard Time");
                fServer = TimeZoneInfo.ConvertTimeFromUtc(fServer, timeLima);
                DateTime date = new DateTime(fServer.Year, fServer.Month, fServer.Day);

                return date;
            }
            catch
            {
                DateTime fServer = DateTime.Now;
                DateTime date = new DateTime(fServer.Year, fServer.Month, fServer.Day);
                return date;
            }

        }

        /// <summary>
        /// Parses the date from string.
        /// </summary>
        /// <returns>The date from string 1993/02/22 00:00:00.</returns>
        /// <param name="fechax">Formato de fecha: 1993,02,22</param>
        public DateTime ParseDateFromString(string fechax)
        {
            string[] toFecha = fechax.Split(',');
            var fecha = new DateTime(Convert.ToInt32(toFecha[0]),
                                     Convert.ToInt32(toFecha[1]),
                                     Convert.ToInt32(toFecha[2])).Date;

            return fecha;
        }

        /// <summary>
        /// Parses the date time from string.
        /// </summary>
        /// <returns>The date time from string 1993/02/22 05:33:23.</returns>
        /// <param name="fechax">Formato de fecha: 1993,02,22,05,33,23</param>
        public DateTime ParseDateTimeFromString(string fechax)
        {
            string[] toFecha = fechax.Split(',');
            var fecha = new DateTime(Convert.ToInt32(toFecha[0]),
                                     Convert.ToInt32(toFecha[1]),
                                     Convert.ToInt32(toFecha[2]),
                                     Convert.ToInt32(toFecha[3]),
                                     Convert.ToInt32(toFecha[4]),
                                     Convert.ToInt32(toFecha[5]));

            return fecha;
        }

        /// <summary>
        /// Obtiene la fecha en formato de:
        /// 24 horas "22/02/1993 23:03"
        /// 12 horas "22/02/1993 03:03 AM"
        /// </summary>
        /// <returns>The fecha w fotmat or '-'.</returns>
        /// <param name="fecha">Fecha.</param>
        /// <param name="formato">Formato:
        /// > 12: 12 horas más hora y minutos AM/PM
        /// > 24: 24 horas más hora y minutos
        /// > ,: 1993,02,22
        /// > Por defecto solo fecha
        /// </param>
        public string FormatDateTo(DateTime? fecha, string formato = "")
        {
            if (fecha == null) return "-";

            string result = default(string);

            switch (formato)
            {
                case "12":
                    result = $"{fecha:dd/MM/yyyy hh:mm tt}";
                    break;
                case "24":
                    result = $"{fecha:dd/MM/yyyy HH:mm}";
                    break;
                case ",":
                    result = $"{fecha:yyyy,MM,dd}";
                    break;
                default:
                    result = $"{fecha:dd/MM/yyyy}";
                    break;
            }

            return result;
        }

        #endregion
    }
}
