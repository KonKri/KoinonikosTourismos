using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dypa.KoinonikosTourismos.Types
{
    [Table("RejectedMember_Final")]
    public class RejectedMember : BasicInfoEntity
    {
        [Key]
        public int Id { get; set; }

        [Column("ΑΡ_ΠΡΩΤ_ΑΙΤΗΣΗΣ")]
        public string? ApplicationId { get; set; }

        [Column("ΟΝ_ΜΟ")]
        public string? FullName { get; set; }

        [Column("ΑΜΚΑ_ΩΦΕΛ")]
        public string? SocialSecurityNumberMember { get; set; }
    }
}
