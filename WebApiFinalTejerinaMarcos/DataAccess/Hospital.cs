using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiFinalTejerinaMarcos.DataAccess
{
    [Table("DbHospitalAPI")]
    public class Hospital
    {
        [Column("Hospital_Cod")]
        [ForeignKey]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Hospital_Cod { get; set; }

        [Column("Nombre")]
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Column("Direccion")]
        [Required]
        [StringLength(50)]
        public string Direccion { get; set; }

        [Column("Telefono")]
        [Required]
        [StringLength(50)]
        public string Telefono { get; set; }

        [Column("Num_Cama")]
        [Required]
        public int Num_Cama { get; set; }
    }
}
