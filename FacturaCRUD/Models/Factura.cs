using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacturaCRUD.Models
{
    public class Factura
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El número de factura es obligatorio")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string NumeroFactura { get; set; }

        [Required(ErrorMessage = "La fecha de vencimiento es obligatoria")]
        public DateTime FechaVencimiento { get; set; }

        [NotMapped] // No se almacena en la base de datos
        public string Estado
        {
            get
            {
                var hoy = DateTime.Today;
                if (FechaVencimiento < hoy) return "Vencida";
                if ((FechaVencimiento - hoy).TotalDays <= 3) return "Próxima a vencer";
                return "Vigente";
            }
        }
    }
}
