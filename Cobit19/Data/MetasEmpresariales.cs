using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Cobit19.Data
{
    public class MetasEmpresariales
    {
        [Key]
        public int Id { get; set; }

        [Required]
        
        public string MetaAlineamiento { get; set; }

        public string? EG01 { get; set; }

        public string? EG02 { get; set; }
        public string? EG03 { get; set; }
        public string? EG04 { get; set; }
        public string? EG05 { get; set; }
        public string? EG06 { get; set; }
        public string? EG07 { get; set; }
        public string? EG08 { get; set; }
        public string? EG09 { get; set; }
        public string? EG10 { get; set; }
        public string? EG11 { get; set; }

        public string? EG12 { get; set; }
        public string? EG13 { get; set; }
    }
}
