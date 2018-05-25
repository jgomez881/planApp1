using System;
using System.Collections.Generic;
using System.Text;

namespace PlanApp1.Models
{
    public class Comentario
    {
        public string Mensaje { get; set; }
        public DateTime Fecha { get; set; }

        public string FechaFormato
        {
            get
            {
                if (Fecha.Equals(new DateTime(1, 1, 1)))
                    return "";
                else
                    return Fecha.ToString("dd/MM/yyyy");
            }
        }
    }
}
