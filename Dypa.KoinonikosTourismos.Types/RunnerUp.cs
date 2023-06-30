using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dypa.KoinonikosTourismos.Types
{
    [Table("RunnerUp_Final")]
    public class RunnerUp : BasicInfoEntity
    {
        [Key]
        public int Id { get; set; }

        [Column("ΑΡ_ΠΡΩΤ_ΑΙΤΗΣΗΣ")]
        public string? ApplicationId { get; set; }

        [Column("ΚΡΙΤΗΡΙΟ_1")]
        public string? Criteria1 { get; set; }

        [Column("ΚΡΙΤΗΡΙΟ_2")]
        public string? Criteria2 { get; set; }

        [Column("ΚΡΙΤΗΡΙΟ_3")]
        public string? Criteria3 { get; set; }

        [Column("ΚΡΙΤΗΡΙΟ_4")]
        public string? Criteria4 { get; set; }

        [Column("ΣΥΝΟΛΟ_ΜΟΡΙΩΝ")]
        public string? TotalScore { get; set; }

        [Column("ΣΕΙΡΑ_ΚΑΤΑΤΑΞΗΣ")]
        public string? Ranking { get; set; }

        [Column("ΑΡΙΘΜΟΣ_ΕΠΙΤΑΓΗΣ")]
        public string? TicketNumber { get; set; }
    }
}
