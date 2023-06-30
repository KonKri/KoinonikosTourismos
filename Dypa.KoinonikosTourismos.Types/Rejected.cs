using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dypa.KoinonikosTourismos.Types
{
    [Table("Rejected_Final")]
    public class Rejected : BasicInfoEntity
    {
        [Key]
        public int Id { get; set; }

        [Column("ΑΡ_ΠΡΩΤ_ΑΙΤΗΣΗΣ")]
        public string? ApplicationId { get; set; }

        [Column("ΛΟΓΟΣ_ΑΠΟΡΡΙΨΗΣ")]
        public string? RejectionReason { get; set; }
    }
}
