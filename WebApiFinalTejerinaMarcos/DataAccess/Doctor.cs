using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiFinalTejerinaMarcos.DataAccess
{
    [Table("DbHospitalAPI")]
    public class Doctor
    {
        [Column("Doctor_No")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Doctor_No { get; set; }

        [Column("Hospital_Cod")]
        [Required]
        public int Hospital_Cod { get; set; }

        [Column("Apellido")]
        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Column("Especialidad")]
        [Required]
        [StringLength(50)]
        public string Especialidad { get; set; }
    }
}
