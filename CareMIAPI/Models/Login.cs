using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareMIAPI.Models
{
    [Table("t_login")]
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CdLogin { get; set; }

        [Required]
        [StringLength(15)]
        public string NrCpf { get; set; }

        [Required]
        [StringLength(100)]
        public string DsSenha { get; set; }

        [Required]
        public bool FgAtivo { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }

        public Login()
        {
        }

        public Login(int cdLogin, string nrCpf, string dsSenha, bool fgAtivo, int usuarioId)
        {
            CdLogin = cdLogin;
            NrCpf = nrCpf;
            DsSenha = dsSenha;
            FgAtivo = fgAtivo;
            UsuarioId = usuarioId;
        }
    }
}