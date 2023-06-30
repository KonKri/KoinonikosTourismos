using System.ComponentModel.DataAnnotations.Schema;

namespace Dypa.KoinonikosTourismos.Types
{
    public abstract class BasicInfoEntity
    {
        [Column("ΑΦΜ")]
        public string? VatNumber { get; set; }

        [Column("ΑΜΚΑ")]
        public string? SocialSecurityNumber { get; set; }
    }
}
