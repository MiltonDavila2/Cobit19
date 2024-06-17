using System.ComponentModel.DataAnnotations;

namespace Cobit19.Data
{
    public class MetasAlineamiento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string MetaGobierno { get; set; }

        public string? AG01 { get; set; }

        public string? AG02 { get; set; }
        public string? AG03 { get; set; }
        public string? AG04 { get; set; }
        public string? AG05 { get; set; }
        public string? AG06 { get; set; }
        public string? AG07 { get; set; }
        public string? AG08 { get; set; }
        public string? AG09 { get; set; }
        public string? AG10 { get; set; }
        public string? AG11 { get; set; }

        public string? AG12 { get; set; }
        public string? AG13 { get; set; }
    }
}
