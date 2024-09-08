using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareMIAPI.Models
{
    [Table("t_exame")]
    public class Exame
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CdExame { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime DtExame { get; set; }
        [Required]
        [StringLength(50)]
        public string DsExame { get; set; }

        public Exame() { }
        public Exame(int cdExame, string dsExame, DateTime dtExame)
        {
            CdExame = cdExame;
            DsExame = dsExame;
            DtExame = dtExame;
        }
    }
}
