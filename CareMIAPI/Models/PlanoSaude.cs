using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CareMIAPI.Models
{
    [Table("t_plano_saude")]
    public class PlanoSaude
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CdPlanoSaude { get; set; }

        [Required]
        [StringLength(100)]
        public string DsRazaoSocial { get; set; }

        [Required]
        [StringLength(100)]
        public string NmFantasia { get; set; }

        [Required]
        [Column(TypeName = "NUMBER(14)")]
        public int NrCnpj { get; set; }

        [Required]
        [StringLength(100)]
        public string NmContato { get; set; }

        [Required]
        [Column(TypeName = "NUMBER(8)")]
        public int NrTelefone { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime DtCadastro { get; set; }

        [Required]
        [Column(TypeName = "NUMBER(1)")]
        public bool FgAtivo { get; set; }

        public ICollection<PacientePlanoSaude>? PacientePlanosSaude { get; set; }
        public PlanoSaude()
        {
        }

        public PlanoSaude(int cdPlanoSaude, string dsRazaoSocial, string nmFantasia, int nrCnpj, string nmContato, int nrTelefone, DateTime dtCadastro, bool fgAtivo)
        {
            CdPlanoSaude = cdPlanoSaude;
            DsRazaoSocial = dsRazaoSocial;
            NmFantasia = nmFantasia;
            NrCnpj = nrCnpj;
            NmContato = nmContato;
            NrTelefone = nrTelefone;
            DtCadastro = dtCadastro;
            FgAtivo = fgAtivo;
        }
    }
}